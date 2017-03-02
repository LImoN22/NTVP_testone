using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TestCreateTextBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            listControls.Add(Controls);
            listControls.Add(groupBox1.Controls);
        }

        private BindingList<Control.ControlCollection> listControls = new BindingList<Control.ControlCollection>();

        private void button1_Click(object sender, EventArgs e)
        {
            
            CreateInnerForms cr = new CreateInnerForms(listControls);
            List<string> name = new List<string>();
            name.Add("one");
            name.Add("two");
            name.Add("three");
            Point p = new Point(10, 20);
            cr.PothitionTextBox(name, p);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            CreateInnerForms cr = new CreateInnerForms(listControls);
            List<string> name = new List<string>();
            name.Add("one1");
            name.Add("two1");
            name.Add("three1");
            Point p = new Point(10, 5);
            cr.PothitionTextBox(name, p);


        }
    }
}
