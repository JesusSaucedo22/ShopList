using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using ShopList.Gui.Models;


public class ShopListViewModel
{
    public ObservableCollection<Item> Items { get; set; }

    public ShopListViewModel()
    {
        Items = new ObservableCollection<Item>();
        CargarDatos();
    }
    private void CargarDatos()
    {

        Items.Add(new Item()
        {
            Id = 0,
            Nombre = "Leche",
            Cantidad = 2,
        });
        Items.Add(new Item()
        {
            Id = 0,
            Nombre = "Leche",
            Cantidad = 2,
        });
        Items.Add(new Item()
        {
            Id = 0,
            Nombre = "Leche",
            Cantidad = 2,
        });

    }
}

