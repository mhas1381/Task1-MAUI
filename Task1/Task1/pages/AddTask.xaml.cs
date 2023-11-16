namespace Task1.pages;
using Microsoft.Maui.Controls;
public partial class AddTask : ContentPage
{
	public AddTask()
	{
		InitializeComponent();
	}
    private void btnShowText_Click(object sender, EventArgs e)
    {
        string userInput = txtInput.Text;
        lblResult.Text = "متن وارد شده: " + userInput;
    }
    private void OnBackButtonClicked(object sender, EventArgs e)
    {
        Navigation.PushModalAsync(new HomePage());

    }
}