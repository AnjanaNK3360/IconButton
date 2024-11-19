using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace HitachiHighTech.LS.GUI
{
    /// <summary>
    /// Follow steps 1a or 1b and then 2 to use this custom control in a XAML file.
    ///
    /// Step 1a) Using this custom control in a XAML file that exists in the current project.
    /// Add this XmlNamespace attribute to the root element of the markup file where it is 
    /// to be used:
    ///
    ///     xmlns:MyNamespace="clr-namespace:HitachiHighTech.LS.GUI"
    ///
    ///
    /// Step 1b) Using this custom control in a XAML file that exists in a different project.
    /// Add this XmlNamespace attribute to the root element of the markup file where it is 
    /// to be used:
    ///
    ///     xmlns:MyNamespace="clr-namespace:HitachiHighTech.LS.GUI;assembly=HitachiHighTech.LS.GUI"
    ///
    /// You will also need to add a project reference from the project where the XAML file lives
    /// to this project and Rebuild to avoid compilation errors:
    ///
    ///     Right click on the target project in the Solution Explorer and
    ///     "Add Reference"->"Projects"->[Select this project]
    ///
    ///
    /// Step 2)
    /// Go ahead and use your control in the XAML file.
    ///
    ///     <MyNamespace:IconButton/>
    ///
    /// </summary>
    public class IconButton : Control
    {
        static IconButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(IconButton), new FrameworkPropertyMetadata(typeof(IconButton)));
        }


        // TextProperty
        public static readonly DependencyProperty TextProperty =
            DependencyProperty.Register(nameof(Text), typeof(string), typeof(IconButton));

        public string Text
        {
            get => (string)GetValue(TextProperty);
            set => SetValue(TextProperty, value);
        }

        //BackgroundProperty
        public  static readonly DependencyProperty ButtonBackgroundProperty =
            DependencyProperty.Register(nameof(ButtonBackground), typeof(Brush), typeof(IconButton),
        new PropertyMetadata(Brushes.LightGray));

        public  Brush ButtonBackground
        {
            get => (Brush)GetValue(ButtonBackgroundProperty);
            set => SetValue(ButtonBackgroundProperty, value);
        }

        //Foreground
        //BackgroundProperty
        public new static readonly DependencyProperty ForegroundProperty =
            DependencyProperty.Register(nameof(Foreground), typeof(Brush), typeof(IconButton),
        new PropertyMetadata(Brushes.Black));

        public new Brush Foreground
        {
            get => (Brush)GetValue(ForegroundProperty);
            set => SetValue(ForegroundProperty, value);
        }

        // Icon Geometry property (for Path Data)
        public static readonly DependencyProperty IconGeometryProperty =
            DependencyProperty.Register(nameof(IconGeometry), typeof(Geometry), typeof(IconButton));

        public Geometry IconGeometry
        {
            get => (Geometry)GetValue(IconGeometryProperty);
            set => SetValue(IconGeometryProperty, value);
        }

        // IconFill property
        public static readonly DependencyProperty IconFillProperty =
            DependencyProperty.Register(nameof(IconFill), typeof(Brush), typeof(IconButton),
                new PropertyMetadata(Brushes.Black));

        public Brush IconFill
        {
            get => (Brush)GetValue(IconFillProperty);
            set => SetValue(IconFillProperty, value);
        }

        //HoverBackgroundProperty
        public static readonly DependencyProperty HoverBackgroundProperty =
            DependencyProperty.Register(nameof(HoverBackground), typeof(Brush), typeof(IconButton),
                new PropertyMetadata(Brushes.DarkBlue));

        public Brush HoverBackground
        {
            get => (Brush)GetValue(HoverBackgroundProperty);
            set => SetValue(HoverBackgroundProperty, value);
        }

        //PressedBackgroundProperty
        public static readonly DependencyProperty PressedBackgroundProperty =
            DependencyProperty.Register(nameof(PressedBackground), typeof(Brush), typeof(IconButton),
                new PropertyMetadata(Brushes.Red));

        public Brush PressedBackground
        {
            get => (Brush)GetValue(PressedBackgroundProperty);
            set => SetValue(PressedBackgroundProperty, value);
        }



        // Icon Stroke property
        public static readonly DependencyProperty IconStrokeProperty =
            DependencyProperty.Register(nameof(IconStroke), typeof(Brush), typeof(IconButton),
                new PropertyMetadata(Brushes.Black));
        public Brush IconStroke
        {
            get => (Brush)GetValue(IconStrokeProperty);
            set => SetValue(IconStrokeProperty, value);
        }

        // StrokeThickness property
        public static readonly DependencyProperty StrokeThicknessProperty =
            DependencyProperty.Register(nameof(StrokeThickness), typeof(double), typeof(IconButton),
                new PropertyMetadata(1.0));

        public double StrokeThickness
        {
            get => (double)GetValue(StrokeThicknessProperty);
            set => SetValue(StrokeThicknessProperty, value);
        }

        // Corner Radius property
        public static readonly DependencyProperty CornerRadiusProperty =
            DependencyProperty.Register(nameof(CornerRadius), typeof(CornerRadius), typeof(IconButton));

        public CornerRadius CornerRadius
        {
            get => (CornerRadius)GetValue(CornerRadiusProperty);
            set => SetValue(CornerRadiusProperty, value);
        }

        // Icon Alignment property (enum)
        public static readonly DependencyProperty IconAlignmentProperty =
            DependencyProperty.Register(nameof(IconAlignment), typeof(IconAlignment), typeof(IconButton),
                new PropertyMetadata(IconAlignment.IconOnLeft));

        public IconAlignment IconAlignment
        {
            get => (IconAlignment)GetValue(IconAlignmentProperty);
            set => SetValue(IconAlignmentProperty, value);
        }

        //IsMouseDown Property
        public static readonly DependencyProperty IsMouseDownProperty =
            DependencyProperty.Register(nameof(IsMouseDown), typeof(bool), typeof(IconButton),
                new PropertyMetadata(false));

        public bool IsMouseDown
        {
            get => (bool)GetValue(IsMouseDownProperty);
            set => SetValue(IsMouseDownProperty, value);
        }

        //Command property
        public static  readonly DependencyProperty ControlCommandProperty =
            DependencyProperty.Register(nameof(ControlCommand), typeof(ICommand), typeof(IconButton));

        public  ICommand ControlCommand
        {
            get { return (ICommand)GetValue(ControlCommandProperty); }
            set { SetValue(ControlCommandProperty, value); }
        }

        // Command Parameter Property
        public static readonly DependencyProperty CommandParameterProperty =
            DependencyProperty.Register(nameof(CommandParameter), typeof(object), typeof(IconButton), new PropertyMetadata(null));

        public object CommandParameter
        {
            get => GetValue(CommandParameterProperty);
            set => SetValue(CommandParameterProperty, value);
        }


        protected override void OnMouseDown(MouseButtonEventArgs e)
        {
            base.OnMouseDown(e);
            IsMouseDown = true;


            if (ControlCommand != null && ControlCommand.CanExecute(CommandParameter))
            {
                ControlCommand.Execute(CommandParameter);
            }


        }
        protected override void OnMouseUp(MouseButtonEventArgs e)
        {
            base.OnMouseUp(e);
            IsMouseDown = false;

            //CoerceValue(IsMouseDownProperty);
        }



    }

    public enum IconAlignment
    {
        IconOnTop,
        IconOnLeft
    }

}
