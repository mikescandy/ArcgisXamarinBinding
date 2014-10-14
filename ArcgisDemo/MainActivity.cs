using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Com.Esri.Android.Map;
using Com.Esri.Android.Map.Bing;
using Com.Esri.Android.Map.Popup;

namespace ArcgisDemo
{
	[Activity (Label = "ArcgisDemo", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			var map = FindViewById<MapView> (Resource.Id.mapView);
			var bingMapLayer = new BingMapsLayer ("ENTER_YOUR_API_KEY",BingMapsLayer.MapStyle.Aerial);
			map.AddLayer (bingMapLayer);

		    var a = new ArcGISMediaAdapter(this, null);
		    a.GetItem(1);
		}
	}
}


