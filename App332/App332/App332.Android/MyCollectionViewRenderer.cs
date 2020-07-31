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
using Xamarin.Forms.Platform.Android;

using Xamarin.Forms;
using App332.Droid;

[assembly: ExportRenderer(typeof(Xamarin.Forms.CollectionView), typeof(MyCollectionViewRenderer))]

namespace App332.Droid
{
    class MyCollectionViewRenderer : CollectionViewRenderer
    {
        public MyCollectionViewRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<ItemsView> elementChangedEvent)
        {
            base.OnElementChanged(elementChangedEvent);

            this.ScrollbarFadingEnabled = false;
        }
    }
}