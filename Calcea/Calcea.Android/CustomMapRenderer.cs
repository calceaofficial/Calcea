﻿using System.Collections.Generic;
using System.ComponentModel;
using Android.Content;
using Android.Gms.Maps;
using Android.Gms.Maps.Model;
using Calcea.Droid;
using Calcea.Views;
using Xamarin.Forms;
using Xamarin.Forms.Maps;
using Xamarin.Forms.Maps.Android;

[assembly: ExportRenderer(typeof(MapsView), typeof(CustomMapRenderer))]
namespace Calcea.Droid
{
	public class CustomMapRenderer : MapRenderer
	{
		List<Position> routeCoordinates;

		public CustomMapRenderer(Context context) : base(context)
		{
		}
		
		protected override void OnElementChanged(Xamarin.Forms.Platform.Android.ElementChangedEventArgs<Map> e)
		{
			base.OnElementChanged(e);

			if (e.OldElement != null)
			{
				// Unsubscribe
			}

			if (e.NewElement != null)
			{
				var formsMap = (MapsView)e.NewElement;
				routeCoordinates = formsMap.RouteCoordinates;
				Control.GetMapAsync(this);
			}
		}

		protected override void OnMapReady(Android.Gms.Maps.GoogleMap map)
		{
			base.OnMapReady(map);

			var polylineOptions = new PolylineOptions();
			polylineOptions.InvokeColor(0x66FF0000);

			foreach (var position in routeCoordinates)
			{
				polylineOptions.Add(new LatLng(position.Latitude, position.Longitude));
			}

			NativeMap.AddPolyline(polylineOptions);
			NativeMap.UiSettings.ZoomControlsEnabled = false;
			NativeMap.UiSettings.ZoomGesturesEnabled = true;
			NativeMap.UiSettings.MyLocationButtonEnabled = false;
			NativeMap.UiSettings.RotateGesturesEnabled = false;
		}
	}
}
