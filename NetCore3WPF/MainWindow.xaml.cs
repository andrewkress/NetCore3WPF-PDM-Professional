using System.Windows;
using EPDM.Interop.epdm;

namespace NetCore3WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private IEdmVault5 vault;
        public MainWindow() {
            InitializeComponent();
            vault = new EdmVault5();
        }

        private void ButtonExit_Click(object sender, RoutedEventArgs e) {
            Application.Current.Shutdown();
        }

        private void ButtonLogin_Click(object sender, RoutedEventArgs e) {
            if(!vault.IsLoggedIn) {
                vault.LoginAuto("training", 0);
                MessageBox.Show($"Logged in to vault: {vault.Name} with a root of {vault.RootFolderPath}");
            }
        }
    }
}
