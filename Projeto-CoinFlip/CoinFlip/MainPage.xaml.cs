namespace CoinFlip
{
    public partial class MainPage : ContentPage
    {
        string aposta = "";
        
        public MainPage()
        {
            InitializeComponent();
        }

        private void Mudar_Selecionador(object sender, EventArgs e)
        {
            int indice = Selecionador.SelectedIndex;
            if(indice == 0)
            {
                aposta = "coroa";
            }
            else
            {
                aposta = "cara";
            }
        }

        private void Botao_Clicado(object sender, EventArgs e)
        {
            
            Random aleatorio = new();
            int numeroGerado = aleatorio.Next(1, 3);
            if(numeroGerado == 1)
            {
                ImagemMoeda.Source = "cara.jpg";
                if(aposta == "cara")
                {
                    Resultado.Text = "Parabéns, venceu!";
                }
                else
                {
                    Resultado.Text = "Que Pena, perdeu!";
                }
            }
            else
            {
                ImagemMoeda.Source = "coroa.jpg";
                if (aposta == "coroa")
                {
                    Resultado.Text = "Parabéns, venceu!";
                }
                else
                {
                    Resultado.Text = "Que Pena, perdeu!";
                }
            }
        }
    }

}
