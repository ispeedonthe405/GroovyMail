using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GroovyMail.Data.Mail
{
    internal partial class EmailAccount : Record_Base
    {
        ///////////////////////////////////////////////////////////
        #region Properties (DB)

        [ObservableProperty, Required]
        public string accountName = string.Empty;

        [ObservableProperty, Required]
        public string emailAddress = string.Empty;

        [ObservableProperty, Required]
        public string userName = string.Empty;

        #endregion Properties (DB)
        ///////////////////////////////////////////////////////////


        ///////////////////////////////////////////////////////////
        #region Properties (unmapped)

        [ObservableProperty, NotMapped]
        public ObservableCollection<Mailbox> mailboxes = [];

        #endregion Properties (unmapped)
        ///////////////////////////////////////////////////////////

        public EmailAccount()
        {

        }
    }
}
