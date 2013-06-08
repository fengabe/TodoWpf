/*
  In App.xaml:
  <Application.Resources>
      <vm:ViewModelLocator xmlns:vm="clr-namespace:TodoWpf"
                           x:Key="Locator" />
  </Application.Resources>
  
  In the View:
  DataContext="{Binding Source={StaticResource Locator}, Path=ViewModelName}"

  You can also use Blend to do all this with the tool's support.
  See http://www.galasoft.ch/mvvm
*/

using Microsoft.Practices.Unity;

namespace TodoWpf.ViewModel
{
    /// <summary>
    /// This class contains static references to all the view models in the
    /// application and provides an entry point for the bindings.
    /// </summary>
    public class ViewModelLocator
    {
        private static Bootstraper _bootstraper;

        public ViewModelLocator()
        {
            if (_bootstraper == null)
                _bootstraper = new Bootstraper();
        }

        public MainWindowViewModel MainWindow
        {
            get { return _bootstraper.Container.Resolve<MainWindowViewModel>(); }
        }
    }
}