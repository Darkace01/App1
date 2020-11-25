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
    public partial class GreetPage : ContentPage
    {
        public GreetPage()
        {
            InitializeComponent();
            Slider.Value = 0.1;

            Device.OnPlatform(
                Android: () =>
                {
                    Padding = new Thickness(0, 40,0,0);
                }
                );
        }


    }
}