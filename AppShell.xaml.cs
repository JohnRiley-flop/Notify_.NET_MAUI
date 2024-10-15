using Notify.Views;

namespace Notify
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute("Main", typeof(MainPage));
            Routing.RegisterRoute("AddNote", typeof(AddNotePage));
        }
    }
}
