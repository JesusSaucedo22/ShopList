using CommunityToolkit.Mvvm.ComponentModel;
using ShopList.Gui.Models;
using System.Collections.ObjectModel;
using System.ComponentModel;


namespace ShopList.Gui.ViewsModels
{
    public class ShopListViewModel : ObservableObject
    {
        [ObservableProperty]
        private string _nombreDelArticulo = string.Empty;
        [ObservableProperty]
        private int _cantidadACompra = 1;

        //public event PropertyChangedEventHandler? PropertyChanged;

        public ObservableCollection<Item> Items { get; }

        

        /*public void AgregarShopListItem()
        {
            if(string.IsNullOrEmpty(_nombreDelArticulo) || CantidadAComprar <= 0)
           {
                return;
            }
            Random generador = new Random();
            var item = new Item
            {
                Id = generador.Next(),
                Nombre = NombreDelArticulo,
               Cantidad = CantidadAComprar,
                Comprado = false,
        /*    };
            Items.Add(item);
            NombreDelArticulo = string.Empty;
            CantidadAComprar = 1;
        }*/

        public void EliminarShopListItem()
        {

        }

        private void CargarDatos()
        {

            Items.Add(new Item()
            {
                Id = 1,
                Nombre = "Leche",
                Cantidad = 2,
                Comprado = false,
            });
            Items.Add(new Item()
            {
                Id = 2,
                Nombre = "Leche",
                Cantidad = 2,
                Comprado = false,
            });
            Items.Add(new Item()
            {
                Id = 3,
                Nombre = "Leche",
                Cantidad = 2,
                Comprado = false,
            });

        }

        //private void OnPropertyChanged(string propertyName)
       // {
       //     PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
       // }


    }

}

