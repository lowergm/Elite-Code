using System;
using System.IO;
using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Graphics;
using Microsoft.Maui.Hosting;

namespace Elite_Code_1_1_7
{
	public partial class MainPage : TabbedPage
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
		
		async void Temamudar(object sender, EventArgs args)
		{	
			if (tema.Text=="Dark")
			{	
				tema.Text = "Light";
				arquivos.Content.BackgroundColor = Microsoft.Maui.Graphics.Color.FromHex("#e8e6e6");
				pagecod.Content.BackgroundColor = Microsoft.Maui.Graphics.Color.FromHex("#e8e6e6");
				config.Content.BackgroundColor = Microsoft.Maui.Graphics.Color.FromHex("#e8e6e6");
			}
			else
			{
				tema.Text = "Dark";
				arquivos.Content.BackgroundColor = Microsoft.Maui.Graphics.Color.FromHex("#262626");
				pagecod.Content.BackgroundColor = Microsoft.Maui.Graphics.Color.FromHex("#262626");
			    config.Content.BackgroundColor = Microsoft.Maui.Graphics.Color.FromHex("#262626");
			}
		}
        
		async void Ling(object sender, EventArgs args)
		{
			string linguagem = lang.Text;
			string langMin = linguagem.ToLower();
			if (langMin=="csharp")
			{
				cod.TextColor=Microsoft.Maui.Graphics.Colors.Purple;
			}
			else if (langMin=="c#")
			{
				cod.TextColor=Microsoft.Maui.Graphics.Colors.Purple;
			}
			else if (langMin=="cs")
			{
				cod.TextColor=Microsoft.Maui.Graphics.Colors.Purple;
			}
			else if (langMin=="python")
			{
				cod.TextColor=Microsoft.Maui.Graphics.Colors.Yellow;
			}
			else if (langMin=="py")
			{
				cod.TextColor=Microsoft.Maui.Graphics.Colors.Yellow;
			}
			else if (langMin=="ruby")
			{
				cod.TextColor=Microsoft.Maui.Graphics.Colors.Red;
			}
			else if (langMin=="rb")
			{
				cod.TextColor=Microsoft.Maui.Graphics.Colors.Red;
			}
			else if (langMin=="cpp")
			{
				cod.TextColor=Microsoft.Maui.Graphics.Colors.Blue;
			}
			else if (langMin=="c++")
			{
				cod.TextColor=Microsoft.Maui.Graphics.Colors.Blue;
			}
			else if (langMin=="cplusplus")
			{
				cod.TextColor=Microsoft.Maui.Graphics.Colors.Blue;
			}
			else if (langMin=="java")
			{
				cod.TextColor=Microsoft.Maui.Graphics.Colors.SaddleBrown;
			}
			else if (langMin=="javascript")
			{
				cod.TextColor=Microsoft.Maui.Graphics.Colors.Orange;
			}
			else if (langMin=="js")
			{
				cod.TextColor=Microsoft.Maui.Graphics.Colors.Orange;
			}
			
			codmost.TextColor=cod.TextColor;
		}
	}
}
