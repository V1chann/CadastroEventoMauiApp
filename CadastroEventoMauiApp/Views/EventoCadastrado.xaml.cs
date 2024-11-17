using CadastroEventoMauiApp.Models;

namespace CadastroEventoMauiApp.Views;

public partial class EventoCadastrado : ContentPage
{
	public EventoCadastrado(Evento evento)
	{
		InitializeComponent();

		BindingContext = evento;

    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }

}