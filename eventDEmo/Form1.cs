using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eventDEmo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Incrementer incrementer = new Incrementer();     // event publisher object
            Dozens dozensCounter = new Dozens(incrementer);  // event subscriber object
            incrementer.DoCount();
            MessageBox.Show("number of dozens = " + dozensCounter.DozensCount);
        }
    }
}
