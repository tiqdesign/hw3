using System.Collections.Generic;
using System.Net;
using System.Runtime.InteropServices.ComTypes;
using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Support.V7.Widget;
using Android.Views;
using Android.Widget;
using Java.Util;

namespace AndroidCeng
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        private FragmentManager fm;
        private Mail mail;
        private System.Collections.Generic.Dictionary<int, int> dict;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.kisiler1);

            var image1 = FindViewById<ImageView>(Resource.Id.ımageView11);
            var imageBitmap = GetImageBitmapFromUrl("http://ceng.eskisehir.edu.tr/img/aarslan2.jpg");
            image1.SetImageBitmap(imageBitmap);

            var image2 = FindViewById<ImageView>(Resource.Id.ımageView12);
            var imageBitmap2 = GetImageBitmapFromUrl("http://ceng.eskisehir.edu.tr/img/yhoscan.jpg");
            image2.SetImageBitmap(imageBitmap2);

            var image3 = FindViewById<ImageView>(Resource.Id.ımageView13);
            var imageBitmap3 = GetImageBitmapFromUrl("http://ceng.eskisehir.edu.tr/img/serkangunal.jpg");
            image3.SetImageBitmap(imageBitmap3);

            var image4 = FindViewById<ImageView>(Resource.Id.ımageView14);
            var imageBitmap4 = GetImageBitmapFromUrl("http://ceng.eskisehir.edu.tr/img/ckaleli.jpg");
            image4.SetImageBitmap(imageBitmap4);

            var image5 = FindViewById<ImageView>(Resource.Id.ımageView15);
            var imageBitmap5 = GetImageBitmapFromUrl("http://ceng.eskisehir.edu.tr/img/akuysal.jpg");
            image5.SetImageBitmap(imageBitmap5);

            var image6 = FindViewById<ImageView>(Resource.Id.ımageView16);
            var imageBitmap6 = GetImageBitmapFromUrl("http://ceng.eskisehir.edu.tr/img/abilge.png");
            image6.SetImageBitmap(imageBitmap6);

            var image7 = FindViewById<ImageView>(Resource.Id.ımageView17);
            var imageBitmap7 = GetImageBitmapFromUrl("http://ceng.eskisehir.edu.tr/img/sevcany.jpg");
            image7.SetImageBitmap(imageBitmap7);

            var image8 = FindViewById<ImageView>(Resource.Id.ımageView18);
            var imageBitmap8 = GetImageBitmapFromUrl("http://ceng.eskisehir.edu.tr/img/byurekli.jpg");
            image8.SetImageBitmap(imageBitmap8);

            var image9 = FindViewById<ImageView>(Resource.Id.ımageView19);
            var imageBitmap9 = GetImageBitmapFromUrl("http://ceng.eskisehir.edu.tr/img/oozsen.jpg");
            image9.SetImageBitmap(imageBitmap9);

            var image10 = FindViewById<ImageView>(Resource.Id.ımageView20);
            var imageBitmap10 = GetImageBitmapFromUrl("http://ceng.eskisehir.edu.tr/img/ekacmaz.jpg");
            image10.SetImageBitmap(imageBitmap10);

            var image11 = FindViewById<ImageView>(Resource.Id.ımageView21);
            var imageBitmap11 = GetImageBitmapFromUrl("http://ceng.eskisehir.edu.tr/img/roaltug.jpeg");
            image11.SetImageBitmap(imageBitmap11);

            var image12 = FindViewById<ImageView>(Resource.Id.ımageView22);
            var imageBitmap12 = GetImageBitmapFromUrl("http://ceng.eskisehir.edu.tr/img/ayargic.jpg");
            image12.SetImageBitmap(imageBitmap12);

            fm = this.FragmentManager;
            

            var bt1 = FindViewById<Button>(Resource.Id.button1);
            var bt2 = FindViewById<Button>(Resource.Id.button13);
            var bt3 = FindViewById<Button>(Resource.Id.button33);
            var bt4 = FindViewById<Button>(Resource.Id.button43);
            var bt5 = FindViewById<Button>(Resource.Id.button53);
            var bt6 = FindViewById<Button>(Resource.Id.button63);
            var bt7 = FindViewById<Button>(Resource.Id.button73);
            var bt8 = FindViewById<Button>(Resource.Id.button83);
            var bt9 = FindViewById<Button>(Resource.Id.button93);
            var bt10 = FindViewById<Button>(Resource.Id.button193);
            var bt11 = FindViewById<Button>(Resource.Id.button123);
            var bt12 = FindViewById<Button>(Resource.Id.button173);

            var textTo1 = FindViewById<TextView>(Resource.Id.textView10);
            var textTo2 = FindViewById<TextView>(Resource.Id.textView20);
            var textTo3 = FindViewById<TextView>(Resource.Id.textView30);
            var textTo4 = FindViewById<TextView>(Resource.Id.textView40);
            var textTo5 = FindViewById<TextView>(Resource.Id.textView50);
            var textTo6 = FindViewById<TextView>(Resource.Id.textView60);
            var textTo7 = FindViewById<TextView>(Resource.Id.textView70);
            var textTo8 = FindViewById<TextView>(Resource.Id.textView80);
            var textTo9 = FindViewById<TextView>(Resource.Id.textView90);
            var textTo10 = FindViewById<TextView>(Resource.Id.textView190);
            var textTo11 = FindViewById<TextView>(Resource.Id.textView191);
            var textTo12 = FindViewById<TextView>(Resource.Id.textView173);



            bt1.Click += btn_popup;
            bt2.Click += btn_popup;
            bt3.Click += btn_popup;
            bt4.Click += btn_popup;
            bt5.Click += btn_popup;
            bt6.Click += btn_popup;
            bt7.Click += btn_popup;
            bt8.Click += btn_popup;
            bt9.Click += btn_popup;
            bt10.Click += btn_popup;
            bt11.Click += btn_popup;
            bt12.Click += btn_popup;

            dict = new Dictionary<int,int>();
            dict.Add(bt1.Id,textTo1.Id);
            dict.Add(bt2.Id, textTo2.Id);
            dict.Add(bt3.Id, textTo3.Id);
            dict.Add(bt4.Id, textTo4.Id);
            dict.Add(bt5.Id, textTo5.Id);
            dict.Add(bt6.Id, textTo6.Id);
            dict.Add(bt7.Id, textTo7.Id);
            dict.Add(bt8.Id, textTo8.Id);
            dict.Add(bt9.Id, textTo9.Id);
            dict.Add(bt10.Id, textTo10.Id);
            dict.Add(bt11.Id, textTo11.Id);
            dict.Add(bt12.Id, textTo12.Id);
            
        }

        

        private Bitmap GetImageBitmapFromUrl(string url)
        {
            Bitmap imageBitmap = null;

            using (var webClient = new WebClient())
            {
                var imageBytes = webClient.DownloadData(url);
                if (imageBytes != null && imageBytes.Length > 0)
                {
                    imageBitmap = BitmapFactory.DecodeByteArray(imageBytes, 0, imageBytes.Length);
                }
            }

            return imageBitmap;
        }

        
        public void btn_popup(object sender, System.EventArgs e)
        {
            Button btnDefault = (Button) sender as Button;
            int textId = dict[btnDefault.Id];
            TextView tvDefault = FindViewById<TextView>(textId);
            string dataForTo = tvDefault.Text;
            
            mail = new Mail(dataForTo);

            mail.Show(fm, dataForTo);
          }
    }
}