namespace AncibleSpark.Forms
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox_AncibleObject = new System.Windows.Forms.ListBox();
            this.pictureBox_ObjectAnimation = new System.Windows.Forms.PictureBox();
            this.pictureBox_CollisionBoxes = new System.Windows.Forms.PictureBox();
            this.listBox_ObjectAnimations = new System.Windows.Forms.ListBox();
            this.listBox_CollisionBoxes = new System.Windows.Forms.ListBox();
            this.btn_EditAnimations = new System.Windows.Forms.Button();
            this.btn_EditCollisionBoxes = new System.Windows.Forms.Button();
            this.lbl_CollisionBoxes = new System.Windows.Forms.Label();
            this.lbl_ObjectAnimations = new System.Windows.Forms.Label();
            this.lbl_AncibleObjects = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnale_CollisionBoxes = new System.Windows.Forms.Panel();
            this.panel_ObjectAnimations = new System.Windows.Forms.Panel();
            this.btn_NewAncibleObject = new System.Windows.Forms.Button();
            this.btn_DeletAncibleObject = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ObjectAnimation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_CollisionBoxes)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.pnale_CollisionBoxes.SuspendLayout();
            this.panel_ObjectAnimations.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox_AncibleObject
            // 
            this.listBox_AncibleObject.FormattingEnabled = true;
            this.listBox_AncibleObject.Location = new System.Drawing.Point(12, 95);
            this.listBox_AncibleObject.Name = "listBox_AncibleObject";
            this.listBox_AncibleObject.Size = new System.Drawing.Size(120, 511);
            this.listBox_AncibleObject.TabIndex = 0;
            // 
            // pictureBox_ObjectAnimation
            // 
            this.pictureBox_ObjectAnimation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox_ObjectAnimation.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox_ObjectAnimation.Name = "pictureBox_ObjectAnimation";
            this.pictureBox_ObjectAnimation.Size = new System.Drawing.Size(4096, 4096);
            this.pictureBox_ObjectAnimation.TabIndex = 1;
            this.pictureBox_ObjectAnimation.TabStop = false;
            // 
            // pictureBox_CollisionBoxes
            // 
            this.pictureBox_CollisionBoxes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox_CollisionBoxes.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox_CollisionBoxes.Name = "pictureBox_CollisionBoxes";
            this.pictureBox_CollisionBoxes.Size = new System.Drawing.Size(4096, 4096);
            this.pictureBox_CollisionBoxes.TabIndex = 2;
            this.pictureBox_CollisionBoxes.TabStop = false;
            // 
            // listBox_ObjectAnimations
            // 
            this.listBox_ObjectAnimations.FormattingEnabled = true;
            this.listBox_ObjectAnimations.Location = new System.Drawing.Point(138, 95);
            this.listBox_ObjectAnimations.Name = "listBox_ObjectAnimations";
            this.listBox_ObjectAnimations.Size = new System.Drawing.Size(120, 225);
            this.listBox_ObjectAnimations.TabIndex = 3;
            // 
            // listBox_CollisionBoxes
            // 
            this.listBox_CollisionBoxes.FormattingEnabled = true;
            this.listBox_CollisionBoxes.Location = new System.Drawing.Point(138, 355);
            this.listBox_CollisionBoxes.Name = "listBox_CollisionBoxes";
            this.listBox_CollisionBoxes.Size = new System.Drawing.Size(120, 251);
            this.listBox_CollisionBoxes.TabIndex = 4;
            // 
            // btn_EditAnimations
            // 
            this.btn_EditAnimations.Location = new System.Drawing.Point(415, 65);
            this.btn_EditAnimations.Name = "btn_EditAnimations";
            this.btn_EditAnimations.Size = new System.Drawing.Size(97, 23);
            this.btn_EditAnimations.TabIndex = 5;
            this.btn_EditAnimations.Text = "Edit Animations";
            this.btn_EditAnimations.UseVisualStyleBackColor = true;
            // 
            // btn_EditCollisionBoxes
            // 
            this.btn_EditCollisionBoxes.Location = new System.Drawing.Point(402, 326);
            this.btn_EditCollisionBoxes.Name = "btn_EditCollisionBoxes";
            this.btn_EditCollisionBoxes.Size = new System.Drawing.Size(124, 23);
            this.btn_EditCollisionBoxes.TabIndex = 6;
            this.btn_EditCollisionBoxes.Text = "Edit Collision Boxes";
            this.btn_EditCollisionBoxes.UseVisualStyleBackColor = true;
            // 
            // lbl_CollisionBoxes
            // 
            this.lbl_CollisionBoxes.AutoSize = true;
            this.lbl_CollisionBoxes.Location = new System.Drawing.Point(159, 331);
            this.lbl_CollisionBoxes.Name = "lbl_CollisionBoxes";
            this.lbl_CollisionBoxes.Size = new System.Drawing.Size(77, 13);
            this.lbl_CollisionBoxes.TabIndex = 7;
            this.lbl_CollisionBoxes.Text = "Collision Boxes";
            // 
            // lbl_ObjectAnimations
            // 
            this.lbl_ObjectAnimations.AutoSize = true;
            this.lbl_ObjectAnimations.Location = new System.Drawing.Point(151, 70);
            this.lbl_ObjectAnimations.Name = "lbl_ObjectAnimations";
            this.lbl_ObjectAnimations.Size = new System.Drawing.Size(92, 13);
            this.lbl_ObjectAnimations.TabIndex = 8;
            this.lbl_ObjectAnimations.Text = "Object Animations";
            // 
            // lbl_AncibleObjects
            // 
            this.lbl_AncibleObjects.AutoSize = true;
            this.lbl_AncibleObjects.Location = new System.Drawing.Point(30, 70);
            this.lbl_AncibleObjects.Name = "lbl_AncibleObjects";
            this.lbl_AncibleObjects.Size = new System.Drawing.Size(81, 13);
            this.lbl_AncibleObjects.TabIndex = 9;
            this.lbl_AncibleObjects.Text = "Ancible Objects";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(749, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // pnale_CollisionBoxes
            // 
            this.pnale_CollisionBoxes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnale_CollisionBoxes.Controls.Add(this.pictureBox_CollisionBoxes);
            this.pnale_CollisionBoxes.Location = new System.Drawing.Point(285, 355);
            this.pnale_CollisionBoxes.Name = "pnale_CollisionBoxes";
            this.pnale_CollisionBoxes.Size = new System.Drawing.Size(367, 251);
            this.pnale_CollisionBoxes.TabIndex = 11;
            // 
            // panel_ObjectAnimations
            // 
            this.panel_ObjectAnimations.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_ObjectAnimations.Controls.Add(this.pictureBox_ObjectAnimation);
            this.panel_ObjectAnimations.Location = new System.Drawing.Point(285, 95);
            this.panel_ObjectAnimations.Name = "panel_ObjectAnimations";
            this.panel_ObjectAnimations.Size = new System.Drawing.Size(367, 225);
            this.panel_ObjectAnimations.TabIndex = 12;
            this.panel_ObjectAnimations.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btn_NewAncibleObject
            // 
            this.btn_NewAncibleObject.Location = new System.Drawing.Point(12, 27);
            this.btn_NewAncibleObject.Name = "btn_NewAncibleObject";
            this.btn_NewAncibleObject.Size = new System.Drawing.Size(111, 23);
            this.btn_NewAncibleObject.TabIndex = 13;
            this.btn_NewAncibleObject.Text = "New Anicble Object";
            this.btn_NewAncibleObject.UseVisualStyleBackColor = true;
            this.btn_NewAncibleObject.Click += new System.EventHandler(this.btn_NewAncibleObject_Click);
            // 
            // btn_DeletAncibleObject
            // 
            this.btn_DeletAncibleObject.Location = new System.Drawing.Point(138, 27);
            this.btn_DeletAncibleObject.Name = "btn_DeletAncibleObject";
            this.btn_DeletAncibleObject.Size = new System.Drawing.Size(120, 23);
            this.btn_DeletAncibleObject.TabIndex = 14;
            this.btn_DeletAncibleObject.Text = "Delete Ancible Object";
            this.btn_DeletAncibleObject.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 630);
            this.Controls.Add(this.btn_DeletAncibleObject);
            this.Controls.Add(this.btn_NewAncibleObject);
            this.Controls.Add(this.panel_ObjectAnimations);
            this.Controls.Add(this.pnale_CollisionBoxes);
            this.Controls.Add(this.lbl_AncibleObjects);
            this.Controls.Add(this.lbl_ObjectAnimations);
            this.Controls.Add(this.lbl_CollisionBoxes);
            this.Controls.Add(this.btn_EditCollisionBoxes);
            this.Controls.Add(this.btn_EditAnimations);
            this.Controls.Add(this.listBox_CollisionBoxes);
            this.Controls.Add(this.listBox_ObjectAnimations);
            this.Controls.Add(this.listBox_AncibleObject);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.Text = "Ancible Spark";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ObjectAnimation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_CollisionBoxes)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnale_CollisionBoxes.ResumeLayout(false);
            this.panel_ObjectAnimations.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_AncibleObject;
        private System.Windows.Forms.PictureBox pictureBox_ObjectAnimation;
        private System.Windows.Forms.PictureBox pictureBox_CollisionBoxes;
        private System.Windows.Forms.ListBox listBox_ObjectAnimations;
        private System.Windows.Forms.ListBox listBox_CollisionBoxes;
        private System.Windows.Forms.Button btn_EditAnimations;
        private System.Windows.Forms.Button btn_EditCollisionBoxes;
        private System.Windows.Forms.Label lbl_CollisionBoxes;
        private System.Windows.Forms.Label lbl_ObjectAnimations;
        private System.Windows.Forms.Label lbl_AncibleObjects;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Panel pnale_CollisionBoxes;
        private System.Windows.Forms.Panel panel_ObjectAnimations;
        private System.Windows.Forms.Button btn_NewAncibleObject;
        private System.Windows.Forms.Button btn_DeletAncibleObject;
    }
}