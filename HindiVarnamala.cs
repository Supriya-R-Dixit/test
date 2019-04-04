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

namespace Gurukul_MVP
{
    [Activity(Label = "HindiVarnamala", MainLauncher = false)]
    public class HindiVarnamala : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here

            SetContentView(Resource.Layout.HindiVarnamala);

            Button buttonAam = FindViewById<Button>(Resource.Id.button_Aa);
         Button buttonAinak = FindViewById<Button>(Resource.Id.button_Ai);
            Button buttonGamala = FindViewById<Button>(Resource.Id.button_Ga);
            Button buttonChaata = FindViewById<Button>(Resource.Id.button_cha);
            Button buttonTaala = FindViewById<Button>(Resource.Id.button_Ta);
            Button buttonDus = FindViewById<Button>(Resource.Id.button_Da);
            
             Button buttonBharath = FindViewById<Button>(Resource.Id.button_Bha);
             Button buttonBatak = FindViewById<Button>(Resource.Id.button_Ba);
            Button buttonMatar = FindViewById<Button>(Resource.Id.button_Ma);
             


            buttonAam.Click += (sender, e) =>
             {
                 var intent = new Intent(this, typeof(FlashCards));
                 intent.PutExtra("previous", 2);
                 intent.PutExtra("next", 3);
                 intent.PutExtra("Source", Resource.Drawable.Aam);
                 intent.PutExtra("text", "आम");
                 intent.PutExtra("audio", Resource.Raw.Aam);
                 StartActivity(intent);
             };

          buttonAinak.Click += (sender, e) =>
            {
                var intent = new Intent(this, typeof(FlashCards));
                intent.PutExtra("previous", 3);
                intent.PutExtra("next", 4);
                intent.PutExtra("Source", Resource.Drawable.Ainak);
                intent.PutExtra("text", "ऐनक");
                intent.PutExtra("audio", Resource.Raw.Ainak);
                StartActivity(intent);
            };

             buttonGamala.Click += (sender, e) =>
            {
                var intent = new Intent(this, typeof(FlashCards));
                intent.PutExtra("previous", 4);
                intent.PutExtra("next", 5);
                intent.PutExtra("Source", Resource.Drawable.Gamla);
                intent.PutExtra("text", "ऐनक");
                intent.PutExtra("audio", Resource.Raw.Gamla);
                StartActivity(intent);
            };

           buttonChaata.Click += (sender, e) =>
            {
                var intent = new Intent(this, typeof(FlashCards));
                intent.PutExtra("previous", 5);
                intent.PutExtra("next", 6);
                intent.PutExtra("Source", Resource.Drawable.Chaata);
                intent.PutExtra("text", "ऐनक");
                intent.PutExtra("audio", Resource.Raw.Chaata);
                StartActivity(intent);
            };

              buttonTaala.Click += (sender, e) =>
            {
                var intent = new Intent(this, typeof(FlashCards));
                intent.PutExtra("previous", 6);
                intent.PutExtra("next", 7);
                intent.PutExtra("Source", Resource.Drawable.Taala);
                intent.PutExtra("text", "ऐनक");
                intent.PutExtra("audio", Resource.Raw.Taala);
                StartActivity(intent);
            };


            buttonDus.Click += (sender, e) =>
            {
                var intent = new Intent(this, typeof(FlashCards));
                intent.PutExtra("previous", 7);
                intent.PutExtra("next", 8);
                intent.PutExtra("Source", Resource.Drawable.Dus);
                intent.PutExtra("text", "ऐनक");
                intent.PutExtra("audio", Resource.Raw.Dus);
                StartActivity(intent);
            };

            buttonBatak.Click += (sender, e) =>
            {
                var intent = new Intent(this, typeof(FlashCards));
                intent.PutExtra("previous", 8);
                intent.PutExtra("next", 9);
                intent.PutExtra("Source", Resource.Drawable.Batak);
                intent.PutExtra("text", "ऐनक");
                intent.PutExtra("audio", Resource.Raw.Batakh);
                StartActivity(intent);
            };


            buttonBharath.Click += (sender, e) =>
            {
                var intent = new Intent(this, typeof(FlashCards));
                intent.PutExtra("previous", 9);
                intent.PutExtra("next", 10);
                intent.PutExtra("Source", Resource.Drawable.Bharath);
                intent.PutExtra("text", "ऐनक");
                intent.PutExtra("audio", Resource.Raw.Bharath);
                StartActivity(intent);
            };


            buttonMatar.Click += (sender, e) =>
            {
                var intent = new Intent(this, typeof(FlashCards));
                intent.PutExtra("previous", 10);
                intent.PutExtra("next", 11);
                intent.PutExtra("Source", Resource.Drawable.matar);
                intent.PutExtra("text", "ऐनक");
                intent.PutExtra("audio", Resource.Raw.Matar);
                StartActivity(intent);
            };  




            //  
        }


    }
}