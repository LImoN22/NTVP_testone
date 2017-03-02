using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Windows.Forms.TextBox;

namespace TestCreateTextBox
{
    public class CreateInnerForms
    {
        private BindingList<Control.ControlCollection> _listControls;
        public CreateInnerForms(BindingList<Control.ControlCollection> listControls)
        {
            _listControls = listControls;
        }

        public BindingList<TextBox> PothitionTextBox(List<string> listName, Point pothition)
        {
            var listTextBox = new BindingList<TextBox>();
            
            foreach(var name in listName)
            {
                listTextBox.Add(CreateTextBox(name,pothition));
                //pothition.X += 20;
                pothition.Y += 40;
            }
            return listTextBox;
        }

        private TextBox CreateTextBox(string name, Point pothition)
        {
            TextBox createTextBox = new TextBox();
            createTextBox.Name = name;
            createTextBox.Location = pothition;
            _listControls[0].Add(createTextBox);
            _listControls[1].Add(createTextBox);
            return createTextBox;
        }
    }
}
