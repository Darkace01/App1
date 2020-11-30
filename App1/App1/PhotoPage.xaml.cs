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
    public partial class PhotoPage : ContentPage
    {
        public PhotoPage()
        {
            InitializeComponent();

            //First method
            //var imageSource = (UriImageSource) ImageSource.FromUri(new Uri("http://.."));

            var imageSource = new UriImageSource() { Uri = new Uri("https://cdn.pixabay.com/photo/2015/04/23/22/00/tree-736885__340.jpg") };
            imageSource.CachingEnabled = false;

            Image.Source = imageSource;
        }
    }
}