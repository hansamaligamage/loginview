using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using loginview.Droid;
using Xamarin.Forms;

[assembly: Dependency(typeof(UserLogin))]
namespace loginview.Droid
{
    public class UserLogin : IUserLogin
    {
        public Task<bool> Login(string username, string password)
        {
            if (username == password)
                return Task.FromResult<bool>(true);
            return Task.FromResult<bool>(false);
        }
    }
}