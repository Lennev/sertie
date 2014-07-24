using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

using Xamarin.Forms.Platform.Android;

namespace Sertie.core.Droid
{
    [Activity(Label = "Sertie.core", MainLauncher = true)]
    public class MainActivity : AndroidActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.CreateQuestionView);
            //Xamarin.Forms.Forms.Init(this, bundle);

            //SetPage(App.GetMainPage());
        }
    }
}

