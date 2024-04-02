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
            string valor = "";

            //Pegar o valor que foi selecionado pelo usuario no picker
            valor = Convert.ToString(SidesPicker.SelectedItem);
            //Jogar esse valor em uma variavel
            // sortear um numero em um dado utilizando o Random
            // Colocar o valor de uma varíavel 
            // Exibir o valor para o usuário na SpinCountLabel
            int valorSorteado = 0;
            valorSorteado = new Random().Next(0, 2);
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
