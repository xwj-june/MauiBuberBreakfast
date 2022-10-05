using MauiBuberBreakfast.ViewModels;

namespace MauiBuberBreakfast;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
		BindingContext = new MyBraekfastsViewModel();
	}
}

