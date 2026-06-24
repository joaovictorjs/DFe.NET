using System.Windows;
using DryIoc;

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

            var janelaPrincipal = container.Resolve<MainWindow>();
            janelaPrincipal.Show();
        }
    }
}
