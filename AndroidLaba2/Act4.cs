using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndroidLaba2
{
    [Activity(Label = "@string/act4")]
    public class Act4 : Activity
    {
        protected override void OnCreate(Bundle? savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Act4);

            Button Act4BT1 = FindViewById<Button>(Resource.Id.Act4BT1);

            Act4BT1.Click += delegate
            {
                Act4BT1.SetBackgroundResource(Resource.Drawable.button_bg2);

                Act4BT1.SetText(Resource.String.nos);
            };
        }
    }
}
