using System;
using System.IO;
using Microsoft.Maui;
using Microsoft.Maui.Controls;

namespace Elite_Code_1_1_3
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}
		async void Mostrarcod(object sender, EventArgs args)
		{
		    var codtxt = cod.Text;
		    codmost.Text=codtxt;
		}
		async void salvararqui(object sender, EventArgs args)
		{
			
			string cod_escr = cod.Text;
			string nome = nomearq.Text;
			var diretorio = System.IO.Path.Combine(Android.App.Application.Context.GetExternalFilesDir(null).AbsolutePath, nome);
			System.IO.File.WriteAllText(diretorio, cod_escr);

			// Mostrar aonde o arquivo foi salvo
			msgsalvo.Text = $"arquivo salvo em {diretorio}";
		}
	}
}