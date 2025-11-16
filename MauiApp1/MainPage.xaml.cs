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
                // Leitura dos dados de Marca e Modelo
                string marca = txt_marca.Text;
                string modelo = txt_modelo.Text;

                // Leitura dos preços dos combustíveis
                double etanol = Convert.ToDouble(txt_etanol.Text);
                double gasolina = Convert.ToDouble(txt_gasolina.Text);

                string msg = "";

                // Verifica se Marca e Modelo foram preenchidos
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

                // Lógica de cálculo (regra 70%)
                if (etanol <= (gasolina * 0.7))
                {
                    // Mensagem incluindo a informação do veículo
                    msg = $"O etanol está compensando{veiculoInfo}.";
                }
                else
                {
                    // Mensagem incluindo a informação do veículo
                    msg = $"A gasolina está compensando{veiculoInfo}.";
                }

                DisplayAlert("Cálculo de Combustível", msg, "Ok");
            }
            catch (Exception ex)
            {
                // Trata erros de conversão (se o usuário não digitar um número)
                DisplayAlert("Ops", "Por favor, insira valores numéricos válidos para os preços do combustível. " + ex.Message, "Fechar");
            }
        }
    }

}