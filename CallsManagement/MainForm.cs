using CallsManagement.Data;
using DevExpress.Xpo.DB;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static DevExpress.XtraEditors.Mask.MaskSettings;
using System.Xml.Serialization;
using System.IO;
using System.Xml;
using System.Xml.Linq;
using CallsManagement.Controls;
using DevExpress.XtraEditors;
using DevExpress.Utils.Extensions;
using DevExpress.LookAndFeel;
using System.Security.Policy;
using System.Collections.ObjectModel;

namespace CallsManagement
{
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        UserConfig userConfig;

        public MainForm()
        {
            InitializeComponent();
        }


        public MainForm(UserConfig userConfig)
            : this()
        {
            this.userConfig = userConfig;
        }


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            var filePath = Path.Combine(Environment.GetFolderPath(
            Environment.SpecialFolder.LocalApplicationData), "CallsManagement\\UserConfig.xml");

            XmlSerializer serializer = new XmlSerializer(typeof(UserConfig));

            using (Stream reader = new FileStream(filePath, FileMode.Create))
            {
                serializer.Serialize(reader, userConfig);
            }          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            xucCalls xucCalls = new xucCalls();
            tabbedView1.AddDocument(xucCalls);
            tabbedView1.ActivateDocument(xucCalls);

            var page = rcMain.MergedPages.Where(x => x.Name == "rpActions").FirstOrDefault();

            rcMain.SelectPage(page);

            cbeLanguages.SelectedIndexChanged -= cbeLanguages_SelectedIndexChanged;

            if (userConfig.Language == "en") cbeLanguages.SelectedIndex = 0;
            else cbeLanguages.SelectedIndex = 1;

            cbeLanguages.SelectedIndexChanged += cbeLanguages_SelectedIndexChanged;

            if (userConfig.Pallete == "Default") cbePalletes.Properties.Items.Add("Default");
            else 
            {
                cbePalletes.Properties.Items.Add("Default");
                cbePalletes.Properties.Items.AddRange(SkinSvgPalette.WXI.PaletteSet.Keys
                                                        .Where(key => key != "DefaultSkinPalette")
                                                        .ToArray());                
            }           
            
            cbeThemes.SelectedIndexChanged -= cbeThemes_SelectedIndexChanged;

            cbeThemes.SelectedIndex = cbeThemes.Properties.Items.IndexOf(userConfig.Theme);

            if(userConfig.Pallete == "DefaultSkinPalette") cbePalletes.SelectedIndex = 0;
            else cbePalletes.SelectedIndex = cbePalletes.Properties.Items.IndexOf(userConfig.Pallete);
          
