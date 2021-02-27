
using Core.Lib.Enumerations;
using Core.Lib.OS;
using Core.MVVM;
using System;
using System.Collections.Generic;
using System.Text;
using Core.Lib.Bl;
using Core.Models.Models;

namespace Core.Lib.ViewModel
{
    class MainViewModels : ViewModelBase
    {
        public MainViewModels()
        {
            Nombre = "Federico";
        }

        ValueBL bl = new ValueBL();

        public string Nombre { set; get; }

        private string nombre;

        RelayCommand navegarCommand = null;
        public RelayCommand NavegarCommand
        {
            get => navegarCommand ?? (navegarCommand = new RelayCommand(async () =>
            {
                await DependencyService.Get<INavigationService>().NavigateTo(PagesKeys.Counter);

            }, () => { return true; }));
        }

        private List<Persona> personas;

        public bool Cargando { get; private set; }
        public List<Persona> Personas { get => personas; set => Set(ref personas, value); }

        RelayCommand cargarCommand = null;
        public RelayCommand CargarCommand
        {
            get => cargarCommand ?? (cargarCommand = new RelayCommand(async () =>
            {
                Cargando = true;
                Personas = await bl.ObtenerPersonas();
                Cargando = false;
            }, () => { return true; }));
        }

    }
}
