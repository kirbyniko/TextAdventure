namespace AdventureMaker
{
    partial class EditObject
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
            this.lblobjectfields = new System.Windows.Forms.Label();
            this.btncreateobject = new System.Windows.Forms.Button();
            this.rtboxobjectsummary = new System.Windows.Forms.RichTextBox();
            this.lblobjectsummary = new System.Windows.Forms.Label();
            this.lblvalue = new System.Windows.Forms.Label();
            this.tboxobjectvalue = new System.Windows.Forms.TextBox();
            this.lblweight = new System.Windows.Forms.Label();
            this.tboxobjectweight = new System.Windows.Forms.TextBox();
            this.lblname = new System.Windows.Forms.Label();
            this.tboxobjectname = new System.Windows.Forms.TextBox();
            this.lboxsynonyms = new System.Windows.Forms.ListBox();
            this.btnaddsynonym = new System.Windows.Forms.Button();
            this.btnremovesynonym = new System.Windows.Forms.Button();
            this.tboxsynonyms = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblobjectfields
            // 
            this.lblobjectfields.AutoSize = true;
            this.lblobjectfields.Location = new System.Drawing.Point(199, 100);
            this.lblobjectfields.Name = "lblobjectfields";
            this.lblobjectfields.Size = new System.Drawing.Size(68, 15);
            this.lblobjectfields.TabIndex = 20;
            this.lblobjectfields.Text = "Fill all fields";
            // 
            // btncreateobject
            // 
            this.btncreateobject.Location = new System.Drawing.Point(199, 47);
            this.btncreateobject.Name = "btncreateobject";
            this.btncreateobject.Size = new System.Drawing.Size(75, 52);
            this.btncreateobject.TabIndex = 19;
            this.btncreateobject.Text = "Create Object!";
            this.btncreateobject.UseVisualStyleBackColor = true;
            this.btncreateobject.Click += new System.EventHandler(this.btncreateobject_Click);
            // 
            // rtboxobjectsummary
            // 
            this.rtboxobjectsummary.Location = new System.Drawing.Point(22, 150);
            this.rtboxobjectsummary.Name = "rtboxobjectsummary";
            this.rtboxobjectsummary.Size = new System.Drawing.Size(228, 96);
            this.rtboxobjectsummary.TabIndex = 18;
            this.rtboxobjectsummary.Text = "";
            // 
            // lblobjectsummary
            // 
            this.lblobjectsummary.AutoSize = true;
            this.lblobjectsummary.Location = new System.Drawing.Point(22, 132);
            this.lblobjectsummary.Name = "lblobjectsummary";
            this.lblobjectsummary.Size = new System.Drawing.Size(96, 15);
            this.lblobjectsummary.TabIndex = 17;
            this.lblobjectsummary.Text = "Object Summary";
            // 
            // lblvalue
            // 
            this.lblvalue.AutoSize = true;
            this.lblvalue.Location = new System.Drawing.Point(142, 95);
            this.lblvalue.Name = "lblvalue";
            this.lblvalue.Size = new System.Drawing.Size(35, 15);
            this.lblvalue.TabIndex = 16;
            this.lblvalue.Text = "Value";
            // 
            // tboxobjectvalue
            // 
            this.tboxobjectvalue.Location = new System.Drawing.Point(22, 92);
            this.tboxobjectvalue.Name = "tboxobjectvalue";
            this.tboxobjectvalue.PlaceholderText = "Type Value Here...";
            this.tboxobjectvalue.Size = new System.Drawing.Size(114, 23);
            this.tboxobjectvalue.TabIndex = 15;
            // 
            // lblweight
            // 
            this.lblweight.AutoSize = true;
            this.lblweight.Location = new System.Drawing.Point(142, 66);
            this.lblweight.Name = "lblweight";
            this.lblweight.Size = new System.Drawing.Size(45, 15);
            this.lblweight.TabIndex = 14;
            this.lblweight.Text = "Weight";
            // 
            // tboxobjectweight
            // 
            this.tboxobjectweight.Location = new System.Drawing.Point(22, 63);
            this.tboxobjectweight.Name = "tboxobjectweight";
            this.tboxobjectweight.PlaceholderText = "Type Weight Here...";
            this.tboxobjectweight.Size = new System.Drawing.Size(114, 23);
            this.tboxobjectweight.TabIndex = 13;
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(142, 37);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(39, 15);
            this.lblname.TabIndex = 12;
            this.lblname.Text = "Name";
            // 
            // tboxobjectname
            // 
            this.tboxobjectname.Location = new System.Drawing.Point(22, 34);
            this.tboxobjectname.Name = "tboxobjectname";
            this.tboxobjectname.PlaceholderText = "Type Name Here...";
            this.tboxobjectname.Size = new System.Drawing.Size(114, 23);
            this.tboxobjectname.TabIndex = 11;
            // 
            // lboxsynonyms
            // 
            this.lboxsynonyms.FormattingEnabled = true;
            this.lboxsynonyms.ItemHeight = 15;
            this.lboxsynonyms.Location = new System.Drawing.Point(299, 92);
            this.lboxsynonyms.Name = "lboxsynonyms";
            this.lboxsynonyms.Size = new System.Drawing.Size(120, 154);
            this.lboxsynonyms.TabIndex = 21;
            // 
            // btnaddsynonym
            // 
            this.btnaddsynonym.Location = new System.Drawing.Point(299, 66);
            this.btnaddsynonym.Name = "btnaddsynonym";
            this.btnaddsynonym.Size = new System.Drawing.Size(53, 23);
            this.btnaddsynonym.TabIndex = 23;
            this.btnaddsynonym.Text = "Add";
            this.btnaddsynonym.UseVisualStyleBackColor = true;
            this.btnaddsynonym.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnremovesynonym
            // 
            this.btnremovesynonym.Location = new System.Drawing.Point(358, 66);
            this.btnremovesynonym.Name = "btnremovesynonym";
            this.btnremovesynonym.Size = new System.Drawing.Size(61, 23);
            this.btnremovesynonym.TabIndex = 24;
            this.btnremovesynonym.Text = "Remove";
            this.btnremovesynonym.UseVisualStyleBackColor = true;
            // 
            // tboxsynonyms
            // 
            this.tboxsynonyms.Location = new System.Drawing.Point(299, 37);
            this.tboxsynonyms.Name = "tboxsynonyms";
            this.tboxsynonyms.PlaceholderText = "Type Synonyms...";
            this.tboxsynonyms.Size = new System.Drawing.Size(120, 23);
            this.tboxsynonyms.TabIndex = 25;
            // 
            // EditObject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tboxsynonyms);
            this.Controls.Add(this.btnremovesynonym);
            this.Controls.Add(this.btnaddsynonym);
            this.Controls.Add(this.lboxsynonyms);
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
            this.Name = "EditObject";
            this.Size = new System.Drawing.Size(450, 285);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblobjectfields;
        private Button btncreateobject;
        private RichTextBox rtboxobjectsummary;
        private Label lblobjectsummary;
        private Label lblvalue;
        private TextBox tboxobjectvalue;
        private Label lblweight;
        private TextBox tboxobjectweight;
        private Label lblname;
        private TextBox tboxobjectname;
        private ListBox lboxsynonyms;
        private Button btnaddsynonym;
        private Button btnremovesynonym;
        private TextBox tboxsynonyms;
    }
}
