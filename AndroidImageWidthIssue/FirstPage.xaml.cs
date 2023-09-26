namespace AndroidImageWidthIssue;

public partial class FirstPage : ContentPage
{
	public FirstPage()
	{
		InitializeComponent();
	}

    void Button_Clicked(System.Object sender, System.EventArgs e)
    {
		Shell.Current.GoToAsync("MainViewModel");
    }
}
