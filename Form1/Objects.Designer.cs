namespace Form1
{
    partial class Objects
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
            this.tboxobjectname = new System.Windows.Forms.TextBox();
            this.lblname = new System.Windows.Forms.Label();
            this.lblweight = new System.Windows.Forms.Label();
            this.tboxobjectweight = new System.Windows.Forms.TextBox();
            this.lblvalue = new System.Windows.Forms.Label();
            this.tboxobjectvalue = new System.Windows.Forms.TextBox();
            this.lblobjectsummary = new System.Windows.Forms.Label();
            this.rtboxobjectsummary = new System.Windows.Forms.RichTextBox();
            this.btncreateobject = new System.Windows.Forms.Button();
            this.lblobjectfields = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tboxobjectname
            // 
            this.tboxobjectname.Location = new System.Drawing.Point(12, 12);
            this.tboxobjectname.Name = "tboxobjectname";
            this.tboxobjectname.PlaceholderText = "Type Name Here...";
            this.tboxobjectname.Size = new System.Drawing.Size(114, 23);
            this.tboxobjectname.TabIndex = 0;
            this.tboxobjectname.TextChanged += new System.EventHandler(this.tboxobjectname_TextChanged);
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(132, 15);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(39, 15);
            this.lblname.TabIndex = 1;
            this.lblname.Text = "Name";
            this.lblname.Click += new System.EventHandler(this.lblname_Click);
            // 
            // lblweight
            // 
            this.lblweight.AutoSize = true;
            this.lblweight.Location = new System.Drawing.Point(132, 44);
            this.lblweight.Name = "lblweight";
            this.lblweight.Size = new System.Drawing.Size(45, 15);
            this.lblweight.TabIndex = 3;
            this.lblweight.Text = "Weight";
            this.lblweight.Click += new System.EventHandler(this.lblweight_Click);
            // 
            // tboxobjectweight
            // 
            this.tboxobjectweight.Location = new System.Drawing.Point(12, 41);
            this.tboxobjectweight.Name = "tboxobjectweight";
            this.tboxobjectweight.PlaceholderText = "Type Weight Here...";
            this.tboxobjectweight.Size = new System.Drawing.Size(114, 23);
            this.tboxobjectweight.TabIndex = 2;
            this.tboxobjectweight.TextChanged += new System.EventHandler(this.tboxobjectweight_TextChanged);
            // 
            // lblvalue
            // 
            this.lblvalue.AutoSize = true;
            this.lblvalue.Location = new System.Drawing.Point(132, 73);
            this.lblvalue.Name = "lblvalue";
            this.lblvalue.Size = new System.Drawing.Size(35, 15);
            this.lblvalue.TabIndex = 5;
            this.lblvalue.Text = "Value";
            this.lblvalue.Click += new System.EventHandler(this.lblvalue_Click);
            // 
            // tboxobjectvalue
            // 
            this.tboxobjectvalue.Location = new System.Drawing.Point(12, 70);
            this.tboxobjectvalue.Name = "tboxobjectvalue";
            this.tboxobjectvalue.PlaceholderText = "Type Value Here...";
            this.tboxobjectvalue.Size = new System.Drawing.Size(114, 23);
            this.tboxobjectvalue.TabIndex = 4;
            this.tboxobjectvalue.TextChanged += new System.EventHandler(this.tboxobjectvalue_TextChanged);
            // 
            // lblobjectsummary
            // 
            this.lblobjectsummary.AutoSize = true;
            this.lblobjectsummary.Location = new System.Drawing.Point(12, 110);
            this.lblobjectsummary.Name = "lblobjectsummary";
            this.lblobjectsummary.Size = new System.Drawing.Size(96, 15);
            this.lblobjectsummary.TabIndex = 6;
            this.lblobjectsummary.Text = "Object Summary";
            this.lblobjectsummary.Click += new System.EventHandler(this.lblobjectsummary_Click);
            // 
            // rtboxobjectsummary
            // 
            this.rtboxobjectsummary.Location = new System.Drawing.Point(12, 128);
            this.rtboxobjectsummary.Name = "rtboxobjectsummary";
            this.rtboxobjectsummary.Size = new System.Drawing.Size(228, 96);
            this.rtboxobjectsummary.TabIndex = 8;
            this.rtboxobjectsummary.Text = "";
            this.rtboxobjectsummary.TextChanged += new System.EventHandler(this.rtboxobjectsummary_TextChanged);
            // 
            // btncreateobject
            // 
            this.btncreateobject.Location = new System.Drawing.Point(189, 25);
            this.btncreateobject.Name = "btncreateobject";
            this.btncreateobject.Size = new System.Drawing.Size(75, 52);
            this.btncreateobject.TabIndex = 9;
            this.btncreateobject.Text = "Create Object!";
            this.btncreateobject.UseVisualStyleBackColor = true;
            this.btncreateobject.Click += new System.EventHandler(this.btncreateobject_Click);
            // 
            // lblobjectfields
            // 
            this.lblobjectfields.AutoSize = true;
            this.lblobjectfields.Location = new System.Drawing.Point(189, 78);
            this.lblobjectfields.Name = "lblobjectfields";
            this.lblobjectfields.Size = new System.Drawing.Size(68, 15);
            this.lblobjectfields.TabIndex = 10;
            this.lblobjectfields.Text = "Fill all fields";
            this.lblobjectfields.Click += new System.EventHandler(this.lblobjectfields_Click);
            // 
            // Objects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 244);
            this.Controls.Add(this.lblobjectfields);
            this.Controls.Add(this.btncreateobject);
            this.Controls.Add(this.rtboxobjectsummary);
            this.Controls.Add(this.lblobjectsummary);
            this.Controls.Add(this.lblvalue);
            this.Controls.Add(this.tboxobjectvalue);
            this.Controls.Add(this.lblweight);
            this.Controls.Add(this.tboxobjectweight);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.tboxobjectname);
            this.Name = "Objects";
            this.Text = "Objects";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tboxobjectname;
        private Label lblname;
        private Label lblweight;
        private TextBox tboxobjectweight;
        private Label lblvalue;
        private TextBox tboxobjectvalue;
        private Label lblobjectsummary;
        private RichTextBox rtboxobjectsummary;
        private Button btncreateobject;
        private Label lblobjectfields;
    }
}