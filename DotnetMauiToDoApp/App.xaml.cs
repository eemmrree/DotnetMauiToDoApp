﻿using DotnetMauiToDoApp.Views;

namespace DotnetMauiToDoApp;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

        MainPage = new NavigationPage(new TodoListPage())
        {
            BarTextColor = Color.FromRgb(255, 255, 255)
        };
    }
}
