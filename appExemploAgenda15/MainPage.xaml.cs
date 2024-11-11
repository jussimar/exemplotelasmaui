using appExemploAgenda15.Models;
using appExemploAgenda15.Views;

namespace appExemploAgenda15
{
    public partial class MainPage : ContentPage
    {
        

        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnCounterClicked(object sender, EventArgs e)
        {
            Pessoa p = new Pessoa();
            /*p.Nome = "Jussimar";
            p.AnoNascimento = 1989;*/

            p.Nome = nome.Text;
            /*p.AnoNascimento = int.Parse(idadecampo.Text);*/
            p.DataNascimento = dtNascimento.Date; 

            await Navigation.PushAsync(new NewPage1()
            {
                BindingContext = p
            });
        }
    }

}
