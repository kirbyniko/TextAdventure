namespace AdventureMaker
{
    partial class InventoryEditor
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
            this.lblobjectfields = new System.Windows.Forms.Label();
            this.btneditobjectinstance = new System.Windows.Forms.Button();
            this.rtboxobjectsummary = new System.Windows.Forms.RichTextBox();
            this.lblobjectsummary = new System.Windows.Forms.Label();
            this.lblvalue = new System.Windows.Forms.Label();
            this.tboxobjectvalue = new System.Windows.Forms.TextBox();
            this.lblweight = new System.Windows.Forms.Label();
            this.tboxobjectweight = new System.Windows.Forms.TextBox();
            this.lblname = new System.Windows.Forms.Label();
            this.tboxobjectname = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblobjectfields
            // 
            this.lblobjectfields.AutoSize = true;
            this.lblobjectfields.Location = new System.Drawing.Point(189, 74);
            this.lblobjectfields.Name = "lblobjectfields";
            this.lblobjectfields.Size = new System.Drawing.Size(68, 15);
            this.lblobjectfields.TabIndex = 20;
            this.lblobjectfields.Text = "Fill all fields";
            // 
            // btneditobjectinstance
            // 
            this.btneditobjectinstance.Location = new System.Drawing.Point(189, 21);
            this.btneditobjectinstance.Name = "btneditobjectinstance";
            this.btneditobjectinstance.Size = new System.Drawing.Size(75, 52);
            this.btneditobjectinstance.TabIndex = 19;
            this.btneditobjectinstance.Text = "Edit Object Instance!";
            this.btneditobjectinstance.UseVisualStyleBackColor = true;
            this.btneditobjectinstance.Click += new System.EventHandler(this.btneditobjectinstance_Click);
            // 
            // rtboxobjectsummary
            // 
            this.rtboxobjectsummary.Location = new System.Drawing.Point(12, 124);
            this.rtboxobjectsummary.Name = "rtboxobjectsummary";
            this.rtboxobjectsummary.Size = new System.Drawing.Size(228, 96);
            this.rtboxobjectsummary.TabIndex = 18;
            this.rtboxobjectsummary.Text = "";
            // 
            // lblobjectsummary
            // 
            this.lblobjectsummary.AutoSize = true;
            this.lblobjectsummary.Location = new System.Drawing.Point(12, 106);
            this.lblobjectsummary.Name = "lblobjectsummary";
            this.lblobjectsummary.Size = new System.Drawing.Size(96, 15);
            this.lblobjectsummary.TabIndex = 17;
            this.lblobjectsummary.Text = "Object Summary";
            // 
            // lblvalue
            // 
            this.lblvalue.AutoSize = true;
            this.lblvalue.Location = new System.Drawing.Point(118, 69);
            this.lblvalue.Name = "lblvalue";
            this.lblvalue.Size = new System.Drawing.Size(35, 15);
            this.lblvalue.TabIndex = 16;
            this.lblvalue.Text = "Value";
            // 
            // tboxobjectvalue
            // 
            this.tboxobjectvalue.Location = new System.Drawing.Point(12, 66);
            this.tboxobjectvalue.Name = "tboxobjectvalue";
            this.tboxobjectvalue.Size = new System.Drawing.Size(100, 23);
            this.tboxobjectvalue.TabIndex = 15;
            // 
            // lblweight
            // 
            this.lblweight.AutoSize = true;
            this.lblweight.Location = new System.Drawing.Point(118, 40);
            this.lblweight.Name = "lblweight";
            this.lblweight.Size = new System.Drawing.Size(45, 15);
            this.lblweight.TabIndex = 14;
            this.lblweight.Text = "Weight";
            // 
            // tboxobjectweight
            // 
            this.tboxobjectweight.Location = new System.Drawing.Point(12, 37);
            this.tboxobjectweight.Name = "tboxobjectweight";
            this.tboxobjectweight.Size = new System.Drawing.Size(100, 23);
            this.tboxobjectweight.TabIndex = 13;
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(118, 11);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(39, 15);
            this.lblname.TabIndex = 12;
            this.lblname.Text = "Name";
            // 
            // tboxobjectname
            // 
            this.tboxobjectname.Location = new System.Drawing.Point(12, 8);
            this.tboxobjectname.Name = "tboxobjectname";
            this.tboxobjectname.Size = new System.Drawing.Size(100, 23);
            this.tboxobjectname.TabIndex = 11;
            // 
            // InventoryEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 275);
            this.Controls.Add(this.lblobjectfields);
            this.Controls.Add(this.btneditobjectinstance);
            this.Controls.Add(this.rtboxobjectsummary);
            this.Controls.Add(this.lblobjectsummary);
            this.Controls.Add(this.lblvalue);
            this.Controls.Add(this.tboxobjectvalue);
            this.Controls.Add(this.lblweight);
            this.Controls.Add(this.tboxobjectweight);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.tboxobjectname);
            this.Name = "InventoryEditor";
            this.Text = "InventoryEditor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblobjectfields;
        private Button btneditobjectinstance;
        private RichTextBox rtboxobjectsummary;
        private Label lblobjectsummary;
        private Label lblvalue;
        private TextBox tboxobjectvalue;
        private Label lblweight;
        private TextBox tboxobjectweight;
        private Label lblname;
        private TextBox tboxobjectname;
    }
}