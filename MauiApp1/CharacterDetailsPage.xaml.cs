namespace MauiApp1;

public partial class CharacterDetailsPage : ContentPage
{
	public CharacterDetailsPage(CharacterDetailsViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}