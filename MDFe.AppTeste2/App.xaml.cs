using System.Windows;
using DryIoc;
using MDFe.AppTeste2.ViewModels;

namespace MDFe.AppTeste2
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            var container = new Container();

            container.Register<MainWindow>();
            container.Register<MainWindowViewModel>();

            var janelaPrincipal = container.Resolve<MainWindow>();
            janelaPrincipal.Show();
        }
    }
}
