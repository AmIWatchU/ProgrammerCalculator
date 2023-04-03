using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgrammerCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void All_tb_KeyPress(object sender, KeyPressEventArgs e) //allowed value
        {
            TextBox tb = (TextBox)sender;

            if (tb.Name == textBox_Hex.Name)
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)
                    && !(e.KeyChar >= 'A' && e.KeyChar <= 'F'))
                {
                    e.Handled = true;
                }
            }

            if (tb.Name == textBox_Dec.Name)
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            }

            if (tb.Name == textBox_Oct.Name)
            {
                if (!char.IsControl(e.KeyChar) && !(e.KeyChar >= '0' && e.KeyChar <='7'))
                {
                    e.Handled = true;
                }
            }

            if (tb.Name == textBox_Bin.Name)
            {
                if (!char.IsControl(e.KeyChar) && e.KeyChar !='0' && e.KeyChar != '1')
                {
                    e.Handled = true;
                }
            }
        }
        private void All_tb_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            string str = tb.Text.PadLeft(1, '0');
            int dig = 0;

            if (tb.Name == textBox_Hex.Name)
                dig = Convert.ToInt32(str, 16);

            if (tb.Name == textBox_Oct.Name)
                dig = Convert.ToInt32(str, 8);

            if (tb.Name == textBox_Bin.Name)
                dig = Convert.ToInt32(str, 2);

            if (tb.Name == textBox_Dec.Name)
                dig = Convert.ToInt32(str, 10);

            string str_hex = Convert.ToString(dig, 16);
            textBox_Hex.Text = str_hex.ToUpper();

            string str_oct = Convert.ToString(dig, 8);
            textBox_Oct.Text = str_oct.ToUpper();

            string str_dec = Convert.ToString(dig, 10);
            textBox_Dec.Text = str_dec.ToUpper();

            string str_bin = Convert.ToString(dig, 2);
            textBox_Bin.Text = str_bin.ToUpper();
        }

       
    }
}
