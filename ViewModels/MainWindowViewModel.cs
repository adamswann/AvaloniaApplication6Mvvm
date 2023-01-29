using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace AvaloniaApplication6Mvvm.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{

    public MainWindowViewModel()
    {
        SavedText = "Not set.";
    }
    
    [RelayCommand]
    private void IncreaseAge() { Age++; }
    
    [RelayCommand]
    private void DecreaseAge() { Age--; }

    [RelayCommand]
    private void Save() {
        SavedText = DraftText;
    }
    
    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(DraftText))]
    private string _firstName;
    
    [ObservableProperty] 
    [NotifyPropertyChangedFor(nameof(DraftText))]
    private string _lastName;
    
    [ObservableProperty] 
    [NotifyPropertyChangedFor(nameof(DraftText))]
    private int _age;

    public string DraftText => $"{FirstName} {LastName} is {Age} years old.";

    [ObservableProperty] 
    private string _savedText;

}