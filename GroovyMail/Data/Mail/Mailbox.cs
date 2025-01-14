using CommunityToolkit.Mvvm.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace GroovyMail.Data.Mail
{
    internal partial class Mailbox : Record_Base
    {
        ///////////////////////////////////////////////////////////
        #region Properties (DB)

        [ObservableProperty, Required]
        public string name = string.Empty;

        [ObservableProperty, Required]
        public int accountID;

        #endregion Properties (DB)
        ///////////////////////////////////////////////////////////
        
    }
}
