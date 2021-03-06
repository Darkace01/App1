﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        private ObservableCollection<ContactGroup> _contacts;

        ObservableCollection<ContactGroup> GetContact()
        {
            return new ObservableCollection<ContactGroup>
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
        public Demo()
        {
            InitializeComponent();


            _contacts = GetContact();

            listView.ItemsSource = _contacts;
        }

        private void ListView_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var contact = e.SelectedItem as Contact;
            DisplayAlert("Selected", contact.Name, "Ok");
        }

        private void ListView_OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            var contact = e.Item as Contact;
            DisplayAlert("Selected", contact.Name, "Ok");
        }

        private void Call_OnClicked(object sender, EventArgs e)
        {
            var menuItem = sender as MenuItem;
            var contact = menuItem.CommandParameter as Contact;
            DisplayAlert("Call", contact.Name, "Ok");
        }

        
        private void Delete_OnClicked(object sender, EventArgs e)
        {
            var contact = (sender as MenuItem).CommandParameter as ContactGroup;
            _contacts.Remove(contact);
        }

        private void Follow_OnClicked(object sender, EventArgs e)
        {
            var button = sender as Button;
            var contact = button.CommandParameter as Contact;
            DisplayAlert("Do you want to follow this user?", contact.Name, "YES");
        }

        private void ListView_OnRefreshing(object sender, EventArgs e)
        {
            listView.ItemsSource = GetContact();
            listView.EndRefresh();
        }
    }
}