using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using XFormsContosoCookbook.Components;

namespace XFormsContosoCookbook.DataModel
{
	public class RecipeViewModel
	{
		public Recipe Recipe { get; set; }
		public List<RecipeGroup> RecipeGroups { get; set; }

		public async Task LoadRecipesAsync()
		{
			// Read RecipeData.json from this PCL's DataModel folder
			var name = typeof(RecipeViewModel).AssemblyQualifiedName.Split(',')[1].Trim();
			var assembly = Assembly.Load(new AssemblyName(name));
			var stream = assembly.GetManifestResourceStream(name + ".DataModel.RecipeData.json");

			// Parse the JSON and generate a collection of RecipeGroup objects
			using (var reader = new StreamReader(stream))
			{
				string json = await reader.ReadToEndAsync();
				var obj = new { Groups = new List<RecipeGroup>() };
				var groups = JsonConvert.DeserializeAnonymousType(json, obj);
				this.RecipeGroups = groups.Groups;
			}
		}
	}
}
