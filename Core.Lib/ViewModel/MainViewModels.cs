using Core.Lib.Bl;
using Core.Lib.Enumerations;
using Core.Lib.OS;
using Core.Models.Models;
using Core.MVVM;
using System;
using System.Collections.Generic;

namespace Core.Lib.ViewModel
{
    class MainViewModels : ViewModelBase  // ViewModelBase : para hacer uso del MVVM Universal
    {
        public MainViewModels()
        {
            //Nombre = "My name is Osiel";
            //List<Persona> personas = new List<Persona>();
        }

        public string Nombre { get; set; }

        public void GetNombre()
        {
            Nombre = "My name is Osiel";
            Console.WriteLine($"{Nombre}");
        }

        ValueBL bl = new ValueBL();

        RelayCommand navegarCommand = null;

        public RelayCommand NavegarCommand  // RelayCommand: Acciones o comandos (Botones)
        {
            get => navegarCommand ?? (navegarCommand = new RelayCommand(async () =>
            {
                await DependencyService.Get<INavigationService>().NavigateTo(PagesKeys.Counter);

            }, () => { return true; }));
        }

        private List<Persona> personas;
        public bool Cargando { get; set; }

        // Set: Notifica a la vista referente a la propiedad que ya se tiene algún valor || Establece el valor de la propiedad y notifica cambios
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
