using System;
using Microsoft.Maui;
using Microsoft.Maui.Hosting;

namespace CSC_317_Program_3_Idea_Morse_Code_Player;

class Program : MauiApplication
{
	protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();

	static void Main(string[] args)
	{
		var app = new Program();
		app.Run(args);
	}
}
