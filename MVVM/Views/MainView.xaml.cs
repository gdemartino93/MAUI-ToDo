using MAUI_ToDo.MVVM.ViewModels;

namespace MAUI_ToDo.MVVM.Views;

public partial class MainView : ContentPage
{
	public MainView()
	{
		InitializeComponent();
		BindingContext = new MainViewModel();
	}
}