            cbeThemes.SelectedIndexChanged += cbeThemes_SelectedIndexChanged;
        }

        private void RibbonParameters_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            switch (e.Item.Tag)
            {
                case "Calls":
                    {
                        var document = tabbedView1.Documents.Where(d => d.Control.GetType() == typeof(xucCalls)).FirstOrDefault();


                        if (document != null) tabbedView1.ActivateDocument(document.Control);
                        else
                        {
                            xucCalls xucCalls = new xucCalls();
                            tabbedView1.AddDocument(xucCalls);
                            tabbedView1.ActivateDocument(xucCalls);
                        }

                        break;
                    }
                case "CallContacts":
                    {
                        var document = tabbedView1.Documents.Where(d => d.Control.GetType() == typeof(xucCallContacts)).FirstOrDefault();


                        if (document != null) tabbedView1.ActivateDocument(document.Control);
                        else
                        {
                            xucCallContacts callContacts = new xucCallContacts(userConfig);


                            tabbedView1.AddDocument(callContacts);
                            tabbedView1.ActivateDocument(callContacts);
                        }

                        break;
                    }
                case "CallTypes":
                    {
                        var document = tabbedView1.Documents.Where(d => d.Control.GetType() == typeof(xucCallTypes)).FirstOrDefault();


                        if (document != null) tabbedView1.ActivateDocument(document.Control);
                        else
                        {
                            xucCallTypes callTypes = new xucCallTypes();

                            tabbedView1.AddDocument(callTypes);
                            tabbedView1.ActivateDocument(callTypes);
                        }

                        break;
                    }
                case "CallReceivers":
                    {
                        var document = tabbedView1.Documents.Where(d => d.Control.GetType() == typeof(xucCallReceivers)).FirstOrDefault();


                        if (document != null) tabbedView1.ActivateDocument(document.Control);
                        else
                        {
                            xucCallReceivers callReceivers = new xucCallReceivers();

                            tabbedView1.AddDocument(callReceivers);
                            tabbedView1.ActivateDocument(callReceivers);
                        }

                        break;
                    }
            }

            var page = rcMain.MergedPages.Where(x => x.Name == "rpActions").FirstOrDefault();

            rcMain.SelectPage(page);           
        }


        private void cbeLanguages_SelectedIndexChanged(object sender, EventArgs e)
        {
                cbeLanguages.SelectedIndexChanged -= cbeLanguages_SelectedIndexChanged;

                DialogResult dialogResult;

                dialogResult = XtraMessageBox.Show(Localization.Restart_Msg, Localization.Confirmation_Msg, MessageBoxButtons.YesNo);

                if (cbeLanguages.EditValue.ToString() == "Αγγλικά") userConfig.Language = "en";
                else userConfig.Language = "el";

                switch (dialogResult)
                {
                    case DialogResult.Yes:
                        {
                            Application.Restart();
                            break;
                        }
                    case DialogResult.No:
                        {
                            if (cbeLanguages.SelectedIndex == 0) cbeLanguages.SelectedIndex = 1;
                            else cbeLanguages.SelectedIndex = 0;

                            cbeLanguages.SelectedIndexChanged += cbeLanguages_SelectedIndexChanged;

                            return;
                        }
                }            
        }

        private void sbApplyTheme_Click(object sender, EventArgs e)
        {
            userConfig.Theme = cbeThemes.EditValue.ToString();
            userConfig.Pallete = cbePalletes.EditValue.ToString(); 

            if (cbeThemes.EditValue.ToString() == "WXI")
            {
                UserLookAndFeel.Default.SetSkinStyle(SkinStyle.WXI);

                if(cbePalletes.EditValue.ToString() == "Default")
                {
                    MessageBox.Show(cbePalletes.EditValue.ToString().Trim());
                    UserLookAndFeel.Default.SetSkinStyle(SkinSvgPalette.WXI.Default);
                    userConfig.Pallete = "DefaultSkinPalette";
                    return;
                }
                    
                UserLookAndFeel.Default.SetSkinStyle(SkinSvgPalette.WXI.PaletteSet[cbePalletes.EditValue.ToString()]);
            }   
            else if (cbeThemes.EditValue.ToString() == "WXI Compact")
            {
                UserLookAndFeel.Default.SetSkinStyle(SkinStyle.WXICompact);
                UserLookAndFeel.Default.SetSkinStyle(SkinSvgPalette.WXICompact.PaletteSet[cbePalletes.EditValue.ToString()]);         
            }
            else
            {
                UserLookAndFeel.Default.SetSkinStyle(SkinSvgPalette.WXI.Default);
            }        
        }

        private void cbeThemes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbeThemes.EditValue.ToString() == "Default")
            {
                cbePalletes.Properties.Items.Clear();
                cbePalletes.Properties.Items.Add("Default");
                cbePalletes.SelectedIndex = 0;
            }
            else
            {
                cbePalletes.Properties.Items.Clear();
                cbePalletes.Properties.Items.Add("Default");
                cbePalletes.Properties.Items.AddRange(SkinSvgPalette.WXI.PaletteSet.Keys
                                                        .Where(key => key != "DefaultSkinPalette")
                                                        .ToArray());               
            }               
        }
    }
}
