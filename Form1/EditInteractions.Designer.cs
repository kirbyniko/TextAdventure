namespace AdventureMaker
{
    partial class EditInteractions
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
            this.comboxverbs = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboxitems = new System.Windows.Forms.CheckBox();
            this.cboxplayers = new System.Windows.Forms.CheckBox();
            this.cboxrooms = new System.Windows.Forms.CheckBox();
            this.lblwhoeffected = new System.Windows.Forms.Label();
            this.lbldgvtitle = new System.Windows.Forms.Label();
            this.comboxSubjectType = new System.Windows.Forms.ComboBox();
            this.btnChoosenoun = new System.Windows.Forms.Button();
            this.btnChooseValue = new System.Windows.Forms.Button();
            this.lblEffectednoun = new System.Windows.Forms.Label();
            this.tboxValueOne = new System.Windows.Forms.TextBox();
            this.lblisequalto = new System.Windows.Forms.Label();
            this.tboxValueTwo = new System.Windows.Forms.TextBox();
            this.comboxOperators = new System.Windows.Forms.ComboBox();
            this.tboxValueThree = new System.Windows.Forms.TextBox();
            this.lblCreateInteraction = new System.Windows.Forms.Label();
            this.comboxSubject = new System.Windows.Forms.ComboBox();
            this.lblSubject = new System.Windows.Forms.Label();
            this.comboxChoosestat = new System.Windows.Forms.ComboBox();
            this.lblChooseStat = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnChooseValueThree = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboxverbs
            // 
            this.comboxverbs.FormattingEnabled = true;
            this.comboxverbs.Location = new System.Drawing.Point(47, 73);
            this.comboxverbs.Name = "comboxverbs";
            this.comboxverbs.Size = new System.Drawing.Size(121, 23);
            this.comboxverbs.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Choose a Verb!";
            // 
            // cboxitems
            // 
            this.cboxitems.AutoSize = true;
            this.cboxitems.Location = new System.Drawing.Point(192, 76);
            this.cboxitems.Name = "cboxitems";
            this.cboxitems.Size = new System.Drawing.Size(72, 19);
            this.cboxitems.TabIndex = 2;
            this.cboxitems.Text = "All Items";
            this.cboxitems.UseVisualStyleBackColor = true;
            // 
            // cboxplayers
            // 
            this.cboxplayers.AutoSize = true;
            this.cboxplayers.Location = new System.Drawing.Point(192, 100);
            this.cboxplayers.Name = "cboxplayers";
            this.cboxplayers.Size = new System.Drawing.Size(80, 19);
            this.cboxplayers.TabIndex = 3;
            this.cboxplayers.Text = "All Players";
            this.cboxplayers.UseVisualStyleBackColor = true;
            // 
            // cboxrooms
            // 
            this.cboxrooms.AutoSize = true;
            this.cboxrooms.Location = new System.Drawing.Point(192, 125);
            this.cboxrooms.Name = "cboxrooms";
            this.cboxrooms.Size = new System.Drawing.Size(80, 19);
            this.cboxrooms.TabIndex = 4;
            this.cboxrooms.Text = "All Rooms";
            this.cboxrooms.UseVisualStyleBackColor = true;
            // 
            // lblwhoeffected
            // 
            this.lblwhoeffected.AutoSize = true;
            this.lblwhoeffected.Location = new System.Drawing.Point(192, 55);
            this.lblwhoeffected.Name = "lblwhoeffected";
            this.lblwhoeffected.Size = new System.Drawing.Size(102, 15);
            this.lblwhoeffected.TabIndex = 6;
            this.lblwhoeffected.Text = "Who can it effect?";
            this.lblwhoeffected.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbldgvtitle
            // 
            this.lbldgvtitle.AutoSize = true;
            this.lbldgvtitle.Location = new System.Drawing.Point(333, 55);
            this.lbldgvtitle.Name = "lbldgvtitle";
            this.lbldgvtitle.Size = new System.Drawing.Size(116, 15);
            this.lbldgvtitle.TabIndex = 7;
            this.lbldgvtitle.Text = "Choose Subject Type";
            // 
            // comboxSubjectType
            // 
            this.comboxSubjectType.FormattingEnabled = true;
            this.comboxSubjectType.Location = new System.Drawing.Point(333, 76);
            this.comboxSubjectType.Name = "comboxSubjectType";
            this.comboxSubjectType.Size = new System.Drawing.Size(121, 23);
            this.comboxSubjectType.TabIndex = 8;
            this.comboxSubjectType.SelectedIndexChanged += new System.EventHandler(this.comboxInteractions_SelectedIndexChanged);
            // 
            // btnChoosenoun
            // 
            this.btnChoosenoun.Location = new System.Drawing.Point(538, 125);
            this.btnChoosenoun.Name = "btnChoosenoun";
            this.btnChoosenoun.Size = new System.Drawing.Size(128, 54);
            this.btnChoosenoun.TabIndex = 10;
            this.btnChoosenoun.Text = "Choose Value One!";
            this.btnChoosenoun.UseVisualStyleBackColor = true;
            // 
            // btnChooseValue
            // 
            this.btnChooseValue.Location = new System.Drawing.Point(305, 197);
            this.btnChooseValue.Name = "btnChooseValue";
            this.btnChooseValue.Size = new System.Drawing.Size(128, 54);
            this.btnChooseValue.TabIndex = 11;
            this.btnChooseValue.Text = "Choose Value Two!";
            this.btnChooseValue.UseVisualStyleBackColor = true;
            // 
            // lblEffectednoun
            // 
            this.lblEffectednoun.AutoSize = true;
            this.lblEffectednoun.Location = new System.Drawing.Point(36, 271);
            this.lblEffectednoun.Name = "lblEffectednoun";
            this.lblEffectednoun.Size = new System.Drawing.Size(84, 15);
            this.lblEffectednoun.TabIndex = 12;
            this.lblEffectednoun.Text = "Effected Value:";
            // 
            // tboxValueOne
            // 
            this.tboxValueOne.Location = new System.Drawing.Point(125, 268);
            this.tboxValueOne.Name = "tboxValueOne";
            this.tboxValueOne.PlaceholderText = "Value One...";
            this.tboxValueOne.Size = new System.Drawing.Size(100, 23);
            this.tboxValueOne.TabIndex = 13;
            // 
            // lblisequalto
            // 
            this.lblisequalto.AutoSize = true;
            this.lblisequalto.Location = new System.Drawing.Point(235, 272);
            this.lblisequalto.Name = "lblisequalto";
            this.lblisequalto.Size = new System.Drawing.Size(64, 15);
            this.lblisequalto.TabIndex = 14;
            this.lblisequalto.Text = "Is Equal to:";
            // 
            // tboxValueTwo
            // 
            this.tboxValueTwo.Location = new System.Drawing.Point(305, 268);
            this.tboxValueTwo.Name = "tboxValueTwo";
            this.tboxValueTwo.PlaceholderText = "Value Two...";
            this.tboxValueTwo.Size = new System.Drawing.Size(100, 23);
            this.tboxValueTwo.TabIndex = 15;
            // 
            // comboxOperators
            // 
            this.comboxOperators.FormattingEnabled = true;
            this.comboxOperators.Location = new System.Drawing.Point(411, 269);
            this.comboxOperators.Name = "comboxOperators";
            this.comboxOperators.Size = new System.Drawing.Size(121, 23);
            this.comboxOperators.TabIndex = 16;
            // 
            // tboxValueThree
            // 
            this.tboxValueThree.Location = new System.Drawing.Point(538, 269);
            this.tboxValueThree.Name = "tboxValueThree";
            this.tboxValueThree.PlaceholderText = "Value Three...";
            this.tboxValueThree.Size = new System.Drawing.Size(100, 23);
            this.tboxValueThree.TabIndex = 17;
            // 
            // lblCreateInteraction
            // 
            this.lblCreateInteraction.AutoSize = true;
            this.lblCreateInteraction.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCreateInteraction.Location = new System.Drawing.Point(281, 0);
            this.lblCreateInteraction.Name = "lblCreateInteraction";
            this.lblCreateInteraction.Size = new System.Drawing.Size(173, 28);
            this.lblCreateInteraction.TabIndex = 19;
            this.lblCreateInteraction.Text = "Create Interaction!";
            // 
            // comboxSubject
            // 
            this.comboxSubject.FormattingEnabled = true;
            this.comboxSubject.Location = new System.Drawing.Point(538, 76);
            this.comboxSubject.Name = "comboxSubject";
            this.comboxSubject.Size = new System.Drawing.Size(121, 23);
            this.comboxSubject.TabIndex = 21;
            this.comboxSubject.SelectedIndexChanged += new System.EventHandler(this.comboxSpecificObject_SelectedIndexChanged);
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Location = new System.Drawing.Point(538, 55);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(132, 15);
            this.lblSubject.TabIndex = 20;
            this.lblSubject.Text = "Choose Specific Object!";
            // 
            // comboxChoosestat
            // 
            this.comboxChoosestat.FormattingEnabled = true;
            this.comboxChoosestat.Location = new System.Drawing.Point(333, 137);
            this.comboxChoosestat.Name = "comboxChoosestat";
            this.comboxChoosestat.Size = new System.Drawing.Size(121, 23);
            this.comboxChoosestat.TabIndex = 23;
            // 
            // lblChooseStat
            // 
            this.lblChooseStat.AutoSize = true;
            this.lblChooseStat.Location = new System.Drawing.Point(333, 116);
            this.lblChooseStat.Name = "lblChooseStat";
            this.lblChooseStat.Size = new System.Drawing.Size(70, 15);
            this.lblChooseStat.TabIndex = 22;
            this.lblChooseStat.Text = "Choose Stat";
            // 
            // btnChooseValueThree
            // 
            this.btnChooseValueThree.Location = new System.Drawing.Point(538, 197);
            this.btnChooseValueThree.Name = "btnChooseValueThree";
            this.btnChooseValueThree.Size = new System.Drawing.Size(128, 54);
            this.btnChooseValueThree.TabIndex = 24;
            this.btnChooseValueThree.Text = "Choose Value Three!";
            this.btnChooseValueThree.UseVisualStyleBackColor = true;
            // 
            // EditInteractions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnChooseValueThree);
            this.Controls.Add(this.comboxChoosestat);
            this.Controls.Add(this.lblChooseStat);
            this.Controls.Add(this.comboxSubject);
            this.Controls.Add(this.lblSubject);
            this.Controls.Add(this.lblCreateInteraction);
            this.Controls.Add(this.tboxValueThree);
            this.Controls.Add(this.comboxOperators);
            this.Controls.Add(this.tboxValueTwo);
            this.Controls.Add(this.lblisequalto);
            this.Controls.Add(this.tboxValueOne);
            this.Controls.Add(this.lblEffectednoun);
            this.Controls.Add(this.btnChooseValue);
            this.Controls.Add(this.btnChoosenoun);
            this.Controls.Add(this.comboxSubjectType);
            this.Controls.Add(this.lbldgvtitle);
            this.Controls.Add(this.lblwhoeffected);
            this.Controls.Add(this.cboxrooms);
            this.Controls.Add(this.cboxplayers);
            this.Controls.Add(this.cboxitems);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboxverbs);
            this.Name = "EditInteractions";
            this.Size = new System.Drawing.Size(811, 374);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox comboxverbs;
        private Label label1;
        private CheckBox cboxitems;
        private CheckBox cboxplayers;
        private CheckBox cboxrooms;
        private Label lblwhoeffected;
        private Label lbldgvtitle;
        private ComboBox comboxSubjectType;
        private Button btnChoosenoun;
        private Button btnChooseValue;
        private Label lblEffectednoun;
        private TextBox tboxValueOne;
        private Label lblisequalto;
        private TextBox tboxValueTwo;
        private ComboBox comboxOperators;
        private TextBox tboxValueThree;
        private Label lblCreateInteraction;
        private ComboBox comboxSubject;
        private Label lblSubject;
        private ComboBox comboxChoosestat;
        private Label lblChooseStat;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button btnChooseValueThree;
    }
}
