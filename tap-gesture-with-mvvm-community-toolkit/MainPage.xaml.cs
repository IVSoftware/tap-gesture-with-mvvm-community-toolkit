using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace tap_gesture_with_mvvm_community_toolkit
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext.LoadingListCollection.Add("Apple");
            BindingContext.LoadingListCollection.Add("Orange");
            BindingContext.LoadingListCollection.Add("Banana");
        }
        new Model.SearchLoadingListVM BindingContext => (Model.SearchLoadingListVM)base.BindingContext;
    }
    // https://learn.microsoft.com/en-us/dotnet/communitytoolkit/mvvm/relaycommand#working-with-icommand

    namespace Model
    {
        partial class SearchLoadingListVM : ObservableObject
        {
            [RelayCommand]
            private async Task ItemTaped(string s)
            {
                if (App.Current?.MainPage is Page main)
                {
                    await main.DisplayAlert("Alert", $"{s} was tapped.", "OK");
                }
            }
            public ObservableCollection<string> LoadingListCollection { get; } = new ObservableCollection<string>();
        }
    }
}
