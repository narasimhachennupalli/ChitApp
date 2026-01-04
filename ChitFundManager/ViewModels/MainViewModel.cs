using System.Windows.Input;
using ChitFundManager.Helpers;

namespace ChitFundManager.ViewModels;

/// <summary>
/// ViewModel for the Main Window
/// </summary>
public class MainViewModel : ViewModelBase
{
    private string _title = "Chit Fund Manager";
    private string _welcomeMessage = "Welcome to Chit Fund Manager";

    /// <summary>
    /// Gets or sets the window title
    /// </summary>
    public string Title
    {
        get => _title;
        set => SetProperty(ref _title, value);
    }

    /// <summary>
    /// Gets or sets the welcome message
    /// </summary>
    public string WelcomeMessage
    {
        get => _welcomeMessage;
        set => SetProperty(ref _welcomeMessage, value);
    }

    /// <summary>
    /// Command for sample action
    /// </summary>
    public ICommand SampleCommand { get; }

    public MainViewModel()
    {
        SampleCommand = new RelayCommand(ExecuteSampleCommand);
    }

    private void ExecuteSampleCommand(object? parameter)
    {
        WelcomeMessage = $"Button clicked at {DateTime.Now:HH:mm:ss}";
    }
}
