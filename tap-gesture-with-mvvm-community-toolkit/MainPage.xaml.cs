using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace tap_gesture_with_mvvm_community_toolkit
{
    public partial class MainPage : ContentPage
    {
        public MainPage() => InitializeComponent();
    }
    // https://learn.microsoft.com/en-us/dotnet/communitytoolkit/mvvm/relaycommand#working-with-icommand
    partial class SearchLoadingListVM : ObservableObject
    {
        [RelayCommand]
        private void CounterButtonClick()
        { 
        }
    }
}
