using Xamarin.Forms;
using Xamarin.Forms.Platform.UWP;
using XFormsContosoCookbook.UWP;
using Windows.UI.Xaml;

[assembly: ResolutionGroupName("Xamarin")]
[assembly: ExportEffect(typeof(TrimLabelEffect), "TrimLabelEffect")]

namespace XFormsContosoCookbook.UWP
{
    /// <summary>
    /// Effect to wrap/trim a label.
    /// </summary>
    public class TrimLabelEffect : PlatformEffect
    {
        /// <summary>
        /// Called after the effect is attached and made valid.
        /// </summary>
        protected override void OnAttached()
        {
            var label = Control as Windows.UI.Xaml.Controls.TextBlock;
            if (label != null)
            {
                label.TextWrapping = TextWrapping.Wrap;
                label.TextTrimming = TextTrimming.WordEllipsis;
            }
        }

        /// <summary>
        /// Called when the effect is being removed from the control
        /// </summary>
        protected override void OnDetached()
        {
        }
    }
}
