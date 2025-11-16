namespace MauiApp1
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
               
                string marca = txt_marca.Text;
                string modelo = txt_modelo.Text;

                double etanol = Convert.ToDouble(txt_etanol.Text);
                double gasolina = Convert.ToDouble(txt_gasolina.Text);

                string msg = "";

                string veiculoInfo = "";
                if (!string.IsNullOrWhiteSpace(marca) && !string.IsNullOrWhiteSpace(modelo))
                {
                    veiculoInfo = $" para o seu **{marca} {modelo}**";
                }
                else if (!string.IsNullOrWhiteSpace(marca))
                {
                    veiculoInfo = $" para o seu **{marca}**";
                }
                else if (!string.IsNullOrWhiteSpace(modelo))
                {
                    veiculoInfo = $" para o seu **{modelo}**";
                }

                if (etanol <= (gasolina * 0.7))
                {
                    
                    msg = $"O etanol está compensando{veiculoInfo}.";
                }
                else
                {
                    
                    msg = $"A gasolina está compensando{veiculoInfo}.";
                }

                DisplayAlert("Cálculo de Combustível", msg, "Ok");
            }
            catch (Exception ex)
            {
                
                DisplayAlert("Ops", "Por favor, insira valores numéricos válidos para os preços do combustível. " + ex.Message, "Fechar");
            }
        }
    }

}