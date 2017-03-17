using Android.Widget;
using Xamarin.Forms.Platform.Android;
using Xamarin.Forms;
using XFormsContosoCookbook.Droid;

[assembly: ResolutionGroupName("Xamarin")]
[assembly: ExportEffect(typeof(TrimLabelEffect), "TrimLabelEffect")]

namespace XFormsContosoCookbook.Droid
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
            var label = Control as TextView;
            if (label != null)
            {
                label.LayoutChange += OnAdjustLabel;
            }
        }

        /// <summary>
        /// Called to adjust the label as it changes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnAdjustLabel(object sender, Android.Views.View.LayoutChangeEventArgs e)
        {
            var label = sender as TextView;
            label.Ellipsize = Android.Text.TextUtils.TruncateAt.End;
            label.SetMaxLines((int)((e.Bottom - e.Top) / label.LineHeight));
        }

        /// <summary>
        /// Called when the effect is being removed from the control
        /// </summary>
        protected override void OnDetached()
        {
            var label = Control as TextView;
            if (label != null)
            {
                label.LayoutChange -= OnAdjustLabel;
            }
        }
	}
}