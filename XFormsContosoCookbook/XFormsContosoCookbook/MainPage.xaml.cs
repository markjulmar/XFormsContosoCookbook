using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using XFormsContosoCookbook.DataModel;

namespace XFormsContosoCookbook
{
	public partial class MainPage : TabbedPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

		protected async override void OnAppearing()
		{
			base.OnAppearing();

			if (this.BindingContext == null)
				this.BindingContext = await ((App)Application.Current).GetRecipeViewModelAsync();
		}

		private async void OnItemTapped(object sender, ItemTappedEventArgs args)
		{
			((RecipeViewModel)this.BindingContext).Recipe = (Recipe)args.Item;
			await this.Navigation.PushAsync(new RecipePage());
		}
	}
}
