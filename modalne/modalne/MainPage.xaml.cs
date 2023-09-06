using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace modalne
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new ModalPage());
        }

        private async void alert(object sender, EventArgs e)
        {
            await DisplayAlert("Alert", "You have been alerted", "Ok");
        }

        private async void sheet(object sender, EventArgs e)
        {
            string actionSendTo = await DisplayActionSheet("AcionSheet: Send to?", "Cancel", null, "Email", "Twitter", "Facebook");
        }

        private async void prompt(object sender, EventArgs e)
        {
            string resultQuestion = await DisplayPromptAsync("Question 2", "What's 5 + 5?", initialValue: "10", maxLength: 2, keyboard: Keyboard.Numeric);
        }
    }
}
