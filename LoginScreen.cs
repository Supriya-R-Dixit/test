using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Gurukul_MVP
{
    [Activity(Label = "LoginScreen", MainLauncher = true)]
    public class LoginScreen : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here

            SetContentView(Resource.Layout.Main);

            EditText usernameEditText = FindViewById<EditText>(Resource.Id.username);
            Button loginButton = FindViewById<Button>(Resource.Id.login);
            TextView messageTextView = FindViewById<TextView>(Resource.Id.messageDisplay);

            loginButton.Click += (sender, e) =>
            {

                if (usernameEditText.Text.CompareTo("Supriya")==0 || usernameEditText.Text.CompareTo("Sree")==0 || usernameEditText.Text.CompareTo("Rekha")==0 || usernameEditText.Text.CompareTo("Ajay")==0)
                {
                    var intent = new Intent(this, typeof(OptionsforKids));
                    StartActivity(intent);
                }
                else
                {
                    messageTextView.Text = "Login failed! Try again";
                }
            };
        }
    }
}