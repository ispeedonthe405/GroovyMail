using CommunityToolkit.Mvvm.ComponentModel;

namespace GroovyMail.Data.Mail
{
    internal partial class EmailAddress : Record_Base
    {
        ///////////////////////////////////////////////////////////
        #region Properties

        [ObservableProperty]
        public string name = string.Empty;

        [ObservableProperty]
        public string address = string.Empty;

        public string DisplayString
        {
            get => $"{Name}({Address})";
        }

        #endregion Properties
        ///////////////////////////////////////////////////////////


        public override string ToString()
        {
            return DisplayString;
        }
    }
}
