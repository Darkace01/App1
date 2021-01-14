using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App1.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SearchDetailPage : ContentPage
    {
        public SearchDetailPage(Contact contact)
        {
            if(contact == null)
                throw new ArgumentException();

            BindingContext = contact;
            InitializeComponent();
        }
    }
}