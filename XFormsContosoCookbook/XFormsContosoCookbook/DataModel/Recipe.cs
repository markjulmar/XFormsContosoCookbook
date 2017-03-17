using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XFormsContosoCookbook.DataModel
{
	public class Recipe
	{
		[JsonProperty("UniqueId")]
		public string ID { get; set; }
		public string Title { get; set; }
		public string Subtitle { get; set; }
        public string Description { get; set; }
		public string ImagePath { get; set; }
		public string TileImagePath { get; set; }
		public int PrepTime { get; set; }
		public string Directions { get; set; }
		public List<string> Ingredients { get; set; }
	}
}
