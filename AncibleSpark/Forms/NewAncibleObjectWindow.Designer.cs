namespace AncibleSpark.Forms
{
    partial class NewAncibleObjectWindow
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
            this.cmboBox_ObjectType = new System.Windows.Forms.ComboBox();
            this.txtBox_ObjectName = new System.Windows.Forms.TextBox();
            this.lbl_ObjectName = new System.Windows.Forms.Label();
            this.lbl_ObjectType = new System.Windows.Forms.Label();
            this.btn_Ok = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmboBox_ObjectType
            // 
            this.cmboBox_ObjectType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboBox_ObjectType.FormattingEnabled = true;
            this.cmboBox_ObjectType.Location = new System.Drawing.Point(51, 119);
            this.cmboBox_ObjectType.Name = "cmboBox_ObjectType";
            this.cmboBox_ObjectType.Size = new System.Drawing.Size(196, 21);
            this.cmboBox_ObjectType.TabIndex = 0;
            // 
            // txtBox_ObjectName
            // 
            this.txtBox_ObjectName.Location = new System.Drawing.Point(12, 57);
            this.txtBox_ObjectName.Name = "txtBox_ObjectName";
            this.txtBox_ObjectName.Size = new System.Drawing.Size(280, 20);
            this.txtBox_ObjectName.TabIndex = 1;
            // 
            // lbl_ObjectName
            // 
            this.lbl_ObjectName.AutoSize = true;
            this.lbl_ObjectName.Location = new System.Drawing.Point(112, 25);
            this.lbl_ObjectName.Name = "lbl_ObjectName";
            this.lbl_ObjectName.Size = new System.Drawing.Size(72, 13);
            this.lbl_ObjectName.TabIndex = 2;
            this.lbl_ObjectName.Text = "Object Name:";
            // 
            // lbl_ObjectType
            // 
            this.lbl_ObjectType.AutoSize = true;
            this.lbl_ObjectType.Location = new System.Drawing.Point(114, 97);
            this.lbl_ObjectType.Name = "lbl_ObjectType";
            this.lbl_ObjectType.Size = new System.Drawing.Size(65, 13);
            this.lbl_ObjectType.TabIndex = 3;
            this.lbl_ObjectType.Text = "Object Type";
            // 
            // btn_Ok
            // 
            this.btn_Ok.Location = new System.Drawing.Point(60, 161);
            this.btn_Ok.Name = "btn_Ok";
            this.btn_Ok.Size = new System.Drawing.Size(75, 23);
            this.btn_Ok.TabIndex = 4;
            this.btn_Ok.Text = "OK";
            this.btn_Ok.UseVisualStyleBackColor = true;
            this.btn_Ok.Click += new System.EventHandler(this.btn_Ok_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(162, 161);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 5;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // NewAncibleObjectWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 200);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Ok);
            this.Controls.Add(this.lbl_ObjectType);
            this.Controls.Add(this.lbl_ObjectName);
            this.Controls.Add(this.txtBox_ObjectName);
            this.Controls.Add(this.cmboBox_ObjectType);
            this.Name = "NewAncibleObjectWindow";
            this.Text = "NewAncibleObjectWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmboBox_ObjectType;
        private System.Windows.Forms.TextBox txtBox_ObjectName;
        private System.Windows.Forms.Label lbl_ObjectName;
        private System.Windows.Forms.Label lbl_ObjectType;
        private System.Windows.Forms.Button btn_Ok;
        private System.Windows.Forms.Button btn_Cancel;
    }
}