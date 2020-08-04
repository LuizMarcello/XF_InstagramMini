using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XF_InstagramMini.Service;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XF_InstagramMini.Models;

namespace XF_InstagramMini
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetailPage : ContentPage
    {
        private UserService _userService;
        private User _user;

        public DetailPage(int _searchId)
        {
            _userService = new UserService();    
            InitializeComponent();
            _user = _userService.GetUserId(_searchId);
            BindingContext = _user;
        }
    }
}