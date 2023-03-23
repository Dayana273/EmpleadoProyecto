using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmpleadoProyecto.Views;
using SQLite;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace EmpleadoProyecto.Empleado
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EmpleadoPage : ContentPage
    {
        private object emple;

        public EmpleadoPage()
        {
            InitializeComponent();
        }

        private void btAgregar_Clicked(object sender, EventArgs e)
        {

            {
                if (txtNombre == null)
                {
                    DisplayAlert("Error", "Ingresa el nombre", "ok");
                }
                else if (string.IsNullOrEmpty(txtNombre.Text))
                {
                    DisplayAlert("Error", "Error  no has ingresado el nombre", "ok");

                }

                else if (string.IsNullOrEmpty(txtApellidos.Text))
                {
                    DisplayAlert("Error", "Error Ingresa los apellidos", "ok");
                }

                else if (string.IsNullOrEmpty(txtEdad.Text))
                {
                    DisplayAlert("Error", "Error no has ingresado la edad", "ok");
                }

                else if (string.IsNullOrEmpty(txtGenero.Text))
                {
                    DisplayAlert("Error", "Error no has ingresado el genero", "ok");
                }


                else if (string.IsNullOrEmpty(txtDireccion.Text))
                {
                    DisplayAlert("Error", "Error no has ingresado la direccion", "ok");
                }
                else if (string.IsNullOrEmpty(txtTelefono.Text))
                {
                    DisplayAlert("Error", "Error no has ingresado el telefono", "ok");
                }

               
            }


        }



        


        private  async void btnVer_Clicked(object sender, EventArgs e)
        {


            var page = new Views.PageListEmple();
            page.BindingContext = emple;
            await  Navigation.PushAsync(page);


          

        }
    }
}
    
