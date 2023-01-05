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
            this.lblRandomizedInfo = new System.Windows.Forms.Label();
            this.tboxminhealth = new System.Windows.Forms.TextBox();
            this.tboxMaxHealth = new System.Windows.Forms.TextBox();
            this.cboxmaincharacter = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btncreateplayer
            // 
            this.btncreateplayer.Location = new System.Drawing.Point(727, 413);
            this.btncreateplayer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btncreateplayer.Name = "btncreateplayer";
            this.btncreateplayer.Size = new System.Drawing.Size(186, 101);
            this.btncreateplayer.TabIndex = 32;
            this.btncreateplayer.Text = "Create Player!";
            this.btncreateplayer.UseVisualStyleBackColor = true;
            this.btncreateplayer.Click += new System.EventHandler(this.btncreateplayer_Click);
            // 
            // lbladdobjects
            // 
            this.lbladdobjects.AutoSize = true;
            this.lbladdobjects.Location = new System.Drawing.Point(521, 11);
            this.lbladdobjects.Name = "lbladdobjects";
            this.lbladdobjects.Size = new System.Drawing.Size(164, 20);
            this.lbladdobjects.TabIndex = 31;
            this.lbladdobjects.Text = "All objects you can add";
            // 
            // clboxaddobjects
            // 
            this.clboxaddobjects.FormattingEnabled = true;
            this.clboxaddobjects.Location = new System.Drawing.Point(439, 45);
            this.clboxaddobjects.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.clboxaddobjects.Name = "clboxaddobjects";
            this.clboxaddobjects.Size = new System.Drawing.Size(306, 290);
            this.clboxaddobjects.TabIndex = 30;
            // 
            // lblplayerinventory
            // 
            this.lblplayerinventory.AutoSize = true;
            this.lblplayerinventory.Location = new System.Drawing.Point(264, 11);
            this.lblplayerinventory.Name = "lblplayerinventory";
            this.lblplayerinventory.Size = new System.Drawing.Size(114, 20);
            this.lblplayerinventory.TabIndex = 29;
            this.lblplayerinventory.Text = "Player Inventory";
            // 
            // btneditinventory
            // 
            this.btneditinventory.Location = new System.Drawing.Point(243, 413);
            this.btneditinventory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btneditinventory.Name = "btneditinventory";
            this.btneditinventory.Size = new System.Drawing.Size(65, 31);
            this.btneditinventory.TabIndex = 28;
            this.btneditinventory.Text = "Edit Item";
            this.btneditinventory.UseVisualStyleBackColor = true;
            this.btneditinventory.Click += new System.EventHandler(this.btneditinventory_Click);
            // 
            // btnremoveinventory
            // 
            this.btnremoveinventory.Location = new System.Drawing.Point(327, 413);
            this.btnremoveinventory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnremoveinventory.Name = "btnremoveinventory";
            this.btnremoveinventory.Size = new System.Drawing.Size(70, 31);
            this.btnremoveinventory.TabIndex = 27;
            this.btnremoveinventory.Text = "Remove";
            this.btnremoveinventory.UseVisualStyleBackColor = true;
            this.btnremoveinventory.Click += new System.EventHandler(this.btnremoveinventory_Click);
            // 
            // btnaddinventory
            // 
            this.btnaddinventory.Location = new System.Drawing.Point(533, 347);
            this.btnaddinventory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnaddinventory.Name = "btnaddinventory";
            this.btnaddinventory.Size = new System.Drawing.Size(119, 31);
            this.btnaddinventory.TabIndex = 26;
            this.btnaddinventory.Text = "Add Objects";
            this.btnaddinventory.UseVisualStyleBackColor = true;
            this.btnaddinventory.Click += new System.EventHandler(this.btnaddinventory_Click);
            // 
            // lboxplayerinventory
            // 
            this.lboxplayerinventory.FormattingEnabled = true;
            this.lboxplayerinventory.ItemHeight = 20;
            this.lboxplayerinventory.Location = new System.Drawing.Point(229, 45);
            this.lboxplayerinventory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lboxplayerinventory.Name = "lboxplayerinventory";
            this.lboxplayerinventory.Size = new System.Drawing.Size(190, 344);
            this.lboxplayerinventory.TabIndex = 25;
            // 
            // lblplayersummary
            // 
            this.lblplayersummary.AutoSize = true;
            this.lblplayersummary.Location = new System.Drawing.Point(5, 124);
            this.lblplayersummary.Name = "lblplayersummary";
            this.lblplayersummary.Size = new System.Drawing.Size(71, 20);
            this.lblplayersummary.TabIndex = 24;
            this.lblplayersummary.Text = "Summary";
            // 
            // rtboxsummary
            // 
            this.rtboxsummary.Location = new System.Drawing.Point(5, 148);
            this.rtboxsummary.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rtboxsummary.Name = "rtboxsummary";
            this.rtboxsummary.Size = new System.Drawing.Size(201, 295);
            this.rtboxsummary.TabIndex = 23;
            this.rtboxsummary.Text = "";
            // 
            // lblplayerstrength
            // 
            this.lblplayerstrength.AutoSize = true;
            this.lblplayerstrength.Location = new System.Drawing.Point(126, 88);
            this.lblplayerstrength.Name = "lblplayerstrength";
            this.lblplayerstrength.Size = new System.Drawing.Size(65, 20);
            this.lblplayerstrength.TabIndex = 22;
            this.lblplayerstrength.Text = "Strength";
            // 
            // tboxplayerstrength
            // 
            this.tboxplayerstrength.Location = new System.Drawing.Point(5, 84);
            this.tboxplayerstrength.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxplayerstrength.Name = "tboxplayerstrength";
            this.tboxplayerstrength.Size = new System.Drawing.Size(114, 27);
            this.tboxplayerstrength.TabIndex = 21;
            // 
            // lblplayerhealth
            // 
            this.lblplayerhealth.AutoSize = true;
            this.lblplayerhealth.Location = new System.Drawing.Point(126, 49);
            this.lblplayerhealth.Name = "lblplayerhealth";
            this.lblplayerhealth.Size = new System.Drawing.Size(53, 20);
            this.lblplayerhealth.TabIndex = 20;
            this.lblplayerhealth.Text = "Health";
            // 
            // tboxplayerhealth
            // 
            this.tboxplayerhealth.Location = new System.Drawing.Point(5, 45);
            this.tboxplayerhealth.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxplayerhealth.Name = "tboxplayerhealth";
            this.tboxplayerhealth.Size = new System.Drawing.Size(114, 27);
            this.tboxplayerhealth.TabIndex = 19;
            // 
            // lblplayername
            // 
            this.lblplayername.AutoSize = true;
            this.lblplayername.Location = new System.Drawing.Point(126, 11);
            this.lblplayername.Name = "lblplayername";
            this.lblplayername.Size = new System.Drawing.Size(49, 20);
            this.lblplayername.TabIndex = 18;
            this.lblplayername.Text = "Name";
            // 
            // tboxplayername
            // 
            this.tboxplayername.Location = new System.Drawing.Point(5, 7);
            this.tboxplayername.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxplayername.Name = "tboxplayername";
            this.tboxplayername.Size = new System.Drawing.Size(114, 27);
            this.tboxplayername.TabIndex = 17;
            // 
            // tboxsynonyms
            // 
            this.tboxsynonyms.Location = new System.Drawing.Point(776, 51);
            this.tboxsynonyms.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxsynonyms.Name = "tboxsynonyms";
            this.tboxsynonyms.PlaceholderText = "Type Keywords...";
            this.tboxsynonyms.Size = new System.Drawing.Size(137, 27);
            this.tboxsynonyms.TabIndex = 37;
            // 
            // btnremovesynonym
            // 
            this.btnremovesynonym.Location = new System.Drawing.Point(843, 89);
            this.btnremovesynonym.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnremovesynonym.Name = "btnremovesynonym";
            this.btnremovesynonym.Size = new System.Drawing.Size(70, 31);
            this.btnremovesynonym.TabIndex = 36;
            this.btnremovesynonym.Text = "Remove";
            this.btnremovesynonym.UseVisualStyleBackColor = true;
            this.btnremovesynonym.Click += new System.EventHandler(this.btnremovesynonym_Click);
            // 
            // btnaddsynonym
            // 
            this.btnaddsynonym.Location = new System.Drawing.Point(776, 89);
            this.btnaddsynonym.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnaddsynonym.Name = "btnaddsynonym";
            this.btnaddsynonym.Size = new System.Drawing.Size(61, 31);
            this.btnaddsynonym.TabIndex = 35;
            this.btnaddsynonym.Text = "Add";
            this.btnaddsynonym.UseVisualStyleBackColor = true;
            this.btnaddsynonym.Click += new System.EventHandler(this.btnaddsynonym_Click);
            // 
            // lboxsynonyms
            // 
            this.lboxsynonyms.FormattingEnabled = true;
            this.lboxsynonyms.ItemHeight = 20;
            this.lboxsynonyms.Location = new System.Drawing.Point(776, 124);
            this.lboxsynonyms.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lboxsynonyms.Name = "lboxsynonyms";
            this.lboxsynonyms.Size = new System.Drawing.Size(137, 204);
            this.lboxsynonyms.TabIndex = 34;
            // 
            // comboxcurrentroom
            // 
            this.comboxcurrentroom.FormattingEnabled = true;
            this.comboxcurrentroom.Location = new System.Drawing.Point(547, 432);
            this.comboxcurrentroom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboxcurrentroom.Name = "comboxcurrentroom";
            this.comboxcurrentroom.Size = new System.Drawing.Size(138, 28);
            this.comboxcurrentroom.TabIndex = 38;
            // 
            // lblcurrentroom
            // 
            this.lblcurrentroom.AutoSize = true;
            this.lblcurrentroom.Location = new System.Drawing.Point(447, 436);
            this.lblcurrentroom.Name = "lblcurrentroom";
            this.lblcurrentroom.Size = new System.Drawing.Size(101, 20);
            this.lblcurrentroom.TabIndex = 39;
            this.lblcurrentroom.Text = "Current Room";
            // 
            // lblRandomizedInfo
            // 
            this.lblRandomizedInfo.AutoSize = true;
            this.lblRandomizedInfo.Location = new System.Drawing.Point(1005, 17);
            this.lblRandomizedInfo.Name = "lblRandomizedInfo";
            this.lblRandomizedInfo.Size = new System.Drawing.Size(189, 20);
            this.lblRandomizedInfo.TabIndex = 40;
            this.lblRandomizedInfo.Text = "Randomized Player Ranges";
            // 
            // tboxminhealth
            // 
            this.tboxminhealth.Location = new System.Drawing.Point(950, 64);
            this.tboxminhealth.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxminhealth.Name = "tboxminhealth";
            this.tboxminhealth.PlaceholderText = "Min. Health Here...";
            this.tboxminhealth.Size = new System.Drawing.Size(127, 27);
            this.tboxminhealth.TabIndex = 41;
            // 
            // tboxMaxHealth
            // 
            this.tboxMaxHealth.Location = new System.Drawing.Point(1102, 64);
            this.tboxMaxHealth.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxMaxHealth.Name = "tboxMaxHealth";
            this.tboxMaxHealth.PlaceholderText = "Max Health Here...";
            this.tboxMaxHealth.Size = new System.Drawing.Size(127, 27);
            this.tboxMaxHealth.TabIndex = 42;
            // 
            // cboxmaincharacter
            // 
            this.cboxmaincharacter.AutoSize = true;
            this.cboxmaincharacter.Location = new System.Drawing.Point(14, 454);
            this.cboxmaincharacter.Name = "cboxmaincharacter";
            this.cboxmaincharacter.Size = new System.Drawing.Size(141, 24);
            this.cboxmaincharacter.TabIndex = 43;
            this.cboxmaincharacter.Text = "This is the player";
            this.cboxmaincharacter.UseVisualStyleBackColor = true;
            // 
            // EditPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cboxmaincharacter);
            this.Controls.Add(this.tboxMaxHealth);
            this.Controls.Add(this.tboxminhealth);
            this.Controls.Add(this.lblRandomizedInfo);
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
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "EditPlayer";
            this.Size = new System.Drawing.Size(1280, 683);
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
        private Label lblRandomizedInfo;
        private TextBox tboxminhealth;
        private TextBox tboxMaxHealth;
        private CheckBox cboxmaincharacter;
    }
}
