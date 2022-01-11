using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp17
{
    /// <summary>
    /// Логика взаимодействия для Colorused.xaml
    /// </summary>
    public partial class Colorused : UserControl
    {
        public static readonly DependencyProperty RedProperty=
            DependencyProperty.Register(
                nameof(Red),
                typeof(byte),
                typeof(Colorused),
                new FrameworkPropertyMetadata(
                    new PropertyChangedCallback(OnColorRGBChanged)));
        public static readonly DependencyProperty GreenProperty=
            DependencyProperty.Register(
                nameof(Green),
                typeof(byte),
                typeof(Colorused),
                new FrameworkPropertyMetadata(
                    new PropertyChangedCallback(OnColorRGBChanged)));
        public static readonly DependencyProperty BlueProperty=
            DependencyProperty.Register(
                nameof(Blue),
                typeof(byte),
                typeof(Colorused),
                 new FrameworkPropertyMetadata(
                     new PropertyChangedCallback(OnColorRGBChanged)));

        private static void OnColorRGBChanged(DependencyObject sender, DependencyPropertyChangedEventArgs e)
        {
            Colorused slidercolorPicker = (Colorused)sender;
            Color color = slidercolorPicker.Color;
            if (e.Property == RedProperty)
                color.R = (byte)e.NewValue;
            else if (e.Property == GreenProperty)
                color.G = (byte)e.NewValue;
            else if (e.Property == BlueProperty)
                color.B = (byte)e.NewValue;

            slidercolorPicker.Color = color;
        }

        public static readonly DependencyProperty ColorProperty =
    DependencyProperty.Register(
        nameof(Color),
        typeof(Color),
        typeof(Colorused),
        new FrameworkPropertyMetadata(
            Colors.Black,
            new PropertyChangedCallback(OnColorChanged)));

        private static void OnColorChanged(DependencyObject sender,
       DependencyPropertyChangedEventArgs e)
        {
            Color newColor = (Color)e.NewValue;
            Colorused colorpicker = (Colorused)sender;
            colorpicker.Red = newColor.R;
            colorpicker.Green = newColor.G;
            colorpicker.Blue = newColor.B;
        }
        public Color Color
        {
            get { return (Color)GetValue(ColorProperty); }
            set { SetValue(ColorProperty, value); }
        }
        public byte Red
        {
            get { return (byte)GetValue(RedProperty); }
            set { SetValue(RedProperty, value); }
        }
        public byte Green
        {
            get { return (byte)GetValue(GreenProperty); }
            set { SetValue(GreenProperty, value); }
        }
        public byte Blue
        {
            get { return (byte)GetValue(BlueProperty); }
            set { SetValue(BlueProperty, value); }
        }
        public Colorused()
        {
            InitializeComponent();
        }
    }
}
