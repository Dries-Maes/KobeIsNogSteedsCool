using KobeIsNogSteedsCool.Views;

using Xamarin.Forms;

namespace KobeIsNogSteedsCool
    {
    public partial class AppShell : Shell
        {
        public AppShell()
            {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ToDoEntryPage), typeof(ToDoEntryPage));
            //AppShell contains all navigation routes in App
            }
        }
    }