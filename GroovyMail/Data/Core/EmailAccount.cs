using CommunityToolkit.Mvvm.ComponentModel;
using sbdotnet;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace GroovyMail.Data.Core
{
    internal partial class EmailAccount : Record_Base
    {
        ///////////////////////////////////////////////////////////
        #region Properties

        [ObservableProperty]
        public string name = string.Empty;

        [ObservableProperty]
        public string mailboxes = string.Empty;

        [SQLite.Ignore]
        public ObservableCollection<string> MailboxNames { get; private set; } = [];

        #endregion Properties
        ///////////////////////////////////////////////////////////
        

        public EmailAccount()
        {
            PropertyChanged += EmailAccount_PropertyChanged;
        }

        private void EmailAccount_PropertyChanged(object? sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName is not null)
            {
                if (e.PropertyName.Equals(nameof(Mailboxes)))
                {
                    try
                    {
                        MailboxNames.Clear();
                        MailboxNames.AddRange(Mailboxes.Split(',').ToList());
                    }
                    catch (Exception ex)
                    {
                        Logger.Error(ex);
                    }
                }
            }
        }
    }
}
