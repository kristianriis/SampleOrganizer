using CommunityToolkit.Mvvm.ComponentModel;

namespace SampleOrganizer.App.ViewModels;

public partial class MainViewModel : ViewModelBase
{
    [ObservableProperty]
    public partial string Greeting { get; set; } = "Welcome to Avalonia! It actually works";
}
