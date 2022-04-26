using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppCadernoVirtual.Terceiro
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class InicialTerceiro : ContentPage
    {
        public InicialTerceiro()
        {
            InitializeComponent();
        }

        private void BtnPortugues_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PortuguesTerceiro());
        }

        private void BtnIngles_Clicked(object sender, EventArgs e)
        {

        }

        private void BtnGeografia_Clicked(object sender, EventArgs e)
        {

        }

        private void BtnBiologia_Clicked(object sender, EventArgs e)
        {

        }

        private void BtnQuimica_Clicked(object sender, EventArgs e)
        {

        }

        private void BtnFilosofia_Clicked(object sender, EventArgs e)
        {

        }

        private void BtnSociologia_Clicked(object sender, EventArgs e)
        {

        }

        private void BtnHistoria_Clicked(object sender, EventArgs e)
        {

        }

        private void BtnFisica_Clicked(object sender, EventArgs e)
        {

        }

        private void BtnEducacaoFisica_Clicked(object sender, EventArgs e)
        {

        }

        private void BtnProgWeb_Clicked(object sender, EventArgs e)
        {

        }

        private void BtnProgMobile_Clicked(object sender, EventArgs e)
        {

        }

        private void BtnInternet_Clicked(object sender, EventArgs e)
        {

        }

        private void BtnTCC_Clicked(object sender, EventArgs e)
        {

        }

        private void BtnQualidade_Clicked(object sender, EventArgs e)
        {

        }
    }
}