namespace Task1.pages;

public partial class HomePage : ContentPage
{
	public HomePage()
	{
		InitializeComponent();
	}
    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new AddTask());

    }
    private async void Button_Clicked1(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new Tasks());

    }
}