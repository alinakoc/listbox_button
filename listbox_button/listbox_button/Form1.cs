using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace listbox_button
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private static Random random = new Random();

        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }


        private void button1_Click(object sender, EventArgs e)
        {
            //yeni buton oluşturma
            Button asd = new Button();

            // oluşturulan random sayılar 0 ile 300 arasında olsun
            int number = random.Next(0, 300);
            int number1 = random.Next(0, 300);

            //oluşturulan random kelimeler 5 harf uzunluğunda olsun 
            string yazi = RandomString(5);

            asd.Text = Convert.ToString(number);
            asd.Click += (s, a) => { MessageBox.Show(asd.Text); };
            asd.Location = new Point(listBox1.Items.Add(yazi));
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Button asd = new Button();
            this.Controls.Add(asd);
            Random rand = new Random();
            int number = random.Next(0, 300);
            int number1 = random.Next(0, 300);
            asd.Location = new Point(number, number1);
            asd.Text = listBox1.GetItemText(listBox1.SelectedItem);
            asd.Click += (s, a) => { MessageBox.Show(asd.Text); };
        }
    }
}
