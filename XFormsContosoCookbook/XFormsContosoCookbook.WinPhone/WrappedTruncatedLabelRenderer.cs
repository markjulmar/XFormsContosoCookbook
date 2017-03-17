using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Platform.WinPhone;
using XFormsContosoCookbook.WinPhone;
using XFormsContosoCookbook.Components;

[assembly: ExportRenderer(typeof(WrappedTruncatedLabel), typeof(WrappedTruncatedLabelRenderer))]
namespace XFormsContosoCookbook.WinPhone
{
	public class WrappedTruncatedLabelRenderer : LabelRenderer
	{
		protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
		{
			base.OnElementChanged(e);

			if (Control != null)
			{
				Control.TextWrapping = System.Windows.TextWrapping.Wrap;
				Control.TextTrimming = System.Windows.TextTrimming.WordEllipsis;

				Control.Loaded += (s, args) =>
				{
					var parent = Control.Parent as WrappedTruncatedLabelRenderer;

					if (parent != null)
					{
						var grid = new System.Windows.Controls.Grid();
						parent.Children.Remove(Control);
						parent.Children.Add(grid);
						grid.Children.Add(Control);
					}
				};
			}
		}
	}
}
