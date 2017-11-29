using System.Globalization;
using System.Windows;
using System.Windows.Media;

namespace DependencyProperties
{
    public class SimpleLabel : FrameworkElement
    {
        public static readonly DependencyProperty fontSizeProperty;
        public static readonly DependencyProperty textProperty;
        public static readonly DependencyProperty backgroundProperty;
        public static readonly DependencyProperty foregroundProperty;

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

            textProperty = DependencyProperty.Register(
                nameof(Text),
                typeof(string),
                typeof(SimpleLabel),
                new FrameworkPropertyMetadata(
                    string.Empty,
                    FrameworkPropertyMetadataOptions.AffectsMeasure | FrameworkPropertyMetadataOptions.AffectsRender));

            backgroundProperty = DependencyProperty.Register(
                nameof(Background),
                typeof(Brush),
                typeof(SimpleLabel),
                new FrameworkPropertyMetadata(
                    Brushes.LightGray,
                    FrameworkPropertyMetadataOptions.AffectsRender));

            foregroundProperty = DependencyProperty.Register(
                nameof(Foreground),
                typeof(Brush),
                typeof(SimpleLabel),
                new FrameworkPropertyMetadata(
                    Brushes.Black,
                    FrameworkPropertyMetadataOptions.AffectsRender));
        }

        public double FontSize
        {
            get => (double)GetValue(fontSizeProperty);
            set => SetValue(fontSizeProperty, value);
        }
        public string Text
        {
            get => (string)GetValue(textProperty);
            set => SetValue(textProperty, value);
        }
        public Brush Background
        {
            get => (Brush)GetValue(backgroundProperty);
            set => SetValue(backgroundProperty, value);
        }
        public Brush Foreground
        {
            get => (Brush)GetValue(foregroundProperty);
            set => SetValue(foregroundProperty, value);
        }

        private FormattedText GetFormattedText() => new FormattedText(
            textToFormat: Text,
            culture: CultureInfo.InvariantCulture,
            flowDirection: FlowDirection.LeftToRight,
            typeface: new Typeface("Arial"),
            emSize: FontSize,
            foreground: Foreground);

        protected override Size MeasureOverride(Size availableSize)
        {
            var formattedText = GetFormattedText();
            return new Size(formattedText.Width + 5, formattedText.Height + 5);
        }

        protected override void OnRender(DrawingContext drawingContext)
        {
            drawingContext.DrawRectangle(Background, null, new Rect(RenderSize));
            drawingContext.DrawText(GetFormattedText(), new Point(2.5, 2.5));
        }
    }
}
