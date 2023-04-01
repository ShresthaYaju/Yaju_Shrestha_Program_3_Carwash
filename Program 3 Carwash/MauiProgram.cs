/*
 * Author: Yaju Shrestha
 * Assignment: Car Wash 
 * Description: This program is simulating an app that calculates the total amount a customer has to pay when selecting a program and add ons at LENNYS CAR WASH.
 * 
 * 

 
 */
using Microsoft.Extensions.Logging;

namespace Program_3_Carwash;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
