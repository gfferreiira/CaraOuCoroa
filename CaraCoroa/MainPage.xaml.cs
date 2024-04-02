namespace CaraCoroa
{
    public partial class MainPage : ContentPage
    {
     

        public MainPage()
        {
            InitializeComponent();
        }

         private void BtnSpin_Clicked(object sender, EventArgs e)
        {
            int valor = 0;

            //Pegar o valor que foi selecionado pelo usuario no picker
            valor = Convert.ToInt32(SidesPicker.SelectedItem);
            //Jogar esse valor em uma variavel
            // sortear um numero em um dado utilizando o Random
            // Colocar o valor de uma varíavel 
            // Exibir o valor para o usuário na SpinCountLabel
            int valorSorteado = 0;
            valorSorteado = new Random().Next(1, valor);
            if (valorSorteado == 0)
            {
                ResultLabel.Text = "Cara";
            }
            else
            {

                ResultLabel.Text = "Coroa";


            }

            
           
        }
    }

}
