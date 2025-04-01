using MAUI_ToDo.MVVM.ViewModels;

namespace MAUI_ToDo.MVVM.Views;

public partial class MainView : ContentPage
{
	private MainViewModel _mainViewModel = new MainViewModel();
	public MainView()
	{
		InitializeComponent();
		BindingContext = _mainViewModel;
	}

    private void checkBoxIsCompleted_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
		_mainViewModel.UpdateData();
    }
}