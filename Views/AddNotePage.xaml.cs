using Notify.ViewModels;
namespace Notify.Views;

public partial class AddNotePage : ContentPage
{
	public AddNotePage()
	{
        InitializeComponent();
		this.BindingContext = new AddNotePageViewModel();

		NavigationPage.SetHasBackButton(this, false);
		NavigationPage.SetHasNavigationBar(this, false);
    }
}