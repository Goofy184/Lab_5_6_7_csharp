using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_5_csharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DesyatkovaStrichka strichka1 = new DesyatkovaStrichka((int)this.numericUpDown1.Value);
            DesyatkovaStrichka strichka2 = new DesyatkovaStrichka((int)this.numericUpDown2.Value);

            DesyatkovaStrichka strichka3 = strichka1 - strichka2;

            this.result.Text = new string(strichka3.Symbol);
            if (strichka1 > strichka2)
            {
                this.comparisonResult.Text = "First one is greater";
            }
            else if (strichka1 < strichka2) {
                this.comparisonResult.Text = "Second one is greater";
            }
        }
    }
}
