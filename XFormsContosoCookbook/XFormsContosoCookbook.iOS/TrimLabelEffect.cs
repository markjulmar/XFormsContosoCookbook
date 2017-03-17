using UIKit;
using Xamarin.Forms.Platform.iOS;
using Xamarin.Forms;
using XFormsContosoCookbook.iOS;

[assembly: ResolutionGroupName("Xamarin")]
[assembly: ExportEffect(typeof(TrimLabelEffect), "TrimLabelEffect")]

namespace XFormsContosoCookbook.iOS
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
            var label = Control as UILabel;
            if (label != null)
            {
                label.LineBreakMode = UILineBreakMode.TailTruncation;
                label.Lines = 0;
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