using System;
using DevExpress.XtraEditors.Controls;

public class CustomLocalizer : Localizer
{
    public override string GetLocalizedString(StringId id)
    {
        switch (id)
        {
            case StringId.XtraMessageBoxYesButtonText:
                return "Ναι";
            case StringId.XtraMessageBoxCancelButtonText:
                return "Άκυρο";
            case StringId.XtraMessageBoxNoButtonText:
                return "Όχι";
            default:
                return base.GetLocalizedString(id);
        }
    }
}
