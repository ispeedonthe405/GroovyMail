using System.Collections.Generic;
using System.ComponentModel;

namespace GroovyMail.core
{
    internal class EmailAccount : INotifyPropertyChanged
    {
        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void SetField<TField>(ref TField field, TField value, string propertyName)
        {
            if (EqualityComparer<TField>.Default.Equals(field, value))
            {
                return;
            }

            field = value;
            OnPropertyChanged(propertyName);
        }
        #endregion INotifyPropertyChanged


        #region FIELDS
        private string _DisplayName = string.Empty;
        private string _Email = string.Empty;
        private string _Password = string.Empty;
        private string _Host_Out = string.Empty;
        private int _Port_Out = 0;
        private bool _SSL_Out = false;
        private bool _TLS_Out = false;
        private string _Host_In = string.Empty;
        private int _Port_In = 0;
        private bool _SSL_In = false;
        private bool _TLS_In = false;
        #endregion FIELDS


        #region PROPERTIES
        public string DisplayName
        {
            get => _DisplayName;
            set => SetField(ref _DisplayName, value, nameof(DisplayName));
        }
        public string Email
        {
            get => _Email;
            set => SetField(ref _Email, value, nameof(Email));
        }
        public string Password
        {
            get => _Password;
            set => SetField(ref _Password, value, nameof(Password));
        }
        public string Host_Out
        {
            get => _Host_Out;
            set => SetField(ref _Host_Out, value, nameof(Host_Out));
        }
        public int Port_Out
        {
            get => _Port_Out;
            set => SetField(ref _Port_Out, value, nameof(Port_Out));
        }
        public bool SSL_Out
        {
            get => _SSL_Out;
            set => SetField(ref _SSL_Out, value, nameof(SSL_Out));
        }
        public bool TLS_Out
        {
            get => _TLS_Out;
            set => SetField(ref _TLS_Out, value, nameof(TLS_Out));
        }
        public string Host_In
        {
            get => _Host_In;
            set => SetField(ref _Host_In, value, nameof(Host_In));
        }
        public int Port_In
        {
            get => _Port_In;
            set => SetField(ref _Port_In, value, nameof(Port_In));
        }
        public bool SSL_In
        {
            get => _SSL_In;
            set => SetField(ref _SSL_In, value, nameof(SSL_In));
        }
        public bool TLS_In
        {
            get => _TLS_In;
            set => SetField(ref _TLS_In, value, nameof(TLS_In));
        }
        #endregion PROPERTIES
    }
}
