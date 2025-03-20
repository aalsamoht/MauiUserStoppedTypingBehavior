using System.Collections.ObjectModel;
using System.Diagnostics;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace MauiUserStoppedTypingBehavior;

public partial class MainViewModel : ObservableObject
{
    public ObservableCollection<string> Items { get; } = [];

    public MainViewModel()
    {
        Items.Add("Item 1");
        Items.Add("Item 2");
        Items.Add("Item 3");
        Items.Add("Item 4");
        Items.Add("Item 5");
        Items.Add("Item 6");
    }

    [RelayCommand]
    private void Search(string searchTerm)
    {
        var mt = MainThread.IsMainThread;
        Debug.WriteLine($"Search: {searchTerm} - MainThread: {mt}");
        Console.WriteLine($"Search: {searchTerm} - MainThread: {mt}");
    }
}