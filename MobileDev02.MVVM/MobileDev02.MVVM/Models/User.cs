using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace MobileDev02.MVVM.Models
{
    public class User : INotifyPropertyChanged
    {
        public User() { }
        public User(string name, string username, string password) {
            Name = name;
            Username = username;
            Password = password;
        }

        public string Name { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public override string ToString() => Name;
    }
}
