using MetroFramework.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResturentPos.utils
{
    class Validations
    {
        public bool validateTextBoxes(MetroTextBox tb)
        {
            if (tb.Text == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
