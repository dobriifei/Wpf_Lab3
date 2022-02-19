using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Wpf_Lab3
{
    class My_command
    {
        public static RoutedCommand Close { get; set; }
        static My_command()
        {
            Close = new RoutedCommand();
        }
    }

}
