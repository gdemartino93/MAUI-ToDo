using MAUI_ToDo.MVVM.Views;

namespace MAUI_ToDo
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainView();
        }
    }
}
