using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Graphics.Drawables;
using AndroidApp1.Models;
using Newtonsoft.Json;

namespace AndroidApp1
{
    [Activity(Label = "AndroidApp1", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        int count = 1;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            Button button1 = FindViewById<Button>(Resource.Id.MyButton);
            Button btnSave = FindViewById<Button>(Resource.Id.BtnSave);

            //button1.Click += delegate { button.Text = string.Format("{0} clicks!", count++); };
            button1.Click += (sender, e) => { ButtonClick(); };          
            btnSave.Click += (sender, e) => { Save(); };
        }

        private void Save()
        {
            EditText edtName = FindViewById<EditText>(Resource.Id.EdtName);
            EditText edtPhone = FindViewById<EditText>(Resource.Id.EdtPhone);

            Person person = new Person();
            person.Name = edtName.Text;
            person.Phone = edtPhone.Text;

            string jsonString = JsonConvert.SerializeObject(person);


            //how to use Intent
            StartActivity(typeof(DetailActivity));
        }

        private void ButtonClick()
        {
            int index = count++;
            TextView tv = FindViewById<TextView>(Resource.Id.LblName);
            tv.Text = string.Format("{0} clicks!", index);

            ImageView iv = FindViewById<ImageView>(Resource.Id.imageView1);
            iv.SetImageResource(imgResource[index]);
            iv.SetScaleType(ImageView.ScaleType.FitCenter);
        }

        int[] imgResource = new int[]
        {
            Resource.Drawable.Bottlenose_Dolphin,
            Resource.Drawable.bottlenose_dolphin_grey,
            Resource.Drawable.Icon
        };
    }
}

