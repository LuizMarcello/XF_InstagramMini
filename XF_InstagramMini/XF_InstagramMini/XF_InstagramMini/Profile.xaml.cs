using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XF_InstagramMini.Models;
using XF_InstagramMini.Service;

namespace XF_InstagramMini
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Profile : ContentPage
    {
        private UserService _userService;
        public Profile()
        {
            _userService = new UserService();
            InitializeComponent();
            PopulateListView(_userService.GetUsers());
        }

        private void PopulateListView(IEnumerable<User> users)
        {
            listViewUser.ItemsSource = users;
        }
    }
}