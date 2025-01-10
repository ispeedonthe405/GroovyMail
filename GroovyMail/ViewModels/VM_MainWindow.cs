using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace GroovyMail.ViewModels
{
    public partial class VM_MainWindow : ViewModelBase
    {
        ///////////////////////////////////////////////////////////
        #region Fields


        #endregion Fields
        ///////////////////////////////////////////////////////////



        ///////////////////////////////////////////////////////////
        #region Properties

        [ObservableProperty]
        private bool splitview_open = true;

        #endregion Properties
        ///////////////////////////////////////////////////////////



        ///////////////////////////////////////////////////////////
        #region Commands

        [RelayCommand]
        public void ToggleSplitview()
        {
            Splitview_open = !Splitview_open;
        }

        #endregion Commands
        ///////////////////////////////////////////////////////////
    }
}
