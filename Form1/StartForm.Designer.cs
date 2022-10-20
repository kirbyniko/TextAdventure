namespace Form1
{
    partial class StartForm
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
            this.tboxinputgamename = new System.Windows.Forms.TextBox();
            this.lblinputgamename = new System.Windows.Forms.Label();
            this.btncreategame = new System.Windows.Forms.Button();
            this.btneditgame = new System.Windows.Forms.Button();
            this.btnplaygame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tboxinputgamename
            // 
            this.tboxinputgamename.Location = new System.Drawing.Point(12, 38);
            this.tboxinputgamename.Name = "tboxinputgamename";
            this.tboxinputgamename.Size = new System.Drawing.Size(100, 23);
            this.tboxinputgamename.TabIndex = 0;
            // 
            // lblinputgamename
            // 
            this.lblinputgamename.AutoSize = true;
            this.lblinputgamename.Location = new System.Drawing.Point(23, 20);
            this.lblinputgamename.Name = "lblinputgamename";
            this.lblinputgamename.Size = new System.Drawing.Size(73, 15);
            this.lblinputgamename.TabIndex = 1;
            this.lblinputgamename.Text = "Game Name";
            // 
            // btncreategame
            // 
            this.btncreategame.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btncreategame.Location = new System.Drawing.Point(120, 12);
            this.btncreategame.Name = "btncreategame";
            this.btncreategame.Size = new System.Drawing.Size(220, 66);
            this.btncreategame.TabIndex = 2;
            this.btncreategame.Text = "Create Game";
            this.btncreategame.UseVisualStyleBackColor = true;
            this.btncreategame.Click += new System.EventHandler(this.btncreategame_Click);
            // 
            // btneditgame
            // 
            this.btneditgame.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btneditgame.Location = new System.Drawing.Point(12, 84);
            this.btneditgame.Name = "btneditgame";
            this.btneditgame.Size = new System.Drawing.Size(328, 66);
            this.btneditgame.TabIndex = 3;
            this.btneditgame.Text = "Edit Game";
            this.btneditgame.UseVisualStyleBackColor = true;
            this.btneditgame.Click += new System.EventHandler(this.btneditgame_Click);
            // 
            // btnplaygame
            // 
            this.btnplaygame.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnplaygame.Location = new System.Drawing.Point(12, 156);
            this.btnplaygame.Name = "btnplaygame";
            this.btnplaygame.Size = new System.Drawing.Size(328, 66);
            this.btnplaygame.TabIndex = 4;
            this.btnplaygame.Text = "Play Game";
            this.btnplaygame.UseVisualStyleBackColor = true;
            this.btnplaygame.Click += new System.EventHandler(this.btnplaygame_Click);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 238);
            this.Controls.Add(this.btnplaygame);
            this.Controls.Add(this.btneditgame);
            this.Controls.Add(this.btncreategame);
            this.Controls.Add(this.lblinputgamename);
            this.Controls.Add(this.tboxinputgamename);
            this.Name = "StartForm";
            this.Text = "StartForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tboxinputgamename;
        private Label lblinputgamename;
        private Button btncreategame;
        private Button btneditgame;
        private Button btnplaygame;
    }
}