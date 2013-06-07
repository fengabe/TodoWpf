using System.Windows;
using System.Windows.Media;
using Elysium;

namespace MetroApplication1
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void StartupHandler(object sender, StartupEventArgs e)
        {
            this.Apply(Theme.Light, AccentBrushes.Blue, Brushes.White);
        }
    }
}
