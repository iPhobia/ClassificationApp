using Avalonia;
using Avalonia.Markup.Xaml;

namespace ClassificationApp
{
    public class App : Application
    {
        public override void Initialize()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
