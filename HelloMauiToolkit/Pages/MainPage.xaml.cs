using System;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Accessibility;

namespace HelloMauiToolkit;

partial class MainPage : ContentPage
{
	readonly ISemanticScreenReader _semanticScreenReader;

	int _count = 0;

	public MainPage(ISemanticScreenReader semanticScreenReader)
	{
		InitializeComponent();

		_semanticScreenReader = semanticScreenReader;
	}

	void OnCounterClicked(object sender, EventArgs e)
	{
		_count++;
		CounterLabel.Text = $"Current count: {_count}";

		_semanticScreenReader.Announce(CounterLabel.Text);
	}
}