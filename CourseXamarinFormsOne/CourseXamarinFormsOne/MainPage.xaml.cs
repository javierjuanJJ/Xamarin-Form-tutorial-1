using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CourseXamarinFormsOne
{

    public class Elemento
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
    }
    
    
    public class ListaElementos
    {
        public List<Elemento> listaElementos { get; set; }

        public ListaElementos()
        {
            listaElementos = new List<Elemento>();
            loadElements();
        }

        private void loadElements()
        {
            listaElementos.Add(new Elemento()
            {
                Nombre = "",
                Descripcion = ""
            });
            
            listaElementos.Add(new Elemento()
            {
                Nombre = "",
                Descripcion = ""
            });
        }
    }
    
    public partial class MainPage : ContentPage
    {

       
        
        public MainPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            ListaElementos listaElementos = new ListaElementos();
            ListaElementos.ItemsSource = listaElementos.listaElementos;
            ListaElementos.ItemSelected += List_ElemtsOnSelected;
        }

        private async void List_ElemtsOnSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                Elemento eSelectedItem = e.SelectedItem as Elemento;
                await DisplayAlert("Xamarin", eSelectedItem.Nombre, "Aceptar");
                
            }
        }
    }
}