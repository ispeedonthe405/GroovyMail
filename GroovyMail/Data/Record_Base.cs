using CommunityToolkit.Mvvm.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace GroovyMail.Data
{
    internal partial class Record_Base : ObservableValidator
    {
        ///////////////////////////////////////////////////////////
        #region Properties

        [ObservableProperty, Key]
        public int iD;


        #endregion Properties
        ///////////////////////////////////////////////////////////
    }
}
