using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;

namespace XamarinAndroidAssignment
{
    [Activity(Label = "@string/app_name", Theme ="@style/AppTheme")]
    public class ActivityResult : AppCompatActivity
    {
        TextView resultText;
        Button back, exit;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
           String first= Intent.GetStringExtra("First");
            String second = Intent.GetStringExtra("Second");
            int sum = Convert.ToInt32(first) + Convert.ToInt32(second);
  
            SetContentView(Resource.Layout.result_activity);
            resultText= (TextView)FindViewById(Resource.Id.txt_result);
            resultText.Text="You have entered " + first + "+" + second + " = " + sum;

            back = FindViewById<Button>(Resource.Id.btn_back);
            exit = FindViewById<Button>(Resource.Id.btn_exit);

            back.Click += Back_Click;

            exit.Click += Exit_Click;
        }

        private void Back_Click(object sender, EventArgs e)
        {
            var activity = new Intent(this, typeof(MainActivity));
            StartActivity(activity);
            Finish();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            //Close the application
            this.FinishAffinity();
            //Exit and Kill the application
            //Android.OS.Process.KillProcess(Android.OS.Process.MyPid());
        }

        public override void OnBackPressed()
        {
            var activity = new Intent(this, typeof(MainActivity));
            StartActivity(activity);
            Finish();
        }
    }
}