namespace MauiAppHotel.Views;

public partial class ContratacaoHospedagem : ContentPage
{
    public ContratacaoHospedagem()
    {
        InitializeComponent();
    }

    // método para lidar com o clique do botão "Sobre"
    private async void OnSobreClicked(object sender, EventArgs e)
    {
        // Navega para a página Sobre
        await Navigation.PushAsync(new Sobre());
    }
}