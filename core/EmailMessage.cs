using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroovyMail.core
{
    internal class EmailMessage : INotifyPropertyChanged
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
        #endregion FIELDS

        #region PROPERTIES
        #endregion PROPERTIES
    }
}
