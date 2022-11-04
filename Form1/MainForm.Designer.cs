namespace Form1
{
    partial class MainForm
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
            this.lboxobjects = new System.Windows.Forms.ListBox();
            this.lblobjects = new System.Windows.Forms.Label();
            this.btnaddobject = new System.Windows.Forms.Button();
            this.btnremoveobject = new System.Windows.Forms.Button();
            this.btnremoverooms = new System.Windows.Forms.Button();
            this.btnaddrooms = new System.Windows.Forms.Button();
            this.lblverbs = new System.Windows.Forms.Label();
            this.lboxverbs = new System.Windows.Forms.ListBox();
            this.btnremoveverbs = new System.Windows.Forms.Button();
            this.btnaddverbs = new System.Windows.Forms.Button();
            this.lblplayers = new System.Windows.Forms.Label();
            this.lboxplayers = new System.Windows.Forms.ListBox();
            this.btnremoveplayers = new System.Windows.Forms.Button();
            this.btnaddplayers = new System.Windows.Forms.Button();
            this.lblrooms = new System.Windows.Forms.Label();
            this.lboxrooms = new System.Windows.Forms.ListBox();
            this.lblgamename = new System.Windows.Forms.Label();
            this.tboxgamename = new System.Windows.Forms.TextBox();
            this.btnsavename = new System.Windows.Forms.Button();
            this.btnsavegame = new System.Windows.Forms.Button();
            this.btneditobjects = new System.Windows.Forms.Button();
            this.btneditrooms = new System.Windows.Forms.Button();
            this.btneditplayers = new System.Windows.Forms.Button();
            this.btneditverbs = new System.Windows.Forms.Button();
            this.btneditstat = new System.Windows.Forms.Button();
            this.btnremovestat = new System.Windows.Forms.Button();
            this.btnaddstat = new System.Windows.Forms.Button();
            this.lblStats = new System.Windows.Forms.Label();
            this.lboxstats = new System.Windows.Forms.ListBox();
            this.btnPlayGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lboxobjects
            // 
            this.lboxobjects.FormattingEnabled = true;
            this.lboxobjects.ItemHeight = 15;
            this.lboxobjects.Location = new System.Drawing.Point(10, 93);
            this.lboxobjects.Name = "lboxobjects";
            this.lboxobjects.Size = new System.Drawing.Size(134, 199);
            this.lboxobjects.TabIndex = 0;
            // 
            // lblobjects
            // 
            this.lblobjects.AutoSize = true;
            this.lblobjects.Location = new System.Drawing.Point(53, 75);
            this.lblobjects.Name = "lblobjects";
            this.lblobjects.Size = new System.Drawing.Size(47, 15);
            this.lblobjects.TabIndex = 1;
            this.lblobjects.Text = "Objects";
            // 
            // btnaddobject
            // 
            this.btnaddobject.Location = new System.Drawing.Point(10, 298);
            this.btnaddobject.Name = "btnaddobject";
            this.btnaddobject.Size = new System.Drawing.Size(64, 23);
            this.btnaddobject.TabIndex = 2;
            this.btnaddobject.Text = "Add";
            this.btnaddobject.UseVisualStyleBackColor = true;
            this.btnaddobject.Click += new System.EventHandler(this.btnaddobject_Click);
            // 
            // btnremoveobject
            // 
            this.btnremoveobject.Location = new System.Drawing.Point(80, 298);
            this.btnremoveobject.Name = "btnremoveobject";
            this.btnremoveobject.Size = new System.Drawing.Size(64, 23);
            this.btnremoveobject.TabIndex = 3;
            this.btnremoveobject.Text = "Remove";
            this.btnremoveobject.UseVisualStyleBackColor = true;
            this.btnremoveobject.Click += new System.EventHandler(this.btnremoveobject_Click);
            // 
            // btnremoverooms
            // 
            this.btnremoverooms.Location = new System.Drawing.Point(229, 298);
            this.btnremoverooms.Name = "btnremoverooms";
            this.btnremoverooms.Size = new System.Drawing.Size(64, 23);
            this.btnremoverooms.TabIndex = 7;
            this.btnremoverooms.Text = "Remove";
            this.btnremoverooms.UseVisualStyleBackColor = true;
            // 
            // btnaddrooms
            // 
            this.btnaddrooms.Location = new System.Drawing.Point(159, 298);
            this.btnaddrooms.Name = "btnaddrooms";
            this.btnaddrooms.Size = new System.Drawing.Size(64, 23);
            this.btnaddrooms.TabIndex = 6;
            this.btnaddrooms.Text = "Add";
            this.btnaddrooms.UseVisualStyleBackColor = true;
            this.btnaddrooms.Click += new System.EventHandler(this.btnaddrooms_Click);
            // 
            // lblverbs
            // 
            this.lblverbs.AutoSize = true;
            this.lblverbs.Location = new System.Drawing.Point(502, 75);
            this.lblverbs.Name = "lblverbs";
            this.lblverbs.Size = new System.Drawing.Size(35, 15);
            this.lblverbs.TabIndex = 5;
            this.lblverbs.Text = "Verbs";
            this.lblverbs.Click += new System.EventHandler(this.lblitems_Click);
            // 
            // lboxverbs
            // 
            this.lboxverbs.FormattingEnabled = true;
            this.lboxverbs.ItemHeight = 15;
            this.lboxverbs.Location = new System.Drawing.Point(459, 93);
            this.lboxverbs.Name = "lboxverbs";
            this.lboxverbs.Size = new System.Drawing.Size(134, 199);
            this.lboxverbs.TabIndex = 4;
            // 
            // btnremoveverbs
            // 
            this.btnremoveverbs.Location = new System.Drawing.Point(529, 298);
            this.btnremoveverbs.Name = "btnremoveverbs";
            this.btnremoveverbs.Size = new System.Drawing.Size(64, 23);
            this.btnremoveverbs.TabIndex = 15;
            this.btnremoveverbs.Text = "Remove";
            this.btnremoveverbs.UseVisualStyleBackColor = true;
            this.btnremoveverbs.Click += new System.EventHandler(this.btnremoveverbs_Click);
            // 
            // btnaddverbs
            // 
            this.btnaddverbs.Location = new System.Drawing.Point(459, 298);
            this.btnaddverbs.Name = "btnaddverbs";
            this.btnaddverbs.Size = new System.Drawing.Size(64, 23);
            this.btnaddverbs.TabIndex = 14;
            this.btnaddverbs.Text = "Add";
            this.btnaddverbs.UseVisualStyleBackColor = true;
            this.btnaddverbs.Click += new System.EventHandler(this.btnaddverbs_Click);
            // 
            // lblplayers
            // 
            this.lblplayers.AutoSize = true;
            this.lblplayers.Location = new System.Drawing.Point(353, 75);
            this.lblplayers.Name = "lblplayers";
            this.lblplayers.Size = new System.Drawing.Size(44, 15);
            this.lblplayers.TabIndex = 13;
            this.lblplayers.Text = "Players";
            // 
            // lboxplayers
            // 
            this.lboxplayers.FormattingEnabled = true;
            this.lboxplayers.ItemHeight = 15;
            this.lboxplayers.Location = new System.Drawing.Point(310, 93);
            this.lboxplayers.Name = "lboxplayers";
            this.lboxplayers.Size = new System.Drawing.Size(134, 199);
            this.lboxplayers.TabIndex = 12;
            // 
            // btnremoveplayers
            // 
            this.btnremoveplayers.Location = new System.Drawing.Point(380, 298);
            this.btnremoveplayers.Name = "btnremoveplayers";
            this.btnremoveplayers.Size = new System.Drawing.Size(64, 23);
            this.btnremoveplayers.TabIndex = 11;
            this.btnremoveplayers.Text = "Remove";
            this.btnremoveplayers.UseVisualStyleBackColor = true;
            this.btnremoveplayers.Click += new System.EventHandler(this.btnremoveplayers_Click);
            // 
            // btnaddplayers
            // 
            this.btnaddplayers.Location = new System.Drawing.Point(310, 298);
            this.btnaddplayers.Name = "btnaddplayers";
            this.btnaddplayers.Size = new System.Drawing.Size(64, 23);
            this.btnaddplayers.TabIndex = 10;
            this.btnaddplayers.Text = "Add";
            this.btnaddplayers.UseVisualStyleBackColor = true;
            this.btnaddplayers.Click += new System.EventHandler(this.btnaddroom_Click);
            // 
            // lblrooms
            // 
            this.lblrooms.AutoSize = true;
            this.lblrooms.Location = new System.Drawing.Point(204, 75);
            this.lblrooms.Name = "lblrooms";
            this.lblrooms.Size = new System.Drawing.Size(44, 15);
            this.lblrooms.TabIndex = 9;
            this.lblrooms.Text = "Rooms";
            // 
            // lboxrooms
            // 
            this.lboxrooms.FormattingEnabled = true;
            this.lboxrooms.ItemHeight = 15;
            this.lboxrooms.Location = new System.Drawing.Point(161, 93);
            this.lboxrooms.Name = "lboxrooms";
            this.lboxrooms.Size = new System.Drawing.Size(134, 199);
            this.lboxrooms.TabIndex = 8;
            // 
            // lblgamename
            // 
            this.lblgamename.AutoSize = true;
            this.lblgamename.Location = new System.Drawing.Point(307, 9);
            this.lblgamename.Name = "lblgamename";
            this.lblgamename.Size = new System.Drawing.Size(73, 15);
            this.lblgamename.TabIndex = 16;
            this.lblgamename.Text = "Game Name";
            // 
            // tboxgamename
            // 
            this.tboxgamename.Location = new System.Drawing.Point(296, 28);
            this.tboxgamename.Name = "tboxgamename";
            this.tboxgamename.Size = new System.Drawing.Size(100, 23);
            this.tboxgamename.TabIndex = 17;
            this.tboxgamename.TextChanged += new System.EventHandler(this.tboxgamename_TextChanged);
            // 
            // btnsavename
            // 
            this.btnsavename.Location = new System.Drawing.Point(402, 28);
            this.btnsavename.Name = "btnsavename";
            this.btnsavename.Size = new System.Drawing.Size(88, 23);
            this.btnsavename.TabIndex = 18;
            this.btnsavename.Text = "Save Name";
            this.btnsavename.UseVisualStyleBackColor = true;
            this.btnsavename.Click += new System.EventHandler(this.btnsavename_Click);
            // 
            // btnsavegame
            // 
            this.btnsavegame.Location = new System.Drawing.Point(648, 12);
            this.btnsavegame.Name = "btnsavegame";
            this.btnsavegame.Size = new System.Drawing.Size(140, 51);
            this.btnsavegame.TabIndex = 19;
            this.btnsavegame.Text = "Save Game";
            this.btnsavegame.UseVisualStyleBackColor = true;
            this.btnsavegame.Click += new System.EventHandler(this.btnsavegame_Click);
            // 
            // btneditobjects
            // 
            this.btneditobjects.Location = new System.Drawing.Point(36, 327);
            this.btneditobjects.Name = "btneditobjects";
            this.btneditobjects.Size = new System.Drawing.Size(75, 23);
            this.btneditobjects.TabIndex = 20;
            this.btneditobjects.Text = "Edit";
            this.btneditobjects.UseVisualStyleBackColor = true;
            this.btneditobjects.Click += new System.EventHandler(this.btneditobjects_Click);
            // 
            // btneditrooms
            // 
            this.btneditrooms.Location = new System.Drawing.Point(190, 327);
            this.btneditrooms.Name = "btneditrooms";
            this.btneditrooms.Size = new System.Drawing.Size(75, 23);
            this.btneditrooms.TabIndex = 21;
            this.btneditrooms.Text = "Edit";
            this.btneditrooms.UseVisualStyleBackColor = true;
            this.btneditrooms.Click += new System.EventHandler(this.btneditrooms_Click);
            // 
            // btneditplayers
            // 
            this.btneditplayers.Location = new System.Drawing.Point(337, 327);
            this.btneditplayers.Name = "btneditplayers";
            this.btneditplayers.Size = new System.Drawing.Size(75, 23);
            this.btneditplayers.TabIndex = 22;
            this.btneditplayers.Text = "Edit";
            this.btneditplayers.UseVisualStyleBackColor = true;
            this.btneditplayers.Click += new System.EventHandler(this.btneditplayers_Click);
            // 
            // btneditverbs
            // 
            this.btneditverbs.Location = new System.Drawing.Point(485, 327);
            this.btneditverbs.Name = "btneditverbs";
            this.btneditverbs.Size = new System.Drawing.Size(75, 23);
            this.btneditverbs.TabIndex = 23;
            this.btneditverbs.Text = "Edit";
            this.btneditverbs.UseVisualStyleBackColor = true;
            this.btneditverbs.Click += new System.EventHandler(this.btneditverbs_Click);
            // 
            // btneditstat
            // 
            this.btneditstat.Location = new System.Drawing.Point(647, 327);
            this.btneditstat.Name = "btneditstat";
            this.btneditstat.Size = new System.Drawing.Size(75, 23);
            this.btneditstat.TabIndex = 28;
            this.btneditstat.Text = "Edit";
            this.btneditstat.UseVisualStyleBackColor = true;
            this.btneditstat.Click += new System.EventHandler(this.btneditstat_Click);
            // 
            // btnremovestat
            // 
            this.btnremovestat.Location = new System.Drawing.Point(691, 298);
            this.btnremovestat.Name = "btnremovestat";
            this.btnremovestat.Size = new System.Drawing.Size(64, 23);
            this.btnremovestat.TabIndex = 27;
            this.btnremovestat.Text = "Remove";
            this.btnremovestat.UseVisualStyleBackColor = true;
            this.btnremovestat.Click += new System.EventHandler(this.btnremovestat_Click);
            // 
            // btnaddstat
            // 
            this.btnaddstat.Location = new System.Drawing.Point(621, 298);
            this.btnaddstat.Name = "btnaddstat";
            this.btnaddstat.Size = new System.Drawing.Size(64, 23);
            this.btnaddstat.TabIndex = 26;
            this.btnaddstat.Text = "Add";
            this.btnaddstat.UseVisualStyleBackColor = true;
            this.btnaddstat.Click += new System.EventHandler(this.btnaddstat_Click);
            // 
            // lblStats
            // 
            this.lblStats.AutoSize = true;
            this.lblStats.Location = new System.Drawing.Point(664, 75);
            this.lblStats.Name = "lblStats";
            this.lblStats.Size = new System.Drawing.Size(32, 15);
            this.lblStats.TabIndex = 25;
            this.lblStats.Text = "Stats";
            // 
            // lboxstats
            // 
            this.lboxstats.FormattingEnabled = true;
            this.lboxstats.ItemHeight = 15;
            this.lboxstats.Location = new System.Drawing.Point(621, 93);
            this.lboxstats.Name = "lboxstats";
            this.lboxstats.Size = new System.Drawing.Size(134, 199);
            this.lboxstats.TabIndex = 24;
            // 
            // btnPlayGame
            // 
            this.btnPlayGame.Location = new System.Drawing.Point(502, 14);
            this.btnPlayGame.Name = "btnPlayGame";
            this.btnPlayGame.Size = new System.Drawing.Size(140, 51);
            this.btnPlayGame.TabIndex = 29;
            this.btnPlayGame.Text = "Play Game!";
            this.btnPlayGame.UseVisualStyleBackColor = true;
            this.btnPlayGame.Click += new System.EventHandler(this.btnPlayGame_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 527);
            this.Controls.Add(this.btnPlayGame);
            this.Controls.Add(this.btneditstat);
            this.Controls.Add(this.btnremovestat);
            this.Controls.Add(this.btnaddstat);
            this.Controls.Add(this.lblStats);
            this.Controls.Add(this.lboxstats);
            this.Controls.Add(this.btneditverbs);
            this.Controls.Add(this.btneditplayers);
            this.Controls.Add(this.btneditrooms);
            this.Controls.Add(this.btneditobjects);
            this.Controls.Add(this.btnsavegame);
            this.Controls.Add(this.btnsavename);
            this.Controls.Add(this.tboxgamename);
            this.Controls.Add(this.lblgamename);
            this.Controls.Add(this.btnremoveverbs);
            this.Controls.Add(this.btnaddverbs);
            this.Controls.Add(this.lblplayers);
            this.Controls.Add(this.lboxplayers);
            this.Controls.Add(this.btnremoveplayers);
            this.Controls.Add(this.btnaddplayers);
            this.Controls.Add(this.lblrooms);
            this.Controls.Add(this.lboxrooms);
            this.Controls.Add(this.btnremoverooms);
            this.Controls.Add(this.btnaddrooms);
            this.Controls.Add(this.lblverbs);
            this.Controls.Add(this.lboxverbs);
            this.Controls.Add(this.btnremoveobject);
            this.Controls.Add(this.btnaddobject);
            this.Controls.Add(this.lblobjects);
            this.Controls.Add(this.lboxobjects);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox lboxobjects;
        private Label lblobjects;
        private Button btnaddobject;
        private Button btnremoveobject;
        private Button btnremoverooms;
        private Button btnaddrooms;
        private Label lblitems;
        private ListBox lboxitems;
        private Button btnremoveverbs;
        private Button btnaddverbs;
        private Label lblplayers;
        private ListBox lboxplayers;
        private Button btnremoveplayers;
        private Button btnaddplayers;
        private Label lblrooms;
        private ListBox lboxrooms;
        private Label lblgamename;
        private TextBox tboxgamename;
        private Button btnsavename;
        private Label lblverbs;
        private ListBox lboxverbs;
        private Button btnsavegame;
        private Button btneditobjects;
        private Button btneditrooms;
        private Button btneditplayers;
        private Button btneditverbs;
        private Button btneditstat;
        private Button btnremovestat;
        private Button btnaddstat;
        private Label lblStats;
        private ListBox lboxstats;
        private Button btnPlayGame;
    }
}