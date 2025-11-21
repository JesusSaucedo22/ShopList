
namespace ShopList.Gui;

public partial class ShopListPage : ContentPage
{
	public ShopListPage()
	{
		InitializeComponent();
		BindingContext = new ShopListViewModel();
	}

    private void InitializeComponent()
    {
        throw new NotImplementedException();
    }
}