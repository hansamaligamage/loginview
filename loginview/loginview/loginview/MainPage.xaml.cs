using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace loginview
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        async void OnButtonClick(object sender, EventArgs e)
        {
            if (await this.DisplayAlert(
                      "Hello " + userName.Text,
                      "Would you like to login to the system ?",
                      "Yes",
                      "May be later"))
            {
                var userlogin = DependencyService.Get<IUserLogin>();
                if(userlogin != null)
                {
                    bool success = await userlogin.Login(userName.Text, password.Text);
                    if (success)
                        message.Text = "Welcome " + userName.Text + " you are authorized now";
                    else
                        message.Text = "You are not authorized!!!";
                }
            }
        }


    }
}
