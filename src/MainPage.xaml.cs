using System;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Accessibility;

namespace HelloMauiToolkit;

partial class MainPage : ContentPage
{
	readonly ISemanticScreenReader _semanticScreenReader;

	int count = 0;

	public MainPage(ISemanticScreenReader semanticScreenReader)
	{
		InitializeComponent();

		_semanticScreenReader = semanticScreenReader;

		CounterLabel ??= new();
		ClickMeButton ??= new();
	}

	void OnCounterClicked(object sender, EventArgs e)
	{
		count++;
		CounterLabel.Text = $"Current count: {count}";

		_semanticScreenReader.Announce(CounterLabel.Text);
	}
}