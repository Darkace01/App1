using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RequestActionPage : ContentPage
    {
        public RequestActionPage()
        {
            InitializeComponent();
        }

        async void Ask_OnClicked(object sender, EventArgs e)
        {
            var response = await DisplayAlert("Warning", "Are you sure", "Yes", "No");
            if (response)
                await DisplayAlert("Done", "Your Response Has Been Saved", "Ok");
        }
    }
}