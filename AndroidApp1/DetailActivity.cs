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

namespace AndroidApp1
{
    [Activity(Label = "DetailActivity")]
    public class DetailActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            int taskID = Intent.GetIntExtra("TaskID", 0);
            if (taskID > 0)
            {
                //task = TodoItemManager.GetTask(taskID);
            }

            //SetContentView(Resource.Layout.layout1);

            //EditText phoneNumber = FindViewById<EditText>(Resource.Id.editText1);

            //TextView txtView = FindViewById<TextView>(Resource.Id.txtPhonenumber);
            //txtView.Text = phoneNumber.Text;

        }
    }
}