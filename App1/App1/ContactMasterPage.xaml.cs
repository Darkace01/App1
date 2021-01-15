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
    public partial class ContactMasterPage : MasterDetailPage
    {
        public ContactMasterPage()
        {
            InitializeComponent();
            listview.ItemsSource =  new List<Contact>
            {
                new Contact
                {
                    Name = "John", ImageUrl = "https://cdn.pixabay.com/photo/2015/04/23/22/00/tree-736885__340.jpg",
                    Status = "Hey lets talk"
                },
                new Contact {Name = "James", ImageUrl = "https://cdn.pixabay.com/photo/2015/04/23/22/00/tree-736885__340.jpg", Status = "Later"},
                new Contact {Name = "Bola", ImageUrl = "https://cdn.pixabay.com/photo/2015/04/23/22/00/tree-736885__340.jpg", Status = "Gerrarahere"},
                new Contact {Name = "Nayyar", ImageUrl = "https://cdn.pixabay.com/photo/2015/04/23/22/00/tree-736885__340.jpg", Status = "Whats Up"},
                new Contact {Name = "Tim", ImageUrl = "https://cdn.pixabay.com/photo/2015/04/23/22/00/tree-736885__340.jpg", Status = "Piss Off"},
                new Contact {Name = "Corry", ImageUrl = "https://cdn.pixabay.com/photo/2015/04/23/22/00/tree-736885__340.jpg", Status = "Not Now"}
            };
        }

        void MasterItem_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var contact = e.SelectedItem as Contact;
            Detail = new NavigationPage(new SearchDetailPage(contact));
            IsPresented = false; //IsMasterPresented
        }
    }
}