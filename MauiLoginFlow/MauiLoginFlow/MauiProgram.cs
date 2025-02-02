﻿using Microsoft.Extensions.Logging;
using MauiLoginFlow.Services;
using MauiLoginFlow.Pages;
namespace MauiLoginFlow;

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
        builder.Services.AddTransient<AuthService>();
        builder.Services.AddTransient<LoadingPage>();
        builder.Services.AddTransient<LoginPage>();
        builder.Services.AddTransient<ProfilePage>();
        builder.Services.AddTransient<RegisterPage>();
        return builder.Build();
	}
}
