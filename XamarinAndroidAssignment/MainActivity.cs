using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Android.Graphics;
using Android.Views;
using System;
using Android.Content;

namespace XamarinAndroidAssignment
{
    [Activity(Label = "@string/app_name", Icon = "@drawable/iconX")]
    public class MainActivity : AppCompatActivity
    {
        EditText first;
        EditText second;
        string firstDigit;
        string secondDigit;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
             SetContentView(Resource.Layout.activity_main);

            /* var config = new EasySplashScreen(this)
                  .WithFullScreen()
                  .WithTargetActivity(Java.Lang.Class.FromType(typeof(UserInputActivity)))
                  .WithSplashTimeOut(5000)
                  .WithBackgroundColor(Color.ParseColor("#8EDCFB"))
                  .WithHeaderText("Welcome to Xamarine Android Assignment");

              config.HeaderTextView.SetTextColor(Color.White);

              View view = config.Create();
              SetContentView(view);*/

           first = (EditText)FindViewById(Resource.Id.edt_firstNumber);
            second= (EditText)FindViewById(Resource.Id.edt_secNumber);

            Button button1 = FindViewById<Button>(Resource.Id.btn_Continue);
            button1.Click += Button_Click;
        }

        private void Button_Click(object sender, EventArgs e)
        {

            firstDigit = first.Text.ToString();
            secondDigit = second.Text.ToString();
            if(firstDigit.Trim().Length>0 && secondDigit.Trim().Length>0)
            {
                var activity = new Intent(this, typeof(ActivityResult));
                activity.PutExtra("First", firstDigit);
                activity.PutExtra("Second", secondDigit);
                StartActivity(activity);
                Finish();
            }
            else
            {
                Toast.MakeText(this, "Please fill valid number in each box!!!", ToastLength.Long).Show();
            }
           
        }

        public override void OnBackPressed()
        {
            Finish();
        }
    }
}