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
            this.lblobjectfields.Location = new System.Drawing.Point(206, 95);
            this.lblobjectfields.Name = "lblobjectfields";
            this.lblobjectfields.Size = new System.Drawing.Size(88, 20);
            this.lblobjectfields.TabIndex = 20;
            this.lblobjectfields.Text = "Fill all fields";
            // 
            // btncreateobject
            // 
            this.btncreateobject.Location = new System.Drawing.Point(206, 24);
            this.btncreateobject.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btncreateobject.Name = "btncreateobject";
            this.btncreateobject.Size = new System.Drawing.Size(86, 69);
            this.btncreateobject.TabIndex = 19;
            this.btncreateobject.Text = "Create Object!";
            this.btncreateobject.UseVisualStyleBackColor = true;
            this.btncreateobject.Click += new System.EventHandler(this.btncreateobject_Click);
            // 
            // rtboxobjectsummary
            // 
            this.rtboxobjectsummary.Location = new System.Drawing.Point(3, 161);
            this.rtboxobjectsummary.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rtboxobjectsummary.Name = "rtboxobjectsummary";
            this.rtboxobjectsummary.Size = new System.Drawing.Size(260, 127);
            this.rtboxobjectsummary.TabIndex = 18;
            this.rtboxobjectsummary.Text = "";
            // 
            // lblobjectsummary
            // 
            this.lblobjectsummary.AutoSize = true;
            this.lblobjectsummary.Location = new System.Drawing.Point(3, 137);
            this.lblobjectsummary.Name = "lblobjectsummary";
            this.lblobjectsummary.Size = new System.Drawing.Size(119, 20);
            this.lblobjectsummary.TabIndex = 17;
            this.lblobjectsummary.Text = "Object Summary";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(141, 11);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(49, 20);
            this.lblname.TabIndex = 12;
            this.lblname.Text = "Name";
            // 
            // tboxobjectname
            // 
            this.tboxobjectname.Location = new System.Drawing.Point(3, 7);
            this.tboxobjectname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxobjectname.Name = "tboxobjectname";
            this.tboxobjectname.PlaceholderText = "Type Name Here...";
            this.tboxobjectname.Size = new System.Drawing.Size(130, 27);
            this.tboxobjectname.TabIndex = 11;
            // 
            // lboxsynonyms
            // 
            this.lboxsynonyms.FormattingEnabled = true;
            this.lboxsynonyms.ItemHeight = 20;
            this.lboxsynonyms.Location = new System.Drawing.Point(320, 84);
            this.lboxsynonyms.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lboxsynonyms.Name = "lboxsynonyms";
            this.lboxsynonyms.Size = new System.Drawing.Size(137, 204);
            this.lboxsynonyms.TabIndex = 21;
            // 
            // btnaddsynonym
            // 
            this.btnaddsynonym.Location = new System.Drawing.Point(320, 49);
            this.btnaddsynonym.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnaddsynonym.Name = "btnaddsynonym";
            this.btnaddsynonym.Size = new System.Drawing.Size(61, 31);
            this.btnaddsynonym.TabIndex = 23;
            this.btnaddsynonym.Text = "Add";
            this.btnaddsynonym.UseVisualStyleBackColor = true;
            this.btnaddsynonym.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnremovesynonym
            // 
            this.btnremovesynonym.Location = new System.Drawing.Point(387, 49);
            this.btnremovesynonym.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnremovesynonym.Name = "btnremovesynonym";
            this.btnremovesynonym.Size = new System.Drawing.Size(70, 31);
            this.btnremovesynonym.TabIndex = 24;
            this.btnremovesynonym.Text = "Remove";
            this.btnremovesynonym.UseVisualStyleBackColor = true;
            this.btnremovesynonym.Click += new System.EventHandler(this.btnremovesynonym_Click);
            // 
            // tboxsynonyms
            // 
            this.tboxsynonyms.Location = new System.Drawing.Point(320, 11);
            this.tboxsynonyms.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxsynonyms.Name = "tboxsynonyms";
            this.tboxsynonyms.PlaceholderText = "Type Keywords...";
            this.tboxsynonyms.Size = new System.Drawing.Size(137, 27);
            this.tboxsynonyms.TabIndex = 25;
            // 
            // tboxdropchance
            // 
            this.tboxdropchance.Location = new System.Drawing.Point(3, 297);
            this.tboxdropchance.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxdropchance.Name = "tboxdropchance";
            this.tboxdropchance.PlaceholderText = "Type Drop Chance Here...";
            this.tboxdropchance.Size = new System.Drawing.Size(131, 27);
            this.tboxdropchance.TabIndex = 26;
            // 
            // tboxVerbs
            // 
            this.tboxVerbs.Location = new System.Drawing.Point(464, 11);
            this.tboxVerbs.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxVerbs.Name = "tboxVerbs";
            this.tboxVerbs.PlaceholderText = "Type Verbs...";
            this.tboxVerbs.Size = new System.Drawing.Size(137, 27);
            this.tboxVerbs.TabIndex = 30;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(531, 49);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 31);
            this.button1.TabIndex = 29;
            this.button1.Text = "Remove";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(464, 49);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(61, 31);
            this.button2.TabIndex = 28;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lboxverbs
            // 
            this.lboxverbs.FormattingEnabled = true;
            this.lboxverbs.ItemHeight = 20;
            this.lboxverbs.Location = new System.Drawing.Point(464, 84);
            this.lboxverbs.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lboxverbs.Name = "lboxverbs";
            this.lboxverbs.Size = new System.Drawing.Size(137, 204);
            this.lboxverbs.TabIndex = 27;
            // 
            // clboxverbs
            // 
            this.clboxverbs.FormattingEnabled = true;
            this.clboxverbs.Location = new System.Drawing.Point(608, 7);
            this.clboxverbs.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.clboxverbs.Name = "clboxverbs";
            this.clboxverbs.Size = new System.Drawing.Size(255, 290);
            this.clboxverbs.TabIndex = 31;
            // 
            // EditObject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
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
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "EditObject";
            this.Size = new System.Drawing.Size(879, 372);
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
