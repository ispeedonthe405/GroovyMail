using Microsoft.UI.Xaml;


namespace GroovyMail.ux
{
    public sealed partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.InitializeComponent();
            PaneHeader.cbxMailbox.SelectionChanged += CbxMailbox_SelectionChanged;
        }

        private void CbxMailbox_SelectionChanged(object sender, Microsoft.UI.Xaml.Controls.SelectionChangedEventArgs e)
        {
            NavMain.MenuItems.Clear();
            NavMain.MenuItems.Add(new Microsoft.UI.Xaml.Controls.NavigationViewItem() { Content = $"Inbox{PaneHeader.cbxMailbox.SelectedIndex}" });
        }

        private void NavMain_SelectionChanged(
            Microsoft.UI.Xaml.Controls.NavigationView sender, 
            Microsoft.UI.Xaml.Controls.NavigationViewSelectionChangedEventArgs args)
        {

        }
    }
}
