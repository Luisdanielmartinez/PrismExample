using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExamplePrism.ViewModels
{
   public class TodoViewModel :INavigatedAware
   {
        INavigationService _navigationService;
        public string Elements { get; set; }
        public TodoViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        public void OnNavigatedFrom(INavigationParameters parameters)
        {
            throw new NotImplementedException();
        }

        public void OnNavigatedTo(INavigationParameters parameters)
        {
            var obj = parameters["theFirstParameters"];
        }
    }
}
