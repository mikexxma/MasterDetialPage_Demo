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
using Xamarin.Forms.Platform.Android.AppCompat;
using System.Reflection;
using Xamarin.Forms;
using MasterDetialPage_MyTest.Droid;

[assembly: ExportRenderer(typeof(MasterDetailPage), typeof(CustomMasterDetailRenderer))]
namespace MasterDetialPage_MyTest.Droid
{
    public class CustomMasterDetailRenderer : MasterDetailPageRenderer
    {
        public override void AddView(Android.Views.View child)
        {
            child.GetType().GetRuntimeProperty("TopPadding").SetValue(child, 0);
            var padding = child.GetType().GetRuntimeProperty("TopPadding").GetValue(child);

            base.AddView(child);
        }
    }
}