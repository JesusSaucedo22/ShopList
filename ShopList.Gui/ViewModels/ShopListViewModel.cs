using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ShopList.Gui.Models;
using System.Collections.ObjectModel;
using System.ComponentModel;



namespace ShopList.Gui.ViewsModels
{
    public partial class ShopListViewModel : ObservableObject
    {
        [ObservableProperty]
        private string _nombreDelArticulo = string.Empty;
        [ObservableProperty]
        private int _cantidadAComprar = 1;


        public ObservableCollection<Item> Items { get; }

        public ShopListViewModel()
        {
            Items = new ObservableCollection<Item>();
            CargarDatos();

        }


        [RelayCommand]
        public void AgregarShopListItem()
        {
            if (string.IsNullOrEmpty(NombreDelArticulo) || CantidadAComprar <= 0)
            {
                return;
            }

            Random generador = new Random();
            var item = new Item
            {
                Id = generador.Next(),
                Nombre = NombreDelArticulo,
                Cantidad = this.CantidadAComprar,
                Comprado = false,
            };
            Items.Add(item);
            NombreDelArticulo = string.Empty;
            CantidadAComprar = 1;
        }
        [RelayCommand]
        public void EliminarShopListItem(Item item)
        {
            if (item != null)
            {
                Items.Remove(item);
            }
        }

        [RelayCommand]
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


    }

}