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
            this.lblname = new System.Windows.Forms.Label();
            this.tboxobjectname = new System.Windows.Forms.TextBox();
            this.lboxsynonyms = new System.Windows.Forms.ListBox();
            this.btnaddsynonym = new System.Windows.Forms.Button();
            this.btnremovesynonym = new System.Windows.Forms.Button();
            this.tboxsynonyms = new System.Windows.Forms.TextBox();
            this.tboxdropchance = new System.Windows.Forms.TextBox();
            this.tboxVerbs = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lboxverbs = new System.Windows.Forms.ListBox();
            this.clboxverbs = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // lblobjectfields
            // 
            this.lblobjectfields.AutoSize = true;
            this.lblobjectfields.Location = new System.Drawing.Point(180, 71);
            this.lblobjectfields.Name = "lblobjectfields";
            this.lblobjectfields.Size = new System.Drawing.Size(68, 15);
            this.lblobjectfields.TabIndex = 20;
            this.lblobjectfields.Text = "Fill all fields";
            // 
            // btncreateobject
            // 
            this.btncreateobject.Location = new System.Drawing.Point(180, 18);
            this.btncreateobject.Name = "btncreateobject";
            this.btncreateobject.Size = new System.Drawing.Size(75, 52);
            this.btncreateobject.TabIndex = 19;
            this.btncreateobject.Text = "Create Object!";
            this.btncreateobject.UseVisualStyleBackColor = true;
            this.btncreateobject.Click += new System.EventHandler(this.btncreateobject_Click);
            // 
            // rtboxobjectsummary
            // 
            this.rtboxobjectsummary.Location = new System.Drawing.Point(3, 121);
            this.rtboxobjectsummary.Name = "rtboxobjectsummary";
            this.rtboxobjectsummary.Size = new System.Drawing.Size(228, 96);
            this.rtboxobjectsummary.TabIndex = 18;
            this.rtboxobjectsummary.Text = "";
            // 
            // lblobjectsummary
            // 
            this.lblobjectsummary.AutoSize = true;
            this.lblobjectsummary.Location = new System.Drawing.Point(3, 103);
            this.lblobjectsummary.Name = "lblobjectsummary";
            this.lblobjectsummary.Size = new System.Drawing.Size(96, 15);
            this.lblobjectsummary.TabIndex = 17;
            this.lblobjectsummary.Text = "Object Summary";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(123, 8);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(39, 15);
            this.lblname.TabIndex = 12;
            this.lblname.Text = "Name";
            // 
            // tboxobjectname
            // 
            this.tboxobjectname.Location = new System.Drawing.Point(3, 5);
            this.tboxobjectname.Name = "tboxobjectname";
            this.tboxobjectname.PlaceholderText = "Type Name Here...";
            this.tboxobjectname.Size = new System.Drawing.Size(114, 23);
            this.tboxobjectname.TabIndex = 11;
            // 
            // lboxsynonyms
            // 
            this.lboxsynonyms.FormattingEnabled = true;
            this.lboxsynonyms.ItemHeight = 15;
            this.lboxsynonyms.Location = new System.Drawing.Point(280, 63);
            this.lboxsynonyms.Name = "lboxsynonyms";
            this.lboxsynonyms.Size = new System.Drawing.Size(120, 154);
            this.lboxsynonyms.TabIndex = 21;
            // 
            // btnaddsynonym
            // 
            this.btnaddsynonym.Location = new System.Drawing.Point(280, 37);
            this.btnaddsynonym.Name = "btnaddsynonym";
            this.btnaddsynonym.Size = new System.Drawing.Size(53, 23);
            this.btnaddsynonym.TabIndex = 23;
            this.btnaddsynonym.Text = "Add";
            this.btnaddsynonym.UseVisualStyleBackColor = true;
            this.btnaddsynonym.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnremovesynonym
            // 
            this.btnremovesynonym.Location = new System.Drawing.Point(339, 37);
            this.btnremovesynonym.Name = "btnremovesynonym";
            this.btnremovesynonym.Size = new System.Drawing.Size(61, 23);
            this.btnremovesynonym.TabIndex = 24;
            this.btnremovesynonym.Text = "Remove";
            this.btnremovesynonym.UseVisualStyleBackColor = true;
            this.btnremovesynonym.Click += new System.EventHandler(this.btnremovesynonym_Click);
            // 
            // tboxsynonyms
            // 
            this.tboxsynonyms.Location = new System.Drawing.Point(280, 8);
            this.tboxsynonyms.Name = "tboxsynonyms";
            this.tboxsynonyms.PlaceholderText = "Type Keywords...";
            this.tboxsynonyms.Size = new System.Drawing.Size(120, 23);
            this.tboxsynonyms.TabIndex = 25;
            // 
            // tboxdropchance
            // 
            this.tboxdropchance.Location = new System.Drawing.Point(3, 223);
            this.tboxdropchance.Name = "tboxdropchance";
            this.tboxdropchance.PlaceholderText = "Type Drop Chance Here...";
            this.tboxdropchance.Size = new System.Drawing.Size(115, 23);
            this.tboxdropchance.TabIndex = 26;
            // 
            // tboxVerbs
            // 
            this.tboxVerbs.Location = new System.Drawing.Point(406, 8);
            this.tboxVerbs.Name = "tboxVerbs";
            this.tboxVerbs.PlaceholderText = "Type Verbs...";
            this.tboxVerbs.Size = new System.Drawing.Size(120, 23);
            this.tboxVerbs.TabIndex = 30;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(465, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(61, 23);
            this.button1.TabIndex = 29;
            this.button1.Text = "Remove";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(406, 37);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(53, 23);
            this.button2.TabIndex = 28;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lboxverbs
            // 
            this.lboxverbs.FormattingEnabled = true;
            this.lboxverbs.ItemHeight = 15;
            this.lboxverbs.Location = new System.Drawing.Point(406, 63);
            this.lboxverbs.Name = "lboxverbs";
            this.lboxverbs.Size = new System.Drawing.Size(120, 154);
            this.lboxverbs.TabIndex = 27;
            // 
            // clboxverbs
            // 
            this.clboxverbs.FormattingEnabled = true;
            this.clboxverbs.Location = new System.Drawing.Point(532, 5);
            this.clboxverbs.Name = "clboxverbs";
            this.clboxverbs.Size = new System.Drawing.Size(224, 220);
            this.clboxverbs.TabIndex = 31;
            // 
            // EditObject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.clboxverbs);
            this.Controls.Add(this.tboxVerbs);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lboxverbs);
            this.Controls.Add(this.tboxdropchance);
            this.Controls.Add(this.tboxsynonyms);
            this.Controls.Add(this.btnremovesynonym);
            this.Controls.Add(this.btnaddsynonym);
            this.Controls.Add(this.lboxsynonyms);
            this.Controls.Add(this.lblobjectfields);
            this.Controls.Add(this.btncreateobject);
            this.Controls.Add(this.rtboxobjectsummary);
            this.Controls.Add(this.lblobjectsummary);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.tboxobjectname);
            this.Name = "EditObject";
            this.Size = new System.Drawing.Size(769, 279);
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
        private TextBox tboxdropchance;
        private TextBox tboxVerbs;
        private Button button1;
        private Button button2;
        private ListBox lboxverbs;
        private CheckedListBox clboxverbs;
    }
}
