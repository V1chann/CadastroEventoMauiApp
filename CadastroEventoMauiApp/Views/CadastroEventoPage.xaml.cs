using CadastroEventoMauiApp.ViewModels;

namespace CadastroEventoMauiApp.Views;

public partial class CadastroEventoPage : ContentPage
{
	public CadastroEventoPage()
	{
		InitializeComponent();

        BindingContext = new CadastroEventoViewModel();

		dtpck_checking.MinimumDate = DateTime.Now;
		dtpck_checking.MaximumDate = DateTime.Now.AddMonths(6);

		dtpck_checkout.MinimumDate = DateTime.Now.AddDays(1);
		dtpck_checkout.MaximumDate = DateTime.Now.AddMonths(6);

		dtpck_checking.DateSelected += Dtpck_checking_DateSelected;

    }

	private void Dtpck_checking_DateSelected(object sender, DateChangedEventArgs e)
	{
		dtpck_checkout.MinimumDate = e.NewDate.AddDays(1);
		if (dtpck_checkout.Date <= dtpck_checkout.MinimumDate)
		{
			dtpck_checkout.Date = dtpck_checkout.MinimumDate;
		}
	}
}