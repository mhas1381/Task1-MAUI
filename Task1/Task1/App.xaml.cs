namespace Task1;
using Task1.pages;
public partial class App : Application
{
	public App()
	{
		InitializeComponent();

        MainPage = new NavigationPage(new HomePage());
    }
}
