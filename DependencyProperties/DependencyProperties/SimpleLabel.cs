using System.Windows;

namespace DependencyProperties
{
    public class SimpleLabel : FrameworkElement
    {
        public static readonly DependencyProperty fontSizeProperty;

        static SimpleLabel()
        {
            var meta = new FrameworkPropertyMetadata(
                defaultValue: 11.0,
                flags: FrameworkPropertyMetadataOptions.AffectsMeasure | FrameworkPropertyMetadataOptions.AffectsRender);

            fontSizeProperty = DependencyProperty.Register(
                name: nameof(FontSize),
                propertyType: typeof(double),
                ownerType: typeof(SimpleLabel),
                typeMetadata: meta,
                validateValueCallback: v => (double)v > 1);
        }

        public double FontSize
        {
            get => (double)GetValue(fontSizeProperty);
            set => SetValue(fontSizeProperty, value);
        }
    }
}
