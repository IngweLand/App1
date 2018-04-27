#region Author
// Author ILYA GOLOVACH (aka IngweLand)
// http://ingweland.com
// ingweland@gmail.com
// Created: 27 04 2018
#endregion

using System;
using Prism.Mvvm;
using Prism.Navigation;

namespace App1.ViewModels
{
    public class PageBase:BindableBase, INavigationAware
    {
        public void OnNavigatedFrom(INavigationParameters parameters)
        {
            Console.Out.WriteLine("OnNavigatedFrom");
        }

        public void OnNavigatedTo(INavigationParameters parameters)
        {
            Console.Out.WriteLine("OnNavigatedTo");
        }

        public void OnNavigatingTo(INavigationParameters parameters)
        {
            Console.Out.WriteLine("OnNavigatingTo");
        }
    }
}