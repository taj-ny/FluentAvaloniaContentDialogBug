using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using FluentAvalonia.UI.Controls;

namespace FluentAvaloniaContentDialogBug
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            AvaloniaXamlLoader.Load(this);
        }

        private void Button_OnClick(object? sender, RoutedEventArgs e)
        {
            new ContentDialog()
            {
                CloseButtonText = "e"
            }.ShowAsync();
        }

        private void Button2_OnClick(object? sender, RoutedEventArgs e)
        {
            new CustomContentDialog()
            {
                CloseButtonText = "e"
            }.ShowAsync();
        }
    }
}