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

    private void Button_Clicked_AddTask(object sender, EventArgs e)
    {
		var taskView = new NewTaskView
		{
			BindingContext = new NewTaskViewModel
			{
				Tasks = _mainViewModel.Tasks,
				Categories = _mainViewModel.Categories
			}
		};
		Navigation.PushAsync(taskView);
    }
}