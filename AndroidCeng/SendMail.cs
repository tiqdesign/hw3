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
using Newtonsoft.Json;

namespace AndroidCeng
{
    [Activity(Label = "SendMail")]
    public class SendMail : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.MailSend);
            //jsondan geleni alıp objeye dönüştür.
            var item1 = FindViewById<EditText>(Resource.Id.textInputEditText6);
            var item2 = FindViewById<EditText>(Resource.Id.textInputEditText5);

            var mail1 = Intent.GetStringExtra("m1");
            Detail dt = JsonConvert.DeserializeObject<Detail>(mail1);
            
              item1.Text = dt.to;
              item2.Text = dt.subject;

        }
    }
}