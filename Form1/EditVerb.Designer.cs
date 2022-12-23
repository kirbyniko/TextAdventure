namespace AdventureMaker
{
    partial class EditVerb
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
            this.tboxsynonyms = new System.Windows.Forms.TextBox();
            this.btnremovesynonym = new System.Windows.Forms.Button();
            this.btnaddsynonym = new System.Windows.Forms.Button();
            this.lboxsynonyms = new System.Windows.Forms.ListBox();
            this.btncreateverb = new System.Windows.Forms.Button();
            this.lblname = new System.Windows.Forms.Label();
            this.tboxverbname = new System.Windows.Forms.TextBox();
            this.lblfillfields = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tboxsynonyms
            // 
            this.tboxsynonyms.Location = new System.Drawing.Point(3, 35);
            this.tboxsynonyms.Name = "tboxsynonyms";
            this.tboxsynonyms.PlaceholderText = "Type Keywords...";
            this.tboxsynonyms.Size = new System.Drawing.Size(120, 23);
            this.tboxsynonyms.TabIndex = 29;
            // 
            // btnremovesynonym
            // 
            this.btnremovesynonym.Location = new System.Drawing.Point(62, 64);
            this.btnremovesynonym.Name = "btnremovesynonym";
            this.btnremovesynonym.Size = new System.Drawing.Size(61, 23);
            this.btnremovesynonym.TabIndex = 28;
            this.btnremovesynonym.Text = "Remove";
            this.btnremovesynonym.UseVisualStyleBackColor = true;
            this.btnremovesynonym.Click += new System.EventHandler(this.btnremovesynonym_Click);
            // 
            // btnaddsynonym
            // 
            this.btnaddsynonym.Location = new System.Drawing.Point(3, 64);
            this.btnaddsynonym.Name = "btnaddsynonym";
            this.btnaddsynonym.Size = new System.Drawing.Size(53, 23);
            this.btnaddsynonym.TabIndex = 27;
            this.btnaddsynonym.Text = "Add";
            this.btnaddsynonym.UseVisualStyleBackColor = true;
            this.btnaddsynonym.Click += new System.EventHandler(this.btnaddsynonym_Click);
            // 
            // lboxsynonyms
            // 
            this.lboxsynonyms.FormattingEnabled = true;
            this.lboxsynonyms.ItemHeight = 15;
            this.lboxsynonyms.Location = new System.Drawing.Point(3, 90);
            this.lboxsynonyms.Name = "lboxsynonyms";
            this.lboxsynonyms.Size = new System.Drawing.Size(120, 154);
            this.lboxsynonyms.TabIndex = 26;
            // 
            // btncreateverb
            // 
            this.btncreateverb.Location = new System.Drawing.Point(3, 250);
            this.btncreateverb.Name = "btncreateverb";
            this.btncreateverb.Size = new System.Drawing.Size(120, 52);
            this.btncreateverb.TabIndex = 32;
            this.btncreateverb.Text = "Create Verb!";
            this.btncreateverb.UseVisualStyleBackColor = true;
            this.btncreateverb.Click += new System.EventHandler(this.btncreateverb_Click);
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(123, 6);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(39, 15);
            this.lblname.TabIndex = 31;
            this.lblname.Text = "Name";
            // 
            // tboxverbname
            // 
            this.tboxverbname.Location = new System.Drawing.Point(3, 3);
            this.tboxverbname.Name = "tboxverbname";
            this.tboxverbname.PlaceholderText = "Type Name Here...";
            this.tboxverbname.Size = new System.Drawing.Size(114, 23);
            this.tboxverbname.TabIndex = 30;
            // 
            // lblfillfields
            // 
            this.lblfillfields.AutoSize = true;
            this.lblfillfields.Location = new System.Drawing.Point(3, 305);
            this.lblfillfields.Name = "lblfillfields";
            this.lblfillfields.Size = new System.Drawing.Size(0, 15);
            this.lblfillfields.TabIndex = 33;
            // 
            // EditVerb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblfillfields);
            this.Controls.Add(this.btncreateverb);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.tboxverbname);
            this.Controls.Add(this.tboxsynonyms);
            this.Controls.Add(this.btnremovesynonym);
            this.Controls.Add(this.btnaddsynonym);
            this.Controls.Add(this.lboxsynonyms);
            this.Name = "EditVerb";
            this.Size = new System.Drawing.Size(172, 354);
            this.Load += new System.EventHandler(this.EditVerb_Load);
            this.VisibleChanged += new System.EventHandler(this.EditVerb_VisibleChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tboxsynonyms;
        private Button btnremovesynonym;
        private Button btnaddsynonym;
        private ListBox lboxsynonyms;
        private Button btncreateverb;
        private Label lblname;
        private TextBox tboxverbname;
        private Label lblfillfields;
    }
}
