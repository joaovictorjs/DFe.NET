using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace MDFe.AppTeste2.ViewModels
{
    public partial class MainWindowViewModel : ObservableObject
    {
        [ObservableProperty]
        private bool _configuracoesAberta;

        [RelayCommand]
        private void AbrirConfiguracoes() => ConfiguracoesAberta = true;
    }
}
