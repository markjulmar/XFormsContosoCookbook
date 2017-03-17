using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XFormsContosoCookbook.DataModel;

namespace XFormsContosoCookbook
{
	public class App : Application
	{
		private RecipeViewModel _rvm;

		public App()
		{
			this.MainPage = new NavigationPage(new MainPage());
		}

		public async Task<RecipeViewModel> GetRecipeViewModelAsync()
		{
			if (_rvm == null)
			{
				_rvm = new RecipeViewModel();
				await _rvm.LoadRecipesAsync();
			}

			return _rvm;
		}

		protected override void OnStart()
		{
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}
