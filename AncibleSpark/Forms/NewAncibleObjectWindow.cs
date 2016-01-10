using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AncibleObjectLib;
using AncibleObjectLib.AncibleObjects;
using AncibleObjectLib.Interfaces;

namespace AncibleSpark.Forms
{
    public partial class NewAncibleObjectWindow : Form
    {
        private List<string> names;
        
        public NewAncibleObjectWindow(List<string> objectNames)
        {
            InitializeComponent();
            FillObjectTypeComboxBox();
            names = objectNames;
        }
        public IAncibleObject ReturnObject { get; set; }

        private void FillObjectTypeComboxBox()
        {
            foreach (ObjectType type in Enum.GetValues(typeof(ObjectType)))
            {
                cmboBox_ObjectType.Items.Add(type.ToString());
            }
        }

        private void btn_Ok_Click(object sender, EventArgs e)
        {
            if (txtBox_ObjectName.Text == "")
            {
                MessageBox.Show("Name cannot be blank");
                return;
            }
            if (names.Contains(txtBox_ObjectName.Text))
            {
                MessageBox.Show("The name " + txtBox_ObjectName.Text + " already exists");
                return;
            }
            ObjectType type = GetObjectType();
            switch (type)
            {
                case ObjectType.Player:
                    Player player = new Player(txtBox_ObjectName.Text);
                    ReturnObject = player;
                    break;
                default:
                    MessageBox.Show(type.ToString() + " has not been implemented yet");
                    return;
            }
            DialogResult = DialogResult.OK;
            Close();
        }

        private ObjectType GetObjectType()
        {
            switch (cmboBox_ObjectType.SelectedItem.ToString())
            {
                case "Player":
                    return ObjectType.Player;
                case "NPC":
                    return ObjectType.NPC;
                case "Terrain":
                    return ObjectType.Terrain;
                case "Projectile":
                    return ObjectType.Projectile;
                case "Weapon":
                    return ObjectType.Weapon;
                case "GUI":
                    return ObjectType.GUI;
                default:
                    throw new Exception("Invalid Object Type");
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
