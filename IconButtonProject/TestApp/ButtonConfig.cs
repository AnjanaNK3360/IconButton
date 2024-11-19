using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IconButtonTestApp
{
    public static class ButtonConfig
    {
        public static ButtonViewModel buttonViewModel {  get; set; }

        static ButtonConfig()
        {
            buttonViewModel = new ButtonViewModel();
        }
    }
}
