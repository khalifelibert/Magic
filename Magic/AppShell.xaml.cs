﻿namespace Magic;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
        NavigationPage.SetHasNavigationBar(this, false);
    }
}
