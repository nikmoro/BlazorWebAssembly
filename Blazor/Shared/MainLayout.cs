using Blazor.OS;
using Blazored.Modal.Services;
using Core.Lib.OS;
using Core.MVVM;
using Microsoft.AspNetCore.Components;

namespace Blazor.Shared
{
    public partial class MainLayout
    {
        [Inject]
        protected NavigationManager NavigationManager { get; set; }

        [Inject]
        protected IModalService ModalService { get; set; }

        protected override void OnInitialized()
        {
            // Navegación
            (DependencyService.Get<INavigationService>() as NavigationManager).NavigationManager = this.NavigationManager;
            
            // Modales
            (DependencyService.Get<IModalService>() as ModalService).ModalService = this.ModalService;
        }
    }
}
