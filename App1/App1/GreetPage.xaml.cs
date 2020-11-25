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
        }


        private void Slider_OnValueChanged(object sender, ValueChangedEventArgs e)
        {
            Label.Text = String.Format("Value is {0:F2}", e.NewValue);
        }
    }
}