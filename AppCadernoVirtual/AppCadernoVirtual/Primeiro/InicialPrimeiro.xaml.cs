using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppCadernoVirtual.Primeiro
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class InicialPrimeiro : ContentPage
    {
        public InicialPrimeiro()
        {
            InitializeComponent();
        }

        private void BtnPortugues_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PortuguesPrimeiro());
        }

        private void BtnIngles_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new InglesPrimerio());
        }

        private void BtnGeografia_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new GeografiaPrimeiro());
        }

        private void BtnHistoria_Clicked(object sender, EventArgs e)
        {

        }

        private void BtnFisica_Clicked(object sender, EventArgs e)
        {

        }

        private void BtnQuimica_Clicked(object sender, EventArgs e)
        {

        }

        private void BtnBiologia_Clicked(object sender, EventArgs e)
        {

        }

        private void BtnFilosofia_Clicked(object sender, EventArgs e)
        {

        }

        private void BtnEducacaoFisica_Clicked(object sender, EventArgs e)
        {

        }

        private void BtnArtes_Clicked(object sender, EventArgs e)
        {

        }

        private void BtnProgramacaoWeb_Clicked(object sender, EventArgs e)
        {

        }

        private void BtnAnalise_Clicked(object sender, EventArgs e)
        {

        }

        private void BtnDesignDigital_Clicked(object sender, EventArgs e)
        {

        }

        private void BtnFundamentosInformatica_Clicked(object sender, EventArgs e)
        {

        }

        private void BtnAlgoritmos_Clicked(object sender, EventArgs e)
        {

        }

        private void BtnBancoDeDados_Clicked(object sender, EventArgs e)
        {

        }
    }
}