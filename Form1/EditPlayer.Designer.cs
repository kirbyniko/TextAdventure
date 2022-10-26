namespace AdventureMaker
{
    partial class EditPlayer
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
            this.btncreateplayer = new System.Windows.Forms.Button();
            this.lbladdobjects = new System.Windows.Forms.Label();
            this.clboxaddobjects = new System.Windows.Forms.CheckedListBox();
            this.lblplayerinventory = new System.Windows.Forms.Label();
            this.btneditinventory = new System.Windows.Forms.Button();
            this.btnremoveinventory = new System.Windows.Forms.Button();
            this.btnaddinventory = new System.Windows.Forms.Button();
            this.lboxplayerinventory = new System.Windows.Forms.ListBox();
            this.lblplayersummary = new System.Windows.Forms.Label();
            this.rtboxsummary = new System.Windows.Forms.RichTextBox();
            this.lblplayerstrength = new System.Windows.Forms.Label();
            this.tboxplayerstrength = new System.Windows.Forms.TextBox();
            this.lblplayerhealth = new System.Windows.Forms.Label();
            this.tboxplayerhealth = new System.Windows.Forms.TextBox();
            this.lblplayername = new System.Windows.Forms.Label();
            this.tboxplayername = new System.Windows.Forms.TextBox();
            this.tboxsynonyms = new System.Windows.Forms.TextBox();
            this.btnremovesynonym = new System.Windows.Forms.Button();
            this.btnaddsynonym = new System.Windows.Forms.Button();
            this.lboxsynonyms = new System.Windows.Forms.ListBox();
            this.comboxcurrentroom = new System.Windows.Forms.ComboBox();
            this.lblcurrentroom = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btncreateplayer
            // 
            this.btncreateplayer.Location = new System.Drawing.Point(622, 310);
            this.btncreateplayer.Name = "btncreateplayer";
            this.btncreateplayer.Size = new System.Drawing.Size(163, 76);
            this.btncreateplayer.TabIndex = 32;
            this.btncreateplayer.Text = "Create Player!";
            this.btncreateplayer.UseVisualStyleBackColor = true;
            this.btncreateplayer.Click += new System.EventHandler(this.btncreateplayer_Click);
            // 
            // lbladdobjects
            // 
            this.lbladdobjects.AutoSize = true;
            this.lbladdobjects.Location = new System.Drawing.Point(456, 8);
            this.lbladdobjects.Name = "lbladdobjects";
            this.lbladdobjects.Size = new System.Drawing.Size(130, 15);
            this.lbladdobjects.TabIndex = 31;
            this.lbladdobjects.Text = "All objects you can add";
            // 
            // clboxaddobjects
            // 
            this.clboxaddobjects.FormattingEnabled = true;
            this.clboxaddobjects.Location = new System.Drawing.Point(384, 34);
            this.clboxaddobjects.Name = "clboxaddobjects";
            this.clboxaddobjects.Size = new System.Drawing.Size(268, 220);
            this.clboxaddobjects.TabIndex = 30;
            // 
            // lblplayerinventory
            // 
            this.lblplayerinventory.AutoSize = true;
            this.lblplayerinventory.Location = new System.Drawing.Point(231, 8);
            this.lblplayerinventory.Name = "lblplayerinventory";
            this.lblplayerinventory.Size = new System.Drawing.Size(92, 15);
            this.lblplayerinventory.TabIndex = 29;
            this.lblplayerinventory.Text = "Player Inventory";
            // 
            // btneditinventory
            // 
            this.btneditinventory.Location = new System.Drawing.Point(213, 310);
            this.btneditinventory.Name = "btneditinventory";
            this.btneditinventory.Size = new System.Drawing.Size(57, 23);
            this.btneditinventory.TabIndex = 28;
            this.btneditinventory.Text = "Edit Item";
            this.btneditinventory.UseVisualStyleBackColor = true;
            this.btneditinventory.Click += new System.EventHandler(this.btneditinventory_Click);
            // 
            // btnremoveinventory
            // 
            this.btnremoveinventory.Location = new System.Drawing.Point(286, 310);
            this.btnremoveinventory.Name = "btnremoveinventory";
            this.btnremoveinventory.Size = new System.Drawing.Size(61, 23);
            this.btnremoveinventory.TabIndex = 27;
            this.btnremoveinventory.Text = "Remove";
            this.btnremoveinventory.UseVisualStyleBackColor = true;
            this.btnremoveinventory.Click += new System.EventHandler(this.btnremoveinventory_Click);
            // 
            // btnaddinventory
            // 
            this.btnaddinventory.Location = new System.Drawing.Point(466, 260);
            this.btnaddinventory.Name = "btnaddinventory";
            this.btnaddinventory.Size = new System.Drawing.Size(104, 23);
            this.btnaddinventory.TabIndex = 26;
            this.btnaddinventory.Text = "Add Objects";
            this.btnaddinventory.UseVisualStyleBackColor = true;
            this.btnaddinventory.Click += new System.EventHandler(this.btnaddinventory_Click);
            // 
            // lboxplayerinventory
            // 
            this.lboxplayerinventory.FormattingEnabled = true;
            this.lboxplayerinventory.ItemHeight = 15;
            this.lboxplayerinventory.Location = new System.Drawing.Point(200, 34);
            this.lboxplayerinventory.Name = "lboxplayerinventory";
            this.lboxplayerinventory.Size = new System.Drawing.Size(167, 259);
            this.lboxplayerinventory.TabIndex = 25;
            // 
            // lblplayersummary
            // 
            this.lblplayersummary.AutoSize = true;
            this.lblplayersummary.Location = new System.Drawing.Point(4, 93);
            this.lblplayersummary.Name = "lblplayersummary";
            this.lblplayersummary.Size = new System.Drawing.Size(58, 15);
            this.lblplayersummary.TabIndex = 24;
            this.lblplayersummary.Text = "Summary";
            // 
            // rtboxsummary
            // 
            this.rtboxsummary.Location = new System.Drawing.Point(4, 111);
            this.rtboxsummary.Name = "rtboxsummary";
            this.rtboxsummary.Size = new System.Drawing.Size(176, 222);
            this.rtboxsummary.TabIndex = 23;
            this.rtboxsummary.Text = "";
            // 
            // lblplayerstrength
            // 
            this.lblplayerstrength.AutoSize = true;
            this.lblplayerstrength.Location = new System.Drawing.Point(110, 66);
            this.lblplayerstrength.Name = "lblplayerstrength";
            this.lblplayerstrength.Size = new System.Drawing.Size(52, 15);
            this.lblplayerstrength.TabIndex = 22;
            this.lblplayerstrength.Text = "Strength";
            // 
            // tboxplayerstrength
            // 
            this.tboxplayerstrength.Location = new System.Drawing.Point(4, 63);
            this.tboxplayerstrength.Name = "tboxplayerstrength";
            this.tboxplayerstrength.Size = new System.Drawing.Size(100, 23);
            this.tboxplayerstrength.TabIndex = 21;
            // 
            // lblplayerhealth
            // 
            this.lblplayerhealth.AutoSize = true;
            this.lblplayerhealth.Location = new System.Drawing.Point(110, 37);
            this.lblplayerhealth.Name = "lblplayerhealth";
            this.lblplayerhealth.Size = new System.Drawing.Size(42, 15);
            this.lblplayerhealth.TabIndex = 20;
            this.lblplayerhealth.Text = "Health";
            // 
            // tboxplayerhealth
            // 
            this.tboxplayerhealth.Location = new System.Drawing.Point(4, 34);
            this.tboxplayerhealth.Name = "tboxplayerhealth";
            this.tboxplayerhealth.Size = new System.Drawing.Size(100, 23);
            this.tboxplayerhealth.TabIndex = 19;
            // 
            // lblplayername
            // 
            this.lblplayername.AutoSize = true;
            this.lblplayername.Location = new System.Drawing.Point(110, 8);
            this.lblplayername.Name = "lblplayername";
            this.lblplayername.Size = new System.Drawing.Size(39, 15);
            this.lblplayername.TabIndex = 18;
            this.lblplayername.Text = "Name";
            // 
            // tboxplayername
            // 
            this.tboxplayername.Location = new System.Drawing.Point(4, 5);
            this.tboxplayername.Name = "tboxplayername";
            this.tboxplayername.Size = new System.Drawing.Size(100, 23);
            this.tboxplayername.TabIndex = 17;
            // 
            // tboxsynonyms
            // 
            this.tboxsynonyms.Location = new System.Drawing.Point(679, 38);
            this.tboxsynonyms.Name = "tboxsynonyms";
            this.tboxsynonyms.PlaceholderText = "Type Synonyms...";
            this.tboxsynonyms.Size = new System.Drawing.Size(120, 23);
            this.tboxsynonyms.TabIndex = 37;
            // 
            // btnremovesynonym
            // 
            this.btnremovesynonym.Location = new System.Drawing.Point(738, 67);
            this.btnremovesynonym.Name = "btnremovesynonym";
            this.btnremovesynonym.Size = new System.Drawing.Size(61, 23);
            this.btnremovesynonym.TabIndex = 36;
            this.btnremovesynonym.Text = "Remove";
            this.btnremovesynonym.UseVisualStyleBackColor = true;
            this.btnremovesynonym.Click += new System.EventHandler(this.btnremovesynonym_Click);
            // 
            // btnaddsynonym
            // 
            this.btnaddsynonym.Location = new System.Drawing.Point(679, 67);
            this.btnaddsynonym.Name = "btnaddsynonym";
            this.btnaddsynonym.Size = new System.Drawing.Size(53, 23);
            this.btnaddsynonym.TabIndex = 35;
            this.btnaddsynonym.Text = "Add";
            this.btnaddsynonym.UseVisualStyleBackColor = true;
            this.btnaddsynonym.Click += new System.EventHandler(this.btnaddsynonym_Click);
            // 
            // lboxsynonyms
            // 
            this.lboxsynonyms.FormattingEnabled = true;
            this.lboxsynonyms.ItemHeight = 15;
            this.lboxsynonyms.Location = new System.Drawing.Point(679, 93);
            this.lboxsynonyms.Name = "lboxsynonyms";
            this.lboxsynonyms.Size = new System.Drawing.Size(120, 154);
            this.lboxsynonyms.TabIndex = 34;
            // 
            // comboxcurrentroom
            // 
            this.comboxcurrentroom.FormattingEnabled = true;
            this.comboxcurrentroom.Location = new System.Drawing.Point(495, 311);
            this.comboxcurrentroom.Name = "comboxcurrentroom";
            this.comboxcurrentroom.Size = new System.Drawing.Size(121, 23);
            this.comboxcurrentroom.TabIndex = 38;
            // 
            // lblcurrentroom
            // 
            this.lblcurrentroom.AutoSize = true;
            this.lblcurrentroom.Location = new System.Drawing.Point(407, 314);
            this.lblcurrentroom.Name = "lblcurrentroom";
            this.lblcurrentroom.Size = new System.Drawing.Size(82, 15);
            this.lblcurrentroom.TabIndex = 39;
            this.lblcurrentroom.Text = "Current Room";
            // 
            // EditPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblcurrentroom);
            this.Controls.Add(this.comboxcurrentroom);
            this.Controls.Add(this.tboxsynonyms);
            this.Controls.Add(this.btnremovesynonym);
            this.Controls.Add(this.btnaddsynonym);
            this.Controls.Add(this.lboxsynonyms);
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
            this.Name = "EditPlayer";
            this.Size = new System.Drawing.Size(830, 431);
            this.Load += new System.EventHandler(this.EditPlayer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btncreateplayer;
        private Label lbladdobjects;
        private CheckedListBox clboxaddobjects;
        private Label lblplayerinventory;
        private Button btneditinventory;
        private Button btnremoveinventory;
        private Button btnaddinventory;
        private ListBox lboxplayerinventory;
        private Label lblplayersummary;
        private RichTextBox rtboxsummary;
        private Label lblplayerstrength;
        private TextBox tboxplayerstrength;
        private Label lblplayerhealth;
        private TextBox tboxplayerhealth;
        private Label lblplayername;
        private TextBox tboxplayername;
        private TextBox tboxsynonyms;
        private Button btnremovesynonym;
        private Button btnaddsynonym;
        private ListBox lboxsynonyms;
        private ComboBox comboxcurrentroom;
        private Label lblcurrentroom;
    }
}
