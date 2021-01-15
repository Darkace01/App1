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
    public partial class ToolBarPage : ContentPage
    {
        public ToolBarPage()
        {
            InitializeComponent();
        }

        private void MenuItem_OnClicked(object sender, EventArgs e)
        {
            DisplayAlert("Activated", "ToolbarItem Activated", "OK");
        }
    }
}