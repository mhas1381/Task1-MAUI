namespace Task1.pages;

public partial class Tasks : ContentPage
{
	public Tasks()
	{
		InitializeComponent();
	}
    private void OnBackButtonClicked(object sender, EventArgs e)
    {
        Navigation.PushModalAsync(new HomePage());

    }
}