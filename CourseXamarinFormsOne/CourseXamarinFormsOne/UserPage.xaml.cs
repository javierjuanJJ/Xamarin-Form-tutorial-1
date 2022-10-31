using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CourseXamarinFormsOne
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UserPage : ContentPage
    {
        public UserPage(Intent intent)
        {
            InitializeComponent();
            BindingContext = intent;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            
        }
    }
}