using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HitachiHighTech.LS.GUI;
using System.Windows.Media;
using System.Windows;

namespace IconButtonTestApp
{
    public  class ButtonModel
    {
        public Geometry IconGeometry { get; set; }
        public string Text { get; set; }
        public Brush ButtonBackground { get; set; }
        public Brush Foreground { get; set; }
        public Brush IconFill { get; set; }
        public Brush IconStroke { get; set; }
        public CornerRadius CornerRadius { get; set; }
        public double FontSize { get; set; }
        public IconAlignment IconAlignment { get; set; }
        public double StrokeThickness { get; set; }

    }
}
