using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EmpleadoProyecto.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageListEmple : ContentPage
    {
        private object emple;

        public PageListEmple()
        {
            InitializeComponent();
        }

        private void listEmple_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            var secondpage = new PageListEmple();
            secondpage.BindingContext = emple;
            Navigation.PushAsync(secondpage);


        }
    }


}



