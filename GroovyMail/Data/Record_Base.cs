using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.Generic;
using System.ComponentModel;

namespace GroovyMail.Data
{
    internal partial class Record_Base : ObservableObject
    {
        ///////////////////////////////////////////////////////////
        #region ObservableProperty helper

        /// <summary>
        /// This is here because the ID property is a special case.
        /// 
        /// CommunityToolkit.Mvvm already does this for fields annotated as ObservableProperty.
        /// However, the pattern of annotating a field declaration to create a corresponding
        /// observable property in the generated code prevents the sqlite-net-pcl annotations 
        /// from being applied. The annotations cannot be applied to a field, only a property, 
        /// and the property only exists in the generated file.
        /// 
        /// Therefore ID cannot be declared by using the ObservableProperty annotation; it must 
        /// be made observable independently from the Toolkit mechanism. All other observable 
        /// properties in classes derived from Record_Base can use the simpler Toolkit pattern.
        /// ID, inherited from this base class, is the only special case.
        /// 
        /// </summary>
        protected void SetField<TField>(ref TField field, TField value, string propertyName)
        {
            if (EqualityComparer<TField>.Default.Equals(field, value))
            {
                return;
            }

            field = value;
            OnPropertyChanged(propertyName);
        }

        #endregion ObservableProperty helper
        ///////////////////////////////////////////////////////////


        ///////////////////////////////////////////////////////////
        #region Fields

        private int _ID = -1;

        #endregion Fields
        ///////////////////////////////////////////////////////////



        ///////////////////////////////////////////////////////////
        #region Properties

        [SQLite.PrimaryKey, SQLite.AutoIncrement]
        public int ID
        {
            get => _ID;
            set => SetField(ref _ID, value, nameof(ID));
        }

        #endregion Properties
        ///////////////////////////////////////////////////////////
    }
}
