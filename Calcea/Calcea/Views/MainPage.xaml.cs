﻿using Calcea.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Calcea.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MainPage : MasterDetailPage
	{
		Dictionary<int, NavigationPage> MenuPages = new Dictionary<int, NavigationPage>();
		public MainPage()
		{
			InitializeComponent();

			MasterBehavior = MasterBehavior.Popover;

			MenuPages.Add((int)MenuItemType.Browse, (NavigationPage)Detail);
		}

		public async Task NavigateFromMenu(int id)
		{
			if (!MenuPages.ContainsKey(id))
			{
				switch (id)
				{
					case (int)MenuItemType.Browse:
						MenuPages.Add(id, new NavigationPage(new HomePage()));
						break;
					case (int)MenuItemType.Schemas:
						MenuPages.Add(id, new NavigationPage(new SchemasPage()));
						break;
					case (int)MenuItemType.Maps:
						MenuPages.Add(id, new NavigationPage(new MapsPage()));
						break;
					case (int)MenuItemType.About:
						MenuPages.Add(id, new NavigationPage(new AboutPage()));
						break;
				}
			}

			var newPage = MenuPages[id];

			if (newPage != null && Detail != newPage)
			{
				Detail = newPage;

				if (Device.RuntimePlatform == Device.Android)
					await Task.Delay(100);

				IsPresented = false;
			}
		}
	}
}