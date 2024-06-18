using System;
using System.IO;
using Microsoft.Maui;
using Microsoft.Maui.Controls;

namespace Elite_Code_1_1_3
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();
			MainPage = new AppShell();
		}
	}
}