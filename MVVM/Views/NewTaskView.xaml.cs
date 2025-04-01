using MAUI_ToDo.MVVM.Models;
using MAUI_ToDo.MVVM.ViewModels;
using System.Threading.Tasks;

namespace MAUI_ToDo.MVVM.Views;

public partial class NewTaskView : ContentPage
{
	public NewTaskView()
	{
		InitializeComponent();
	}

    private async void Button_Clicked_AddTask(object sender, EventArgs e)
    {
		var viewModel = BindingContext as NewTaskViewModel;
		var selectedCategory = viewModel.Categories.FirstOrDefault(c => c.IsSelected);

		if (selectedCategory == null)
		{
            await DisplayAlert(string.Empty, "Devi selezionare una categoria", "Ok");
			return;
        }
		if (string.IsNullOrEmpty(viewModel.Task))
		{
            await DisplayAlert(string.Empty, "Devi inserire un nome per l'attività", "Ok");
            return;
        }

        var random = new Random();
        viewModel.Tasks.Add(new Models.Task { IsCompleted = false, CategoryId = selectedCategory.Id, Name = viewModel.Task, Color = viewModel.Categories?.FirstOrDefault(c => c.Id == selectedCategory.Id)?.Color});
        await Navigation.PopAsync(true);
    }

    private async void Button_Clicked_AddCategory(object sender, EventArgs e)
    {
        var viewModel = BindingContext as NewTaskViewModel;
        var random = new Random();
        string category = await DisplayPromptAsync(string.Empty, "Inserisci un nome per la categoria", maxLength: 20, keyboard: Keyboard.Text);

        if (string.IsNullOrEmpty(category))
        {
            await DisplayAlert(string.Empty, "Devi inserire un nome per la categoria", "Ok");
            return;
        }
        Category newCategory = new Category
        {
            Id = viewModel.Categories.Max(c => c.Id),
            Name = category,
            Color = Color.FromRgb(random.Next(256), random.Next(256), random.Next(256)).ToString(),
            IsSelected = false,
            PendingTasks = 0
        };
        viewModel.Categories.Add(newCategory);
    }
}