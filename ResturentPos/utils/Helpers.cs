using MetroFramework.Controls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResturentPos.utils
{
    class Helpers
    {
        public string[] getDataToComboBox(DataTable catergories)
        {
            int lengthOfCatergories = catergories.Rows.Count;
            string[] cts = new string[lengthOfCatergories];

            for (int i = 0; i < lengthOfCatergories; i++)
            {
                cts[i] = catergories.Rows[i][0].ToString();
                Console.WriteLine(catergories.Rows[i][0]);
            }

            return cts;
        }

        public int getDataFromDtToTb(DataTable catergories)
        {
            return 0;
        }
    }
}
