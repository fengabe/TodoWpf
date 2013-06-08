TodoWpf
=======

WPF MVVM application with modern UI style

## Framework
This project uses the [MVVM Light Toolkit](http://mvvmlight.codeplex.com/) to help with some basic plumbing. This toolkit allows us to easily raise property changed events

```csharp
public bool Complete
{
    get { return _complete; }
    set
    {
        _complete = value;
        RaisePropertyChanged(() => Complete);
        ContentColor = _complete ? COMPLETE_COLOR : INCOMPLETE_COLOR;
    }
}
```

## Dependency Injection
Microsoft's [Unity library](http://msdn.microsoft.com/en-us/library/dd203101.aspx) works beautifully with the MVVM Light framework. The IoC Container for this project is in the `Bootstrapper.cs` file. The bootstrapper class is reference in the ViewModelLocator when a new view is constructed. Dependencies are injected into the ViewModels that require them.

## The GUI
Default WPF windows are boring. [Elysium](http://elysium.codeplex.com/) makes things better. Setting up Elysium is a bit tricky. `The App.xaml.cs` class has the following handler to initialize the theme:

```csharp
private void StartupHandler(object sender, StartupEventArgs e)
{
    this.Apply(Theme.Light, AccentBrushes.Blue, Brushes.White);
}
```

`App.xaml` then needs the following `ResourceDictionary`

```xml
<Application.Resources>
    <ResourceDictionary>
        <ResourceDictionary.MergedDictionaries>
            <ResourceDictionary Source="/Elysium;component/Themes/Generic.xaml" />
        </ResourceDictionary.MergedDictionaries>
        <vm:ViewModelLocator x:Key="Locator" d:IsDataSource="True" />
    </ResourceDictionary>
</Application.Resources>
```

`MainWindow.xaml` needs to reference the modern namespace

```xml
<modern:Window x:Class="TodoWpf.MainWindow"
              xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
              xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
              xmlns:modern="http://schemas.codeplex.com/elysium"
              Title="Todo WPF" Height="350" Width="525">
    <DockPanel>
  	</DockPanel>
</modern:Window>
```
