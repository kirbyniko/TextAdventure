namespace AdventureMaker
{
    partial class MakePlayer
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
            this.tboxplayername = new System.Windows.Forms.TextBox();
            this.lblplayername = new System.Windows.Forms.Label();
            this.tboxplayerhealth = new System.Windows.Forms.TextBox();
            this.lblplayerhealth = new System.Windows.Forms.Label();
            this.tboxplayerstrength = new System.Windows.Forms.TextBox();
            this.lblplayerstrength = new System.Windows.Forms.Label();
            this.rtboxsummary = new System.Windows.Forms.RichTextBox();
            this.lblplayersummary = new System.Windows.Forms.Label();
            this.lboxplayerinventory = new System.Windows.Forms.ListBox();
            this.btnaddinventory = new System.Windows.Forms.Button();
            this.btnremoveinventory = new System.Windows.Forms.Button();
            this.btneditinventory = new System.Windows.Forms.Button();
            this.lblplayerinventory = new System.Windows.Forms.Label();
            this.clboxaddobjects = new System.Windows.Forms.CheckedListBox();
            this.lbladdobjects = new System.Windows.Forms.Label();
            this.btncreateplayer = new System.Windows.Forms.Button();
            this.btnsaveplayer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tboxplayername
            // 
            this.tboxplayername.Location = new System.Drawing.Point(12, 15);
            this.tboxplayername.Name = "tboxplayername";
            this.tboxplayername.Size = new System.Drawing.Size(100, 23);
            this.tboxplayername.TabIndex = 0;
            // 
            // lblplayername
            // 
            this.lblplayername.AutoSize = true;
            this.lblplayername.Location = new System.Drawing.Point(118, 18);
            this.lblplayername.Name = "lblplayername";
            this.lblplayername.Size = new System.Drawing.Size(39, 15);
            this.lblplayername.TabIndex = 1;
            this.lblplayername.Text = "Name";
            // 
            // tboxplayerhealth
            // 
            this.tboxplayerhealth.Location = new System.Drawing.Point(12, 44);
            this.tboxplayerhealth.Name = "tboxplayerhealth";
            this.tboxplayerhealth.Size = new System.Drawing.Size(100, 23);
            this.tboxplayerhealth.TabIndex = 2;
            // 
            // lblplayerhealth
            // 
            this.lblplayerhealth.AutoSize = true;
            this.lblplayerhealth.Location = new System.Drawing.Point(118, 47);
            this.lblplayerhealth.Name = "lblplayerhealth";
            this.lblplayerhealth.Size = new System.Drawing.Size(42, 15);
            this.lblplayerhealth.TabIndex = 3;
            this.lblplayerhealth.Text = "Health";
            // 
            // tboxplayerstrength
            // 
            this.tboxplayerstrength.Location = new System.Drawing.Point(12, 73);
            this.tboxplayerstrength.Name = "tboxplayerstrength";
            this.tboxplayerstrength.Size = new System.Drawing.Size(100, 23);
            this.tboxplayerstrength.TabIndex = 4;
            // 
            // lblplayerstrength
            // 
            this.lblplayerstrength.AutoSize = true;
            this.lblplayerstrength.Location = new System.Drawing.Point(118, 76);
            this.lblplayerstrength.Name = "lblplayerstrength";
            this.lblplayerstrength.Size = new System.Drawing.Size(52, 15);
            this.lblplayerstrength.TabIndex = 5;
            this.lblplayerstrength.Text = "Strength";
            // 
            // rtboxsummary
            // 
            this.rtboxsummary.Location = new System.Drawing.Point(12, 121);
            this.rtboxsummary.Name = "rtboxsummary";
            this.rtboxsummary.Size = new System.Drawing.Size(176, 222);
            this.rtboxsummary.TabIndex = 6;
            this.rtboxsummary.Text = "";
            // 
            // lblplayersummary
            // 
            this.lblplayersummary.AutoSize = true;
            this.lblplayersummary.Location = new System.Drawing.Point(12, 103);
            this.lblplayersummary.Name = "lblplayersummary";
            this.lblplayersummary.Size = new System.Drawing.Size(58, 15);
            this.lblplayersummary.TabIndex = 7;
            this.lblplayersummary.Text = "Summary";
            // 
            // lboxplayerinventory
            // 
            this.lboxplayerinventory.FormattingEnabled = true;
            this.lboxplayerinventory.ItemHeight = 15;
            this.lboxplayerinventory.Location = new System.Drawing.Point(208, 44);
            this.lboxplayerinventory.Name = "lboxplayerinventory";
            this.lboxplayerinventory.Size = new System.Drawing.Size(167, 259);
            this.lboxplayerinventory.TabIndex = 8;
            this.lboxplayerinventory.SelectedIndexChanged += new System.EventHandler(this.lboxplayerinventory_SelectedIndexChanged);
            // 
            // btnaddinventory
            // 
            this.btnaddinventory.Location = new System.Drawing.Point(474, 270);
            this.btnaddinventory.Name = "btnaddinventory";
            this.btnaddinventory.Size = new System.Drawing.Size(104, 23);
            this.btnaddinventory.TabIndex = 9;
            this.btnaddinventory.Text = "Add Objects";
            this.btnaddinventory.UseVisualStyleBackColor = true;
            this.btnaddinventory.Click += new System.EventHandler(this.btnaddinventory_Click);
            // 
            // btnremoveinventory
            // 
            this.btnremoveinventory.Location = new System.Drawing.Point(294, 320);
            this.btnremoveinventory.Name = "btnremoveinventory";
            this.btnremoveinventory.Size = new System.Drawing.Size(61, 23);
            this.btnremoveinventory.TabIndex = 10;
            this.btnremoveinventory.Text = "Remove";
            this.btnremoveinventory.UseVisualStyleBackColor = true;
            this.btnremoveinventory.Click += new System.EventHandler(this.btnremoveinventory_Click);
            // 
            // btneditinventory
            // 
            this.btneditinventory.Location = new System.Drawing.Point(221, 320);
            this.btneditinventory.Name = "btneditinventory";
            this.btneditinventory.Size = new System.Drawing.Size(57, 23);
            this.btneditinventory.TabIndex = 11;
            this.btneditinventory.Text = "Edit Item";
            this.btneditinventory.UseVisualStyleBackColor = true;
            // 
            // lblplayerinventory
            // 
            this.lblplayerinventory.AutoSize = true;
            this.lblplayerinventory.Location = new System.Drawing.Point(239, 18);
            this.lblplayerinventory.Name = "lblplayerinventory";
            this.lblplayerinventory.Size = new System.Drawing.Size(92, 15);
            this.lblplayerinventory.TabIndex = 12;
            this.lblplayerinventory.Text = "Player Inventory";
            // 
            // clboxaddobjects
            // 
            this.clboxaddobjects.FormattingEnabled = true;
            this.clboxaddobjects.Location = new System.Drawing.Point(392, 44);
            this.clboxaddobjects.Name = "clboxaddobjects";
            this.clboxaddobjects.Size = new System.Drawing.Size(268, 220);
            this.clboxaddobjects.TabIndex = 13;
            // 
            // lbladdobjects
            // 
            this.lbladdobjects.AutoSize = true;
            this.lbladdobjects.Location = new System.Drawing.Point(464, 18);
            this.lbladdobjects.Name = "lbladdobjects";
            this.lbladdobjects.Size = new System.Drawing.Size(130, 15);
            this.lbladdobjects.TabIndex = 14;
            this.lbladdobjects.Text = "All objects you can add";
            // 
            // btncreateplayer
            // 
            this.btncreateplayer.Location = new System.Drawing.Point(451, 312);
            this.btncreateplayer.Name = "btncreateplayer";
            this.btncreateplayer.Size = new System.Drawing.Size(66, 39);
            this.btncreateplayer.TabIndex = 15;
            this.btncreateplayer.Text = "Create Player!";
            this.btncreateplayer.UseVisualStyleBackColor = true;
            this.btncreateplayer.Click += new System.EventHandler(this.btncreateplayer_Click);
            // 
            // btnsaveplayer
            // 
            this.btnsaveplayer.Location = new System.Drawing.Point(540, 312);
            this.btnsaveplayer.Name = "btnsaveplayer";
            this.btnsaveplayer.Size = new System.Drawing.Size(66, 39);
            this.btnsaveplayer.TabIndex = 16;
            this.btnsaveplayer.Text = "Save Player!";
            this.btnsaveplayer.UseVisualStyleBackColor = true;
            // 
            // MakePlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 371);
            this.Controls.Add(this.btnsaveplayer);
            this.Controls.Add(this.btncreateplayer);
            this.Controls.Add(this.lbladdobjects);
            this.Controls.Add(this.clboxaddobjects);
            this.Controls.Add(this.lblplayerinventory);
            this.Controls.Add(this.btneditinventory);
            this.Controls.Add(this.btnremoveinventory);
            this.Controls.Add(this.btnaddinventory);
            this.Controls.Add(this.lboxplayerinventory);
            this.Controls.Add(this.lblplayersummary);
            this.Controls.Add(this.rtboxsummary);
            this.Controls.Add(this.lblplayerstrength);
            this.Controls.Add(this.tboxplayerstrength);
            this.Controls.Add(this.lblplayerhealth);
            this.Controls.Add(this.tboxplayerhealth);
            this.Controls.Add(this.lblplayername);
            this.Controls.Add(this.tboxplayername);
            this.Name = "MakePlayer";
            this.Text = "MakePlayer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tboxplayername;
        private Label lblplayername;
        private TextBox tboxplayerhealth;
        private Label lblplayerhealth;
        private TextBox tboxplayerstrength;
        private Label lblplayerstrength;
        private RichTextBox rtboxsummary;
        private Label lblplayersummary;
        private ListBox lboxplayerinventory;
        private Button btnaddinventory;
        private Button btnremoveinventory;
        private Button btneditinventory;
        private Label lblplayerinventory;
        private CheckedListBox clboxaddobjects;
        private Label lbladdobjects;
        private Button btncreateplayer;
        private Button btnsaveplayer;
    }
}