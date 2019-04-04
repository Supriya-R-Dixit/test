using System;
using Android;
using Android.Content;
using Android.Graphics;
using Android.Runtime;
using Android.Util;
using Android.Widget;

public class HindiTextView : TextView
{
    public HindiTextView(Context context) : base(context)
    {
        InitTypeface(context);
    }

    public HindiTextView(Context context, IAttributeSet attrs) : base(context, attrs)
    {
        InitTypeface(context);
    }

    public HindiTextView(Context context, IAttributeSet attrs, int defStyleAttr) : base(context, attrs, defStyleAttr)
    {
        InitTypeface(context);
    }

    public HindiTextView(Context context, IAttributeSet attrs, int defStyleAttr, int defStyleRes) : base(context, attrs, defStyleAttr, defStyleRes)
    {
        InitTypeface(context);
    }

    protected HindiTextView(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
    {
        
    }

    private void InitTypeface(Context context)
    {
        //Typeface typeface = Typeface.CreateFromAsset(Context.Assets, "/assets/DevLys010Normal.ttf");

        //TextView textforAam = FindViewById<TextView>(2131034112);
            
        //textforAam.SetTypeface(typeface, TypefaceStyle.Bold);



    }
}