using MAUI_ToDo.MVVM.Views;
using Microsoft.Maui.Platform;

namespace MAUI_ToDo
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NewTaskView();

#if ANDROID
            Microsoft.Maui.Handlers.EntryHandler.Mapper
                .AppendToMapping(nameof(Entry), (handler, view) =>
                {
                    handler.PlatformView.BackgroundTintList = Android.Content.Res.ColorStateList.ValueOf(Colors.Transparent.ToPlatform());
                });
#endif

#if IOS

            Microsoft.Maui.Handlers.EntryHandler.Mapper.AppendToMapping(nameof(Entry), (handler, view) =>
            {
                handler.PlatformView.BorderStyle = UITextBorderStyle.None;

                handler.PlatformView.BackgroundColor = UIColor.Clear;

                handler.PlatformView.LeftView = new UIView(new CoreGraphics.CGRect(0, 0, 8, 0));
                handler.PlatformView.LeftViewMode = UITextFieldViewMode.Always;
            });
#endif

        }
    }
}
