using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace KobeIsNogSteedsCool.Views
    {
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ToDoPage : ContentPage
        {
        public ToDoPage()
            {
            InitializeComponent();
            }

        private async void OnAddNoteBarClicked(object sender, EventArgs e)
            {
            await
                Shell.Current.GoToAsync(nameof(ToDoEntryPage));
            }
        }
    }