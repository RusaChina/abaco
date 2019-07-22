using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Abaco.Models;
using Abaco.Repository;

namespace Abaco.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class RegistrarPage : ContentPage
	{
		public RegistrarPage ()
		{
			InitializeComponent ();
		}

        private void BtnRegistrar_Clicked(object sender, EventArgs e)
        {
            UsuarioRepositorio.Instancia.AddNewUsuario(textNombre.Text, textApellido.Text, textZona.Text, textNumero.Text, 
                textPassword.Text, textCorreo.Text);


        }
    }
}