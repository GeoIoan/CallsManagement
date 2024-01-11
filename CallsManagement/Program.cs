using DevExpress.Skins;
using DevExpress.UserSkins;
using DevExpress.Xpo.DB;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using CallsManagement.Data;
using System.IO;
using System.Xml.Serialization;
using DevExpress.XtraEditors.TableLayout;
using Microsoft.Data.ConnectionUI;
using DevExpress.Utils.Extensions;
using System.Data.SqlClient;
using DevExpress.ExpressApp;
using System.Globalization;
using System.Threading;
using DevExpress.Utils.Drawing.Animation;
using DevExpress.XtraEditors;
using DevExpress.LookAndFeel;
namespace CallsManagement
{
    internal static class Program
    {
       static UserConfig userConfig = GetUserConfig();
       static EventAggregator EventAggregator = EventAggregator.GetEventAggregator();
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var userConfig = GetUserConfig();

            CultureInfo culture = new CultureInfo(userConfig.Language);
            Thread.CurrentThread.CurrentCulture = culture;
            Thread.CurrentThread.CurrentUICulture = culture;
            
            if(userConfig.Language == "el") DevExpress.XtraEditors.Controls.Localizer.Active = new CustomLocalizer();

            SetThemeAndPallete();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (userConfig.ConnectionString != "")
            {
                var areWeOk = false;
                var connectionString = "";


                try
                {
                    using (SqlConnection connection = new SqlConnection(
                       userConfig.ConnectionString))
                    {

                        connection.Open();

                    }
                }
                catch (Exception)
                {
                    XtraMessageBox.Show(Localization.ConnectionError_Msg);

                    do
                    {
                        connectionString = GetConnectionString();

                        areWeOk = isConStrOk(connectionString);

                    } while (!areWeOk);

                    userConfig.ConnectionString = connectionString;
                }

                XpoDefault.DataLayer = XpoDefault.GetDataLayer(userConfig.ConnectionString, AutoCreateOption.SchemaAlreadyExists);
                XpoDefault.Session = null;

                Application.Run(new MainForm(userConfig));
            }
            else
            {
                var areWeOk = false;
                var connectionString = "";

                do
                {
                    connectionString = GetConnectionString();

                    areWeOk = isConStrOk(connectionString);

                } while (!areWeOk);

                userConfig.ConnectionString = connectionString;

                XpoDefault.DataLayer = XpoDefault.GetDataLayer(userConfig.ConnectionString, AutoCreateOption.SchemaAlreadyExists);
                XpoDefault.Session = null;

                Application.Run(new MainForm(userConfig));
            }
        }

        private static UserConfig GetUserConfig()
        {
            var filePath = Path.Combine(Environment.GetFolderPath(
            Environment.SpecialFolder.LocalApplicationData), "CallsManagement\\UserConfig.xml");

            XmlSerializer serializer = new XmlSerializer(typeof(UserConfig));

            var userConfig = new UserConfig();  


            using (Stream reader = new FileStream(filePath, FileMode.Open))
            {
                userConfig = (UserConfig)serializer.Deserialize(reader);
            }

            return userConfig;
        }

        private static string GetConnectionString()
        {
            DataConnectionDialog dcd = new DataConnectionDialog();
            DataSource.AddStandardDataSources(dcd);
            dcd.SelectedDataSource = DataSource.SqlDataSource;
            dcd.SelectedDataProvider = DataProvider.SqlDataProvider;
            DataConnectionDialog.Show(dcd);

            if (dcd.DialogResult.Equals(DialogResult.Cancel)) Environment.Exit(0);
            return dcd.ConnectionString;
        }


        private static bool isConStrOk(string connectionString)
        {            
            try
            {
                if (connectionString.Contains("Data Source=") && connectionString.Contains("Initial Catalog=")
                             && connectionString.Contains("User ID=") && connectionString.Contains("Password="))
                {
                    using (SqlConnection connection = new SqlConnection(
                           connectionString))
                    {

                        connection.Open();

                    }

                    return true;
                }
                else
                {
                    XtraMessageBox.Show(Localization.WrongServerCredentials_Msg);
                }
                    
            }
            catch (Exception)
            {
                XtraMessageBox.Show(Localization.ConnectionError_Msg);
            }

            return false;
        }


        private static void SetThemeAndPallete()
        {
            if (userConfig.Theme == "WXI")
            {
                UserLookAndFeel.Default.SetSkinStyle(SkinStyle.WXI);

                UserLookAndFeel.Default.SetSkinStyle(SkinSvgPalette.WXI.PaletteSet[userConfig.Pallete]);
            }
            else if (userConfig.Theme == "WXI Compact")
            {
                UserLookAndFeel.Default.SetSkinStyle(SkinStyle.WXICompact);

                UserLookAndFeel.Default.SetSkinStyle(SkinSvgPalette.WXICompact.PaletteSet[userConfig.Pallete]);
            }
            else
            {
                UserLookAndFeel.Default.SetSkinStyle(SkinSvgPalette.WXICompact.Default);
            }
        }

        public static UserConfig GetConfigs()
        {
            return new UserConfig()
            {
                ConnectionString = userConfig.ConnectionString,
                Language = userConfig.Language,
                Theme = userConfig.Theme
            };
        }

        public static EventAggregator GetEventAggregator()
        {
            return EventAggregator;
        }
    }
}
