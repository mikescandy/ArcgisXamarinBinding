using Android.App;
using Android.OS;
using Com.Esri.Android.Map;
using Com.Esri.Android.Map.Bing;

﻿using System;
using Com.Esri.Android.Runtime;

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
			var bingMapLayer = new BingMapsLayer ("ENTER_YOUR_API_KEY",BingMapsLayer.MapStyle.Aerial);
           	var map = FindViewById<MapView> (Resource.Id.mapView);
			map.AddLayer (bingMapLayer);
		}
	}
}