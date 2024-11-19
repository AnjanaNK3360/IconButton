using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HitachiHighTech.LS.GUI;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows;

namespace IconButtonTestApp
{
    public class ButtonViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void onPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        private readonly ButtonModel _buttonModel;


        public Geometry IconGeometry
        {
            get => _buttonModel.IconGeometry;
            set
            {
                _buttonModel.IconGeometry = value;
                onPropertyChanged(nameof(IconGeometry));
            }
        }

        public string Text
        {
            get => _buttonModel.Text;
            set
            {
                _buttonModel.Text = value;
                onPropertyChanged(nameof(Text));
            }
        }

        public Brush ButtonBackground
        {
            get => _buttonModel.ButtonBackground;
            set
            {
                _buttonModel.ButtonBackground = value;
                onPropertyChanged(nameof(ButtonBackground));
            }
        }

        public Brush Foreground
        {
            get => _buttonModel.Foreground;
            set
            {
                _buttonModel.Foreground = value;
                onPropertyChanged(nameof(Foreground));
            }
        }

        public Brush IconFill
        {
            get => _buttonModel.IconFill;
            set
            {
                _buttonModel.IconFill = value;
                onPropertyChanged(nameof(IconFill));
            }
        }

        public Brush IconStroke
        {
            get => _buttonModel.IconStroke;
            set
            {
                _buttonModel.IconStroke = value;
                onPropertyChanged(nameof(IconStroke));
            }
        }

        public CornerRadius CornerRadius
        {
            get => _buttonModel.CornerRadius;
            set
            {
                _buttonModel.CornerRadius = value;
                onPropertyChanged(nameof(CornerRadius));
            }
        }

        public double Radius
        {
            get { return _buttonModel.CornerRadius.TopLeft; }
            set
            {
                CornerRadius = new CornerRadius(value);
            }
        }

        public double FontSize
        {
            get => _buttonModel.FontSize;
            set
            {
                _buttonModel.FontSize = value;
                onPropertyChanged(nameof(FontSize));
            }
        }

        public IconAlignment IconAlignment
        {
            get => _buttonModel.IconAlignment;
            set
            {
                _buttonModel.IconAlignment = value;
                onPropertyChanged(nameof(IconAlignment));
            }
        }

        public double StrokeThickness
        {
            get => _buttonModel.StrokeThickness;
            set
            {
                _buttonModel.StrokeThickness = value;
                onPropertyChanged(nameof(StrokeThickness));
            }
        }


        public ICommand ButtonCommand { get; }

        public ButtonViewModel()
        {
            ButtonCommand = new CustomCommand(DisplayMessage);
            _buttonModel = new ButtonModel
            {

                IconGeometry = Geometry.Parse("M10,10 L90,10 L90,50 L10,50 Z"), // Example rectangle geometry
                Text = "Test Button",
                ButtonBackground = Brushes.LightGray,
                Foreground = Brushes.Black,
                IconFill = Brushes.Black,
                IconStroke = Brushes.Black,
                CornerRadius = new CornerRadius(5),
                FontSize = 14,
                IconAlignment = IconAlignment.IconOnTop,
                StrokeThickness = 2.0,
            };
            // Initialize the command
            //ButtonCommand = new RelayCommand(OnButtonClicked);
            

        }

        private void DisplayMessage(object parameter)
        {
           
            MessageBox.Show("IconButton clicked! Parameter: " + parameter);

        }

        //private void OnButtonClicked()
        //{
        //    // Logic to handle button click
        //   MessageBox.Show("IconButton clicked!");
        //}

        
    }
}
