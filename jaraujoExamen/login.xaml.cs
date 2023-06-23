using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace jaraujoExamen
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class login : ContentPage
    {
        public login()
        {
            InitializeComponent();
        }

        private void btnIniciar_Clicked_1(object sender, EventArgs e)
        {
            String usuario = "estudiante2023";
            String contraseña = "uisrael2023";
            if (txtUsuario.Text == usuario && txtContraseña.Text == contraseña)
            {
                Navigation.PushAsync(new registro(usuario));
            }
            else
            {
                DisplayAlert("ERROR", " usuario y contaseña incorrectos ", " cerrar ");
            }

        }
    }
}