using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
namespace ShellSearch;

public partial class MainViewModel : ObservableObject
{
    private readonly CityService cityService;
    public MainViewModel(CityService cityService)
    {
        this.cityService = cityService;
    }

    [ObservableProperty]
    private string query, selectedCity;

    [ObservableProperty]
    private List<string> searchResult;

    partial void OnQueryChanged(string? oldValue, string newValue)
    {
        Task.Run(async() =>
        {
            var result = await cityService.SearchCity(newValue);

            MainThread.BeginInvokeOnMainThread(() => 
            { 
                SearchResult = result; 
            });
        });
    }

    [RelayCommand]
    private async Task GoToCity()
    {
        var city = SelectedCity;
    }
}
