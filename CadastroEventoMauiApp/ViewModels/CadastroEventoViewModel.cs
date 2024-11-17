using CadastroEventoMauiApp.Models;
using CadastroEventoMauiApp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CadastroEventoMauiApp.ViewModels
{
    public class CadastroEventoViewModel : BindableObject
    {
        private Evento _evento;

        public Evento Evento
        {
            get => _evento;
            set
            {
                _evento = value;
                OnPropertyChanged();
            }
        }

        public ICommand CadastrarCommand { get; }

        public CadastroEventoViewModel()
        {
            _evento = new Evento
            {
                Nome = string.Empty,
                DataInicio = DateTime.Now,
                DataTermino = DateTime.Now.AddDays(1),
                NumeroParticipantes = 0,
                Local = string.Empty,
                CustoPorParticipante = 0
            };

            CadastrarCommand = new Command(OnCadastrar);
        }

        private async void OnCadastrar()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new EventoCadastrado(Evento));
        }
    }
}
