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

        private int counter;
        
        public MainPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            btnSum.Clicked += sumNumber;
        }

        private void sumNumber(object sender, EventArgs e)
        {
            btnSum.Text = counter++.ToString();
        }
    }
}