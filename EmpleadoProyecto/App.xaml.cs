using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EmpleadoProyecto
{
    public partial class App : Application
    {
        
        public App()
        {
            InitializeComponent();

            MainPage = new  NavigationPage(new Empleado.EmpleadoPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
