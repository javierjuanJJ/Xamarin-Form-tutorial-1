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

        private void Button_OnClicked(object sender, EventArgs e)
        {
            var boxNameText = boxName.Text;
            if (!string.IsNullOrEmpty(boxNameText))
            {
                
            }
        }
    }
}