using System;
using System.Collections.Generic;
using System.Text;
using XF_InstagramMini.Models;

namespace XF_InstagramMini.Service
{
    public class ActivityService
    {
        private List<Activity> _activities = new List<Activity>
        {
            new Activity
            {
                UserId = 1,
                Description = "LuizMarcello o seu amigo do facebook esta no Instagram"
            },

            new Activity
            {
                UserId = 2,
                Description = "NataliaRenata começou a te seguir"
            },

            new Activity
            {
                UserId = 3,
                Description = "Valeria deu um like na sua foto"
            },

            new Activity
            {
                UserId = 4,
                Description = "ThiagoJosé está no instagram"
            },

            new Activity
            {
                UserId = 5,
                Description = "Gabriel Isaac deu um like na sua foto"
            }
        };

        public IEnumerable<Activity> GetActivities()
        {
            return _activities;
        }
    }
}
