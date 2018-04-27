#region Author

// Author ILYA GOLOVACH (aka IngweLand)
// http://ingweland.com
// ingweland@gmail.com
// Created: 27 04 2018

#endregion

#region

using App1.Views;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using Xamarin.Forms;

#endregion

namespace App1.ViewModels
{
    public class PrismMasterDetailPage1ViewModel : BindableBase
    {
        public PrismMasterDetailPage1ViewModel(INavigationService navigationService)
        {
            NavigateCommand = new DelegateCommand<string>(s =>
                navigationService.NavigateAsync($"{nameof(PrismMasterDetailPage1)}/{nameof(NavigationPage)}/{s}"));
        }

        public DelegateCommand<string> NavigateCommand { get; set; }
    }
}