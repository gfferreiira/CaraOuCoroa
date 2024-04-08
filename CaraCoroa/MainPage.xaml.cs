namespace CaraCoroa
{
    public partial class MainPage : ContentPage
    {
        int escolhaResultado = 0;
        
      
        string escolha = "";

        public MainPage()
        {
            InitializeComponent();
        }

         private void BtnSpin_Clicked(object sender, EventArgs e)
        {
            // Armazena a escolha do picker e define o random para sortear o número
            escolha = SidesPicker.SelectedItem.ToString();
            
            int valorSorteado = new Random().Next(0, 2);

            //Compara oque o usuario escolhe com o número sorteado
            if (escolha == "Cara")
            {
                escolhaResultado = 0;
            }
            else
            {
                escolhaResultado = 1;
            }
            
          
          //Exibe a mensagem de resultado do sorteio

            if (escolhaResultado == valorSorteado)
            {
                ResultLabel.Text = $"Deu {escolha}, voce ganhou";
            }
            else
            {
                ResultLabel.Text = $"Não Deu {escolha}, você perdeu.";
            }

            switch (valorSorteado)
            {
                case 0: 
                    CoinImage.Source = "cara.jpg";
                    break;
                case 1: CoinImage.Source = "coroa.jpg";
                    break;
            }


        }



    }
    }


