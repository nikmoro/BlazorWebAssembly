using System;

namespace Blazor.OS
{
    using Core.Lib.Enumerations;
    using Blazored.Modal.Services;
    using Core.Lib.OS;
    using Microsoft.AspNetCore.Components;
    using System.Threading.Tasks;

    public class NavigationService : INavigationService
    {
        internal NavigationManager NavigationManager { get; set; }
        
        internal IModalService ModalService { get; set; }

        string currentPage, previousPage;

        public Task GoBack()
        {
            if (!string.IsNullOrEmpty(previousPage))
                NavigationManager.NavigateTo(previousPage);
            return Task.CompletedTask;
        }

        public Task Home()
        {
            previousPage = string.Empty; currentPage = "/";
            NavigationManager.NavigateTo("/");
            return Task.CompletedTask;
        }

        public Task NavigateTo(PagesKeys pageKey)
        {
            previousPage = currentPage;
            currentPage = pageKey switch
            {
                PagesKeys.Login => "/", // Ejemplos
                PagesKeys.Crud => "Crud",
                PagesKeys.Counter => "counter",
                _ => "Login" // Valor por defecto
            };
            NavigationManager.NavigateTo(currentPage);
            return Task.CompletedTask;
        }

        public Task NavigateTo(PagesKeys pageKey, params object[] parameter)
        {
            previousPage = currentPage;
            currentPage = pageKey switch
            {
                PagesKeys.Login => $"/?param1={parameter[0]}", // Url con parametro
                PagesKeys.Crud => $"Crud?param1={parameter[0]}",
                _ => "Login"
            };
            NavigationManager.NavigateTo(currentPage);
            return Task.CompletedTask;
        }

        public Task PopModal()
        {
            throw new NotImplementedException();
        }

        public void NavigatePop()
        {
            throw new NotImplementedException();
        }

        public void NavigateToUrl(string url)
        {
            throw new NotImplementedException();
        }

        public Task PushModal(PopupsKeys popUpKey)
        {
            throw new NotImplementedException();
        }

        public Task PushModal(PopupsKeys popUpKey, params object[] parameter)
        {
            throw new NotImplementedException();
        }
    }
}
