﻿namespace NEO_Engine;

public partial class MainPage : ContentPage
{
	//int count = 0;

	public MainPage()
	{
		InitializeComponent();
    }

	/*
	private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;

		if (count == 1)
			CounterBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";

		SemanticScreenReader.Announce(CounterBtn.Text);
	}
	*/

    private void Main_ui_SizeChanged(object sender, EventArgs e)
    {
        double height = main_ui.Height;
        double width = main_ui.Width;

		if (height > width)
		{
            //縦UI
            image_desigin.HorizontalOptions = LayoutOptions.Center;
            image_desigin.VerticalOptions = LayoutOptions.Start;

            vertical_desigin.IsVisible = false;
            horizontal_desigin.IsVisible = true;

            //画像サイズ
            image.HeightRequest = width - 40;
            image.WidthRequest = width - 40;
        }
		else
		{
            //横UI
            image_desigin.HorizontalOptions = LayoutOptions.Start;
            image_desigin.VerticalOptions = LayoutOptions.Center;

            vertical_desigin.IsVisible = true;
            horizontal_desigin.IsVisible = false;

            //画像サイズ
            image.HeightRequest = height - 40;
            image.WidthRequest = height - 40;
        }

        //携帯向け設定
        if (width > 600)
        {
            button1x.WidthRequest = 250;
            button4x.WidthRequest = 250;
        }
        else
        {
            button1x.WidthRequest = 180;
            button4x.WidthRequest = 180;
        }

        //携帯向け設定
        if (height > 400)
        {
            button1.HeightRequest = 46;
            button2.HeightRequest = 46;
            button3.HeightRequest = 46;
            button4.HeightRequest = 46;
            button5.HeightRequest = 46;
            button6.HeightRequest = 46;

            //button1のMarginは0,0,0,0なので変更しない
            button2.Margin = new Thickness(0,20,0,0);
            button3.Margin = new Thickness(0,20,0,0);
            button4.Margin = new Thickness(0,20,0,0);
            button5.Margin = new Thickness(0,20,0,0);
            button6.Margin = new Thickness(0,20,0,0);
        }
        else
        {
            button1.HeightRequest = 42;
            button2.HeightRequest = 42;
            button3.HeightRequest = 42;
            button4.HeightRequest = 42;
            button5.HeightRequest = 42;
            button6.HeightRequest = 42;

            //button1のMarginは0,0,0,0なので変更しない
            button2.Margin = new Thickness(0, 8, 0, 0);
            button3.Margin = new Thickness(0, 8, 0, 0);
            button4.Margin = new Thickness(0, 8, 0, 0);
            button5.Margin = new Thickness(0, 8, 0, 0);
            button6.Margin = new Thickness(0, 8, 0, 0);
        }
    }
}
