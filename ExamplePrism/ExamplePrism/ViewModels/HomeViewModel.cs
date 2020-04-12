using ExamplePrism.Interfaces;
using Prism.Navigation;
using Prism.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExamplePrism.ViewModels
{
    public class HomeViewModel
    {
        INavigationService _navigationService;
        IPageDialogService _pageDialogService;
        IApiServices _apiServices;
        public HomeViewModel(INavigationService navigationService,IPageDialogService pageDialogService, IApiServices apiServices)
        {
            _navigationService = navigationService;
            _pageDialogService = pageDialogService;
            _apiServices = apiServices;
        }
        private void goTodoPage()
        {
            var parameter = new NavigationParameters();
            parameter.Add("theFirstParameters","Bienvenido");
            _navigationService.NavigateAsync(new Uri("HomePage",UriKind.Relative),parameter);
        }
        private void showAlert()
        {
            _pageDialogService.DisplayAlertAsync("My alert","hello","ok");
        }
    }
  
}
