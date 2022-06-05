using System.Windows;

namespace WpfApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            Bootstrapper.StartUp();
            base.OnStartup(e);
        }

        private void Application_DispatcherUnhandledException(object sender, System.Windows.Threading.DispatcherUnhandledExceptionEventArgs e)
        {
            MessageBox.Show("Exception: " + e.Exception.Message, "Exception", MessageBoxButton.OK, MessageBoxImage.Error);
            e.Handled = true;
        }
    }
}
