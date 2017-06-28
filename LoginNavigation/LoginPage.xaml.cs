using System;
using LoginNavigation.Models;
using Xamarin.Forms;
using static LoginNavigation.DataAccess;

namespace LoginNavigation
{
	public partial class LoginPage : ContentPage
	{
        static string accessToken = null;
		public LoginPage ()
		{
			InitializeComponent ();
		}

		async void OnSignUpButtonClicked (object sender, EventArgs e)
		{
			await Navigation.PushAsync (new SignUpPage ());
		}

		async void OnLoginButtonClicked (object sender, EventArgs e)
		{
			var user = new User {
				Username = usernameEntry.Text,
				Password = passwordEntry.Text
			};
            accessToken = await DataAccess.GetAccessToken(user.Username, user.Password);
			//var isValid = AreCredentialsCorrect (user);
			if (accessToken != null) {
                ECoupon data = await DataAccess.GetCoupon(accessToken);
				App.IsUserLoggedIn = true;
				Navigation.InsertPageBefore (new MainPage (), this);
				await Navigation.PopAsync ();
			} else {
				messageLabel.Text = "Login failed";
				passwordEntry.Text = string.Empty;
			}
		}

		bool AreCredentialsCorrect (User user)
		{
			return user.Username == Constants.Username && user.Password == Constants.Password;
		}
	}
}
