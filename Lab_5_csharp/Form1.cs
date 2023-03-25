using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Collections;

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
            try
            {
                List<DesyatkovaStrichka> desyatkovaStrichkas = new List<DesyatkovaStrichka>();
                desyatkovaStrichkas.Add(new DesyatkovaStrichka(10));
                desyatkovaStrichkas.Add(new DesyatkovaStrichka(20));
                desyatkovaStrichkas.Add(new DesyatkovaStrichka(30));
                desyatkovaStrichkas.Add(new DesyatkovaStrichka(4));
                desyatkovaStrichkas.Add(new DesyatkovaStrichka(2));

                foreach (var str in desyatkovaStrichkas)
                {
                    richTextBox1.AppendText(new string(str.Symbol) + "\n");
                }

                richTextBox1.AppendText("-------------------------------\n");

                int count = desyatkovaStrichkas.Count;

                for (int i = 0; i < count; i++)
                {
                    desyatkovaStrichkas.Add((DesyatkovaStrichka)desyatkovaStrichkas[i].Clone());
                }
                foreach (var str in desyatkovaStrichkas)
                {
                    richTextBox1.AppendText(new string(str.Symbol) + "\n");
                }
                desyatkovaStrichkas.Sort();
                richTextBox1.AppendText("-------------------------------\n");
                foreach (var str in desyatkovaStrichkas)
                {
                    richTextBox1.AppendText(new string(str.Symbol) + "\n");
                }
            }
            catch (Exception ex)
            {
                richTextBox1.AppendText(ex.Message + "\n");
            }
            richTextBox1.AppendText("---------------LAB7-------------\n");
            EnginCalcCollection collection = new EnginCalcCollection();

            // Додавання елементів до колекції
            collection.Add(new EngineeringCalculator(1, "Calculator 1\n"));
            collection.Add(new EngineeringCalculator(2, "Calculator 2\n"));
            collection.Add(new EngineeringCalculator(3, "Calculator 3\n"));

            // Відображення елементів за ключем
            richTextBox1.AppendText(collection.DisplayElement(1)+ "\n");
            richTextBox1.AppendText(collection.DisplayElement(2)+ "\n");
            richTextBox1.AppendText(collection.DisplayElement(3)+"\n");

            // Перебір елементів за допомогою GetEnumerator
            richTextBox1.AppendText("Using GetEnumerator:\n");
            IEnumerator enumerator = collection.GetEnumerator();
            while (enumerator.MoveNext())
            {
                richTextBox1.AppendText(Convert.ToString(enumerator.Current)+ "\n");
            }

            // Перебір елементів за допомогою GetEnumeratorGeneric
            richTextBox1.AppendText("Using GetEnumeratorGeneric:\n");
            IEnumerator<EngineeringCalculator> enumeratorGeneric = collection.GetEnumeratorGeneric();
            while (enumeratorGeneric.MoveNext())
            {
                richTextBox1.AppendText(Convert.ToString(enumeratorGeneric.Current)+ "\n");
            }
        }
    }
    
}