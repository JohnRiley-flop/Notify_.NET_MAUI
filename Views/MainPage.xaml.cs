using Notify.ViewModels;
namespace Notify.Views
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            this.BindingContext = new MainPageViewModel();

            NavigationPage.SetHasBackButton(this, false);
        }
    }

}
