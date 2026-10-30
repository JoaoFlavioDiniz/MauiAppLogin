namespace MauiAppMeuCombustivel
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }
        // Alterado de 'private void' para 'private async void'
        private async void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            try
            {
                double etanol = Convert.ToDouble(txt_etanol.Text);
                double gasolina = Convert.ToDouble(txt_gasolina.Text);
               
                string msg = "";

                if (etanol <= (gasolina * 0.7))
                {
                    msg = "O etanol está compensando.";
                }
                else
                {
                    msg = "A gasolina está compensando.";
                }
                // Adicionado o 'await' e o Async no DisplayAlert
                await DisplayAlertAsync("Calculado", msg, "OK");

            }
            catch (Exception ex)
            {
                // Adicionado o 'await'
                await DisplayAlertAsync("Ops", ex.Message, "Fechar");
            }

        } // Fecha método
    } //Fecha Class
} // Fecha namespace