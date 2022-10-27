namespace AdventureMaker
{
    partial class EditStats
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btncreatestat = new System.Windows.Forms.Button();
            this.lblname = new System.Windows.Forms.Label();
            this.tboxobjectname = new System.Windows.Forms.TextBox();
            this.rtboxobjectsummary = new System.Windows.Forms.RichTextBox();
            this.lblobjectsummary = new System.Windows.Forms.Label();
            this.lblValu3 = new System.Windows.Forms.Label();
            this.tboxvalue = new System.Windows.Forms.TextBox();
            this.comboxAddtoall = new System.Windows.Forms.ComboBox();
            this.lblAddtoAll = new System.Windows.Forms.Label();
            this.btnAddtoall = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btncreatestat
            // 
            this.btncreatestat.Location = new System.Drawing.Point(4, 180);
            this.btncreatestat.Name = "btncreatestat";
            this.btncreatestat.Size = new System.Drawing.Size(95, 52);
            this.btncreatestat.TabIndex = 22;
            this.btncreatestat.Text = "Create Stat!";
            this.btncreatestat.UseVisualStyleBackColor = true;
            this.btncreatestat.Click += new System.EventHandler(this.btncreatestat_Click);
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(123, 6);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(39, 15);
            this.lblname.TabIndex = 21;
            this.lblname.Text = "Name";
            // 
            // tboxobjectname
            // 
            this.tboxobjectname.Location = new System.Drawing.Point(3, 3);
            this.tboxobjectname.Name = "tboxobjectname";
            this.tboxobjectname.PlaceholderText = "Type Name Here...";
            this.tboxobjectname.Size = new System.Drawing.Size(114, 23);
            this.tboxobjectname.TabIndex = 20;
            // 
            // rtboxobjectsummary
            // 
            this.rtboxobjectsummary.Location = new System.Drawing.Point(3, 49);
            this.rtboxobjectsummary.Name = "rtboxobjectsummary";
            this.rtboxobjectsummary.Size = new System.Drawing.Size(228, 96);
            this.rtboxobjectsummary.TabIndex = 24;
            this.rtboxobjectsummary.Text = "";
            // 
            // lblobjectsummary
            // 
            this.lblobjectsummary.AutoSize = true;
            this.lblobjectsummary.Location = new System.Drawing.Point(3, 31);
            this.lblobjectsummary.Name = "lblobjectsummary";
            this.lblobjectsummary.Size = new System.Drawing.Size(96, 15);
            this.lblobjectsummary.TabIndex = 23;
            this.lblobjectsummary.Text = "Object Summary";
            // 
            // lblValu3
            // 
            this.lblValu3.AutoSize = true;
            this.lblValu3.Location = new System.Drawing.Point(123, 154);
            this.lblValu3.Name = "lblValu3";
            this.lblValu3.Size = new System.Drawing.Size(35, 15);
            this.lblValu3.TabIndex = 26;
            this.lblValu3.Text = "Value";
            // 
            // tboxvalue
            // 
            this.tboxvalue.Location = new System.Drawing.Point(3, 151);
            this.tboxvalue.Name = "tboxvalue";
            this.tboxvalue.PlaceholderText = "Type Value Here...";
            this.tboxvalue.Size = new System.Drawing.Size(114, 23);
            this.tboxvalue.TabIndex = 25;
            // 
            // comboxAddtoall
            // 
            this.comboxAddtoall.FormattingEnabled = true;
            this.comboxAddtoall.Location = new System.Drawing.Point(250, 164);
            this.comboxAddtoall.Name = "comboxAddtoall";
            this.comboxAddtoall.Size = new System.Drawing.Size(121, 23);
            this.comboxAddtoall.TabIndex = 27;
            // 
            // lblAddtoAll
            // 
            this.lblAddtoAll.AutoSize = true;
            this.lblAddtoAll.Location = new System.Drawing.Point(250, 146);
            this.lblAddtoAll.Name = "lblAddtoAll";
            this.lblAddtoAll.Size = new System.Drawing.Size(61, 15);
            this.lblAddtoAll.TabIndex = 28;
            this.lblAddtoAll.Text = "Add to all:";
            // 
            // btnAddtoall
            // 
            this.btnAddtoall.Location = new System.Drawing.Point(250, 193);
            this.btnAddtoall.Name = "btnAddtoall";
            this.btnAddtoall.Size = new System.Drawing.Size(121, 54);
            this.btnAddtoall.TabIndex = 29;
            this.btnAddtoall.Text = "Add to all";
            this.btnAddtoall.UseVisualStyleBackColor = true;
            // 
            // EditStats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnAddtoall);
            this.Controls.Add(this.lblAddtoAll);
            this.Controls.Add(this.comboxAddtoall);
            this.Controls.Add(this.lblValu3);
            this.Controls.Add(this.tboxvalue);
            this.Controls.Add(this.rtboxobjectsummary);
            this.Controls.Add(this.lblobjectsummary);
            this.Controls.Add(this.btncreatestat);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.tboxobjectname);
            this.Name = "EditStats";
            this.Size = new System.Drawing.Size(393, 262);
            this.Load += new System.EventHandler(this.EditStats_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btncreatestat;
        private Label lblname;
        private TextBox tboxobjectname;
        private RichTextBox rtboxobjectsummary;
        private Label lblobjectsummary;
        private Label lblValu3;
        private TextBox tboxvalue;
        private ComboBox comboxAddtoall;
        private Label lblAddtoAll;
        private Button btnAddtoall;
    }
}
