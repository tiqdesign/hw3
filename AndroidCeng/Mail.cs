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
    class Mail : DialogFragment
    {
        private ListView listv;
        private string[] mailL = {
            "Mentoring",
            "Course Information",
            "Project Participation",
            "Objection",
            "General" };

        private string MailTo;
       

        public Mail( string to)
        {
            MailTo = to;
        }

        private ArrayAdapter adapter;

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            View v = inflater.Inflate(Resource.Layout.list, container, false);

           
            listv = v.FindViewById<ListView>(Resource.Id.lv);

            adapter = new ArrayAdapter(this.Activity, Android.Resource.Layout.SimpleListItem1, mailL);
            listv.Adapter = adapter;
            listv.ItemClick += lv_itemClick;

            return v;
        }

        void lv_itemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
           //Json ile dönüştürüp yolla

            var intent = new Intent(Application.Context, typeof(SendMail));
            Detail dt1 = new Detail
            {
                subject = listv.GetItemAtPosition(e.Position).ToString(),
                to = MailTo
            };
            var Detail1 = JsonConvert.SerializeObject(dt1);

            intent.PutExtra("m1",Detail1);
           
           //intent.PutExtra("selectedItemId",listv.GetItemAtPosition(e.Position).ToString());
           //intent.PutExtra("selectedMail", MailTo);
           
            base.StartActivityForResult(intent , 2412);
        }
    }
}