using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ProjectAncible;

namespace AncibleSpark.Forms
{
    public partial class MainWindow : Form
    {
        public Jane Jane = new Jane();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_NewAncibleObject_Click(object sender, EventArgs e)
        {
            NewAncibleObjectWindow newAncibleObject = new NewAncibleObjectWindow(Jane.GetObjectNames());
            newAncibleObject.Closed += delegate(object o, EventArgs args)
            {
                switch (newAncibleObject.DialogResult)
                {
                    case DialogResult.OK:
                        Jane.AddObject(newAncibleObject.ReturnObject);
                        listBox_AncibleObject.Items.Add(newAncibleObject.ReturnObject.Name);
                        break;
                    case DialogResult.Cancel:
                        return;                        
                }
            };
            newAncibleObject.ShowDialog();
        }
    }
}
