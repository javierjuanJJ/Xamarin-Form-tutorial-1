using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CourseXamarinFormsOne
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
           
        }

        private void BtnSave_OnClicked(object sender, EventArgs e)
        {
            string nameText = name.Text;
            if (!string.IsNullOrEmpty(nameText))
            {
                DisplayAlert("Xamarin forms", nameText, "Aceptar");
            }
        }
    }
}