using AppliedActivity5.ViewModels;

namespace AppliedActivity5;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();

		BindingContext = new MainViewModel();
	}
}


