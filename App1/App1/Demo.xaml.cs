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
    public partial class Demo : ContentPage
    {
        public Demo()
        {
            InitializeComponent();

            
            listView.ItemsSource = new List<ContactGroup>
            {
                new ContactGroup("K", "K")
                {
                    new Contact {Name = "Kazeem", ImageUrl = "https://cdn.pixabay.com/photo/2015/04/23/22/00/tree-736885__340.jpg"}
                },
                
                new ContactGroup("J", "J")
                {
                    new Contact {Name = "John", ImageUrl = "https://cdn.pixabay.com/photo/2015/04/23/22/00/tree-736885__340.jpg", Status = "Hey lets talk"},
                    new Contact {Name = "James", ImageUrl = "https://cdn.pixabay.com/photo/2015/04/23/22/00/tree-736885__340.jpg", Status = "Hey lets not talk"}
                }
            };
        }
    }
}