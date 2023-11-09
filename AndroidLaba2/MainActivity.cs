using Android.Content;

namespace AndroidLaba2
{
    [Activity(Label = "@string/act1", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle? savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            Button MainB1 = FindViewById<Button>(Resource.Id.MainB1);

            Button MainB2 = FindViewById<Button>(Resource.Id.MainB2);

            Button MainB3 = FindViewById<Button>(Resource.Id.MainB3);

            Button MainB4 = FindViewById<Button>(Resource.Id.MainB4);

            MainB1.Click += delegate
            {
                Intent intent = new Intent(this, typeof(Act2));

                StartActivity(intent);
            };

            MainB2.Click += delegate
            {
                Intent intent = new Intent(this, typeof(Act3));

                StartActivity(intent);
            };

            MainB3.Click += delegate
            {
                Intent intent = new Intent(this, typeof(Act4));

                StartActivity(intent);
            };


            MainB4.Click += delegate
            {
                this.Finish();
            };
        }
    }
}