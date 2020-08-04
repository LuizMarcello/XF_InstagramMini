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
    public partial class Activities : ContentPage
    {
        private ActivityService _activityService;
        public Activities()
        {
            _activityService = new ActivityService();
            InitializeComponent();
            PopulateListView(_activityService.GetActivities());

        }

        private void PopulateListView(IEnumerable<Activity> activities)
        {
            listView.ItemsSource = activities;
        }

        private async void listView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
                return;

            var activity = e.SelectedItem as Activity;
            await Navigation.PushAsync(new DetailPage(activity.UserId));
        }
    }
}
