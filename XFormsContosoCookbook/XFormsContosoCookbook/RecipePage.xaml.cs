using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using XFormsContosoCookbook.DataModel;

namespace XFormsContosoCookbook
{
	public partial class RecipePage : ContentPage
	{
		public RecipePage()
		{
			InitializeComponent();
		}

		protected async override void OnAppearing()
		{
			base.OnAppearing();
			this.BindingContext = (await ((App)Application.Current).GetRecipeViewModelAsync()).Recipe;
		}
	}
}
