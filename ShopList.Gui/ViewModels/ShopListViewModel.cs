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
        private int _cantidadAComprar;
        [ObservableProperty]
        private Item? _origenSeleccionado = null;

        public ObservableCollection<Item> Items { get; }

        public ShopListViewModel()
        {
            Items = new ObservableCollection<Item>();
            CargarDatos();

            if (Items.Count > 0)
            {
                OrigenSeleccionado = Items[0];
            }
            else
            {
                OrigenSeleccionado = null;
            }

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
        public void EliminarShopListItem()
        {
            if (OrigenSeleccionado == null)
            {
                return;
            }
            Item? nuevoSeleccionado;
            int indice = Items.IndexOf(OrigenSeleccionado);
            if (indice < Items.Count - 1)
            {
                nuevoSeleccionado = Items[indice + 1];
            }
            else
            {
                if (Items.Count > 1)
                {
                    nuevoSeleccionado = Items[Items.Count - 2];
                }
                else
                {
                    nuevoSeleccionado = null;
                }
            }
            Items.Remove(OrigenSeleccionado);
            OrigenSeleccionado = nuevoSeleccionado;
        }

        [RelayCommand]
        private void CargarDatos()
        {

            Items.Add(new Item()
            {
                Id = 1,
                Nombre = "Leche",
                Cantidad = 3,
                Comprado = false,
            });
            Items.Add(new Item()
            {
                Id = 2,
                Nombre = "Carne",
                Cantidad = 2,
                Comprado = false,
            });
            Items.Add(new Item()
            {
                Id = 3,
                Nombre = "Queso",
                Cantidad = 5,
                Comprado = false,
            });
        }
    }
 }

