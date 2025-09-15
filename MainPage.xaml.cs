namespace AprendeNetMAUI
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

            try
            {
                double etanol = Convert.ToDouble(txt_etanol.Text);
                double gasolina = Convert.ToDouble(txt_gasolina.Text);

                string msg = "";

                if (etanol <= (gasolina * 0.7))
                {
                    msg = "Abasteça com Etanol!";
                }
                else
                {
                    msg = "Abasteça com Gasolina!";
                }
              
                DisplayAlert("Resultado", msg, "Fechar");
            }
            catch (Exception ex)
            {
                DisplayAlert("Ops! Ocorreu um erro!", ex.Message, "Fechar");
                throw;
            }

        }
    }

}
