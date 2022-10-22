namespace AdventureMaker
{
    partial class EditRoom
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
            this.lbladdobjects = new System.Windows.Forms.Label();
            this.clboxaddobjects = new System.Windows.Forms.CheckedListBox();
            this.lblroomobjects = new System.Windows.Forms.Label();
            this.btneditroomobjects = new System.Windows.Forms.Button();
            this.btnremoveroomobject = new System.Windows.Forms.Button();
            this.btnaddroomobjects = new System.Windows.Forms.Button();
            this.lboxroomobjects = new System.Windows.Forms.ListBox();
            this.lbllongdescription = new System.Windows.Forms.Label();
            this.rtboxlongdescription = new System.Windows.Forms.RichTextBox();
            this.lblroomname = new System.Windows.Forms.Label();
            this.tboxroomname = new System.Windows.Forms.TextBox();
            this.lblshortdescription = new System.Windows.Forms.Label();
            this.rtboxshortdescription = new System.Windows.Forms.RichTextBox();
            this.lbladdplayers = new System.Windows.Forms.Label();
            this.clboxaddplayers = new System.Windows.Forms.CheckedListBox();
            this.lblroomplayers = new System.Windows.Forms.Label();
            this.btneditroomplayers = new System.Windows.Forms.Button();
            this.btnremoveroomplayers = new System.Windows.Forms.Button();
            this.btnaddplayers = new System.Windows.Forms.Button();
            this.lboxroomplayers = new System.Windows.Forms.ListBox();
            this.lblroomkeywords = new System.Windows.Forms.Label();
            this.lbladdrooms = new System.Windows.Forms.Label();
            this.clboxaddrooms = new System.Windows.Forms.CheckedListBox();
            this.lbladjacentrooms = new System.Windows.Forms.Label();
            this.btneditrooms = new System.Windows.Forms.Button();
            this.btnremoverooms = new System.Windows.Forms.Button();
            this.btnaddrooms = new System.Windows.Forms.Button();
            this.lboxadjacentrooms = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // tboxsynonyms
            // 
            this.tboxsynonyms.Location = new System.Drawing.Point(925, 384);
            this.tboxsynonyms.Name = "tboxsynonyms";
            this.tboxsynonyms.PlaceholderText = "Type Synonyms...";
            this.tboxsynonyms.Size = new System.Drawing.Size(120, 23);
            this.tboxsynonyms.TabIndex = 58;
            // 
            // btnremovesynonym
            // 
            this.btnremovesynonym.Location = new System.Drawing.Point(984, 413);
            this.btnremovesynonym.Name = "btnremovesynonym";
            this.btnremovesynonym.Size = new System.Drawing.Size(61, 23);
            this.btnremovesynonym.TabIndex = 57;
            this.btnremovesynonym.Text = "Remove";
            this.btnremovesynonym.UseVisualStyleBackColor = true;
            this.btnremovesynonym.Click += new System.EventHandler(this.btnremovesynonym_Click);
            // 
            // btnaddsynonym
            // 
            this.btnaddsynonym.Location = new System.Drawing.Point(925, 413);
            this.btnaddsynonym.Name = "btnaddsynonym";
            this.btnaddsynonym.Size = new System.Drawing.Size(53, 23);
            this.btnaddsynonym.TabIndex = 56;
            this.btnaddsynonym.Text = "Add";
            this.btnaddsynonym.UseVisualStyleBackColor = true;
            this.btnaddsynonym.Click += new System.EventHandler(this.btnaddsynonym_Click);
            // 
            // lboxsynonyms
            // 
            this.lboxsynonyms.FormattingEnabled = true;
            this.lboxsynonyms.ItemHeight = 15;
            this.lboxsynonyms.Location = new System.Drawing.Point(925, 439);
            this.lboxsynonyms.Name = "lboxsynonyms";
            this.lboxsynonyms.Size = new System.Drawing.Size(120, 154);
            this.lboxsynonyms.TabIndex = 55;
            // 
            // lbladdobjects
            // 
            this.lbladdobjects.AutoSize = true;
            this.lbladdobjects.Location = new System.Drawing.Point(465, 15);
            this.lbladdobjects.Name = "lbladdobjects";
            this.lbladdobjects.Size = new System.Drawing.Size(130, 15);
            this.lbladdobjects.TabIndex = 52;
            this.lbladdobjects.Text = "All objects you can add";
            // 
            // clboxaddobjects
            // 
            this.clboxaddobjects.FormattingEnabled = true;
            this.clboxaddobjects.Location = new System.Drawing.Point(393, 41);
            this.clboxaddobjects.Name = "clboxaddobjects";
            this.clboxaddobjects.Size = new System.Drawing.Size(268, 220);
            this.clboxaddobjects.TabIndex = 51;
            // 
            // lblroomobjects
            // 
            this.lblroomobjects.AutoSize = true;
            this.lblroomobjects.Location = new System.Drawing.Point(240, 15);
            this.lblroomobjects.Name = "lblroomobjects";
            this.lblroomobjects.Size = new System.Drawing.Size(82, 15);
            this.lblroomobjects.TabIndex = 50;
            this.lblroomobjects.Text = "Room Objects";
            // 
            // btneditroomobjects
            // 
            this.btneditroomobjects.Location = new System.Drawing.Point(222, 317);
            this.btneditroomobjects.Name = "btneditroomobjects";
            this.btneditroomobjects.Size = new System.Drawing.Size(57, 23);
            this.btneditroomobjects.TabIndex = 49;
            this.btneditroomobjects.Text = "Edit Item";
            this.btneditroomobjects.UseVisualStyleBackColor = true;
            this.btneditroomobjects.Click += new System.EventHandler(this.btneditinventory_Click);
            // 
            // btnremoveroomobject
            // 
            this.btnremoveroomobject.Location = new System.Drawing.Point(295, 317);
            this.btnremoveroomobject.Name = "btnremoveroomobject";
            this.btnremoveroomobject.Size = new System.Drawing.Size(61, 23);
            this.btnremoveroomobject.TabIndex = 48;
            this.btnremoveroomobject.Text = "Remove";
            this.btnremoveroomobject.UseVisualStyleBackColor = true;
            this.btnremoveroomobject.Click += new System.EventHandler(this.btnremoveinventory_Click);
            // 
            // btnaddroomobjects
            // 
            this.btnaddroomobjects.Location = new System.Drawing.Point(475, 267);
            this.btnaddroomobjects.Name = "btnaddroomobjects";
            this.btnaddroomobjects.Size = new System.Drawing.Size(104, 23);
            this.btnaddroomobjects.TabIndex = 47;
            this.btnaddroomobjects.Text = "Add Objects";
            this.btnaddroomobjects.UseVisualStyleBackColor = true;
            this.btnaddroomobjects.Click += new System.EventHandler(this.btnaddinventory_Click);
            // 
            // lboxroomobjects
            // 
            this.lboxroomobjects.FormattingEnabled = true;
            this.lboxroomobjects.ItemHeight = 15;
            this.lboxroomobjects.Location = new System.Drawing.Point(209, 41);
            this.lboxroomobjects.Name = "lboxroomobjects";
            this.lboxroomobjects.Size = new System.Drawing.Size(167, 259);
            this.lboxroomobjects.TabIndex = 46;
            // 
            // lbllongdescription
            // 
            this.lbllongdescription.AutoSize = true;
            this.lbllongdescription.Location = new System.Drawing.Point(13, 50);
            this.lbllongdescription.Name = "lbllongdescription";
            this.lbllongdescription.Size = new System.Drawing.Size(97, 15);
            this.lbllongdescription.TabIndex = 45;
            this.lbllongdescription.Text = "Long Description";
            this.lbllongdescription.Click += new System.EventHandler(this.lblplayersummary_Click);
            // 
            // rtboxlongdescription
            // 
            this.rtboxlongdescription.Location = new System.Drawing.Point(13, 68);
            this.rtboxlongdescription.Name = "rtboxlongdescription";
            this.rtboxlongdescription.Size = new System.Drawing.Size(176, 284);
            this.rtboxlongdescription.TabIndex = 44;
            this.rtboxlongdescription.Text = "";
            this.rtboxlongdescription.TextChanged += new System.EventHandler(this.rtboxsummary_TextChanged);
            // 
            // lblroomname
            // 
            this.lblroomname.AutoSize = true;
            this.lblroomname.Location = new System.Drawing.Point(119, 15);
            this.lblroomname.Name = "lblroomname";
            this.lblroomname.Size = new System.Drawing.Size(39, 15);
            this.lblroomname.TabIndex = 39;
            this.lblroomname.Text = "Name";
            // 
            // tboxroomname
            // 
            this.tboxroomname.Location = new System.Drawing.Point(13, 12);
            this.tboxroomname.Name = "tboxroomname";
            this.tboxroomname.Size = new System.Drawing.Size(100, 23);
            this.tboxroomname.TabIndex = 38;
            // 
            // lblshortdescription
            // 
            this.lblshortdescription.AutoSize = true;
            this.lblshortdescription.Location = new System.Drawing.Point(13, 355);
            this.lblshortdescription.Name = "lblshortdescription";
            this.lblshortdescription.Size = new System.Drawing.Size(98, 15);
            this.lblshortdescription.TabIndex = 59;
            this.lblshortdescription.Text = "Short Description";
            // 
            // rtboxshortdescription
            // 
            this.rtboxshortdescription.Location = new System.Drawing.Point(13, 373);
            this.rtboxshortdescription.Name = "rtboxshortdescription";
            this.rtboxshortdescription.Size = new System.Drawing.Size(374, 149);
            this.rtboxshortdescription.TabIndex = 60;
            this.rtboxshortdescription.Text = "";
            // 
            // lbladdplayers
            // 
            this.lbladdplayers.AutoSize = true;
            this.lbladdplayers.Location = new System.Drawing.Point(942, 15);
            this.lbladdplayers.Name = "lbladdplayers";
            this.lbladdplayers.Size = new System.Drawing.Size(129, 15);
            this.lbladdplayers.TabIndex = 67;
            this.lbladdplayers.Text = "All players you can add";
            // 
            // clboxaddplayers
            // 
            this.clboxaddplayers.FormattingEnabled = true;
            this.clboxaddplayers.Location = new System.Drawing.Point(870, 41);
            this.clboxaddplayers.Name = "clboxaddplayers";
            this.clboxaddplayers.Size = new System.Drawing.Size(268, 220);
            this.clboxaddplayers.TabIndex = 66;
            // 
            // lblroomplayers
            // 
            this.lblroomplayers.AutoSize = true;
            this.lblroomplayers.Location = new System.Drawing.Point(717, 15);
            this.lblroomplayers.Name = "lblroomplayers";
            this.lblroomplayers.Size = new System.Drawing.Size(79, 15);
            this.lblroomplayers.TabIndex = 65;
            this.lblroomplayers.Text = "Room Players";
            // 
            // btneditroomplayers
            // 
            this.btneditroomplayers.Location = new System.Drawing.Point(699, 317);
            this.btneditroomplayers.Name = "btneditroomplayers";
            this.btneditroomplayers.Size = new System.Drawing.Size(57, 23);
            this.btneditroomplayers.TabIndex = 64;
            this.btneditroomplayers.Text = "Edit Item";
            this.btneditroomplayers.UseVisualStyleBackColor = true;
            this.btneditroomplayers.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnremoveroomplayers
            // 
            this.btnremoveroomplayers.Location = new System.Drawing.Point(772, 317);
            this.btnremoveroomplayers.Name = "btnremoveroomplayers";
            this.btnremoveroomplayers.Size = new System.Drawing.Size(61, 23);
            this.btnremoveroomplayers.TabIndex = 63;
            this.btnremoveroomplayers.Text = "Remove";
            this.btnremoveroomplayers.UseVisualStyleBackColor = true;
            // 
            // btnaddplayers
            // 
            this.btnaddplayers.Location = new System.Drawing.Point(952, 267);
            this.btnaddplayers.Name = "btnaddplayers";
            this.btnaddplayers.Size = new System.Drawing.Size(104, 23);
            this.btnaddplayers.TabIndex = 62;
            this.btnaddplayers.Text = "Add Players";
            this.btnaddplayers.UseVisualStyleBackColor = true;
            this.btnaddplayers.Click += new System.EventHandler(this.btnaddplayers_Click);
            // 
            // lboxroomplayers
            // 
            this.lboxroomplayers.FormattingEnabled = true;
            this.lboxroomplayers.ItemHeight = 15;
            this.lboxroomplayers.Location = new System.Drawing.Point(686, 41);
            this.lboxroomplayers.Name = "lboxroomplayers";
            this.lboxroomplayers.Size = new System.Drawing.Size(167, 259);
            this.lboxroomplayers.TabIndex = 61;
            // 
            // lblroomkeywords
            // 
            this.lblroomkeywords.AutoSize = true;
            this.lblroomkeywords.Location = new System.Drawing.Point(938, 361);
            this.lblroomkeywords.Name = "lblroomkeywords";
            this.lblroomkeywords.Size = new System.Drawing.Size(93, 15);
            this.lblroomkeywords.TabIndex = 70;
            this.lblroomkeywords.Text = "Room Keywords";
            // 
            // lbladdrooms
            // 
            this.lbladdrooms.AutoSize = true;
            this.lbladdrooms.Location = new System.Drawing.Point(677, 350);
            this.lbladdrooms.Name = "lbladdrooms";
            this.lbladdrooms.Size = new System.Drawing.Size(126, 15);
            this.lbladdrooms.TabIndex = 77;
            this.lbladdrooms.Text = "All rooms you can add";
            // 
            // clboxaddrooms
            // 
            this.clboxaddrooms.FormattingEnabled = true;
            this.clboxaddrooms.Location = new System.Drawing.Point(606, 373);
            this.clboxaddrooms.Name = "clboxaddrooms";
            this.clboxaddrooms.Size = new System.Drawing.Size(268, 220);
            this.clboxaddrooms.TabIndex = 76;
            // 
            // lbladjacentrooms
            // 
            this.lbladjacentrooms.AutoSize = true;
            this.lbladjacentrooms.Location = new System.Drawing.Point(459, 350);
            this.lbladjacentrooms.Name = "lbladjacentrooms";
            this.lbladjacentrooms.Size = new System.Drawing.Size(94, 15);
            this.lbladjacentrooms.TabIndex = 75;
            this.lbladjacentrooms.Text = "Adjacent Rooms";
            // 
            // btneditrooms
            // 
            this.btneditrooms.Location = new System.Drawing.Point(436, 638);
            this.btneditrooms.Name = "btneditrooms";
            this.btneditrooms.Size = new System.Drawing.Size(57, 23);
            this.btneditrooms.TabIndex = 74;
            this.btneditrooms.Text = "Edit Item";
            this.btneditrooms.UseVisualStyleBackColor = true;
            // 
            // btnremoverooms
            // 
            this.btnremoverooms.Location = new System.Drawing.Point(509, 638);
            this.btnremoverooms.Name = "btnremoverooms";
            this.btnremoverooms.Size = new System.Drawing.Size(61, 23);
            this.btnremoverooms.TabIndex = 73;
            this.btnremoverooms.Text = "Remove";
            this.btnremoverooms.UseVisualStyleBackColor = true;
            // 
            // btnaddrooms
            // 
            this.btnaddrooms.Location = new System.Drawing.Point(688, 599);
            this.btnaddrooms.Name = "btnaddrooms";
            this.btnaddrooms.Size = new System.Drawing.Size(104, 23);
            this.btnaddrooms.TabIndex = 72;
            this.btnaddrooms.Text = "Add Rooms";
            this.btnaddrooms.UseVisualStyleBackColor = true;
            this.btnaddrooms.Click += new System.EventHandler(this.btnaddrooms_Click);
            // 
            // lboxadjacentrooms
            // 
            this.lboxadjacentrooms.FormattingEnabled = true;
            this.lboxadjacentrooms.ItemHeight = 15;
            this.lboxadjacentrooms.Location = new System.Drawing.Point(422, 373);
            this.lboxadjacentrooms.Name = "lboxadjacentrooms";
            this.lboxadjacentrooms.Size = new System.Drawing.Size(167, 259);
            this.lboxadjacentrooms.TabIndex = 71;
            // 
            // EditRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbladdrooms);
            this.Controls.Add(this.clboxaddrooms);
            this.Controls.Add(this.lbladjacentrooms);
            this.Controls.Add(this.btneditrooms);
            this.Controls.Add(this.btnremoverooms);
            this.Controls.Add(this.btnaddrooms);
            this.Controls.Add(this.lboxadjacentrooms);
            this.Controls.Add(this.lblroomkeywords);
            this.Controls.Add(this.lbladdplayers);
            this.Controls.Add(this.clboxaddplayers);
            this.Controls.Add(this.lblroomplayers);
            this.Controls.Add(this.btneditroomplayers);
            this.Controls.Add(this.btnremoveroomplayers);
            this.Controls.Add(this.btnaddplayers);
            this.Controls.Add(this.lboxroomplayers);
            this.Controls.Add(this.rtboxshortdescription);
            this.Controls.Add(this.lblshortdescription);
            this.Controls.Add(this.tboxsynonyms);
            this.Controls.Add(this.btnremovesynonym);
            this.Controls.Add(this.btnaddsynonym);
            this.Controls.Add(this.lboxsynonyms);
            this.Controls.Add(this.lbladdobjects);
            this.Controls.Add(this.clboxaddobjects);
            this.Controls.Add(this.lblroomobjects);
            this.Controls.Add(this.btneditroomobjects);
            this.Controls.Add(this.btnremoveroomobject);
            this.Controls.Add(this.btnaddroomobjects);
            this.Controls.Add(this.lboxroomobjects);
            this.Controls.Add(this.lbllongdescription);
            this.Controls.Add(this.rtboxlongdescription);
            this.Controls.Add(this.lblroomname);
            this.Controls.Add(this.tboxroomname);
            this.Name = "EditRoom";
            this.Size = new System.Drawing.Size(1153, 692);
            this.VisibleChanged += new System.EventHandler(this.EditRoom_VisibleChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tboxsynonyms;
        private Button btnremovesynonym;
        private Button btnaddsynonym;
        private ListBox lboxsynonyms;
        private Label lbladdobjects;
        private CheckedListBox clboxaddobjects;
        private Label lblroomobjects;
        private Button btneditinventory;
        private Button btnremoveinventory;
        private Button btnaddinventory;
        private ListBox lboxroomobjects;
        private Label lbllongdescription;
        private RichTextBox rtboxlongdescription;
        private Label lblroomname;
        private TextBox tboxroomname;
        private Label lblshortdescription;
        private RichTextBox rtboxshortdescription;
        private Label lbladdplayers;
        private CheckedListBox clboxaddplayers;
        private Label lblroomplayers;
        private Button button3;
        private Button button4;
        private Button btnaddplayers;
        private ListBox lboxroomplayers;
        private Label lblroomkeywords;
        private Label lbladdrooms;
        private CheckedListBox clboxaddrooms;
        private Label lbladjacentrooms;
        private Button button1;
        private Button button2;
        private Button btnaddrooms;
        private ListBox lboxadjacentrooms;
        private Button btneditroomobjects;
        private Button btnremoveroomobject;
        private Button btnaddroomobjects;
        private Button btneditroomplayers;
        private Button btnremoveroomplayers;
        private Button btneditrooms;
        private Button btnremoverooms;
    }
}
