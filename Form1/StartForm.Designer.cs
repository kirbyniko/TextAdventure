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
            this.btncreategame = new System.Windows.Forms.Button();
            this.btneditgame = new System.Windows.Forms.Button();
            this.btnplaygame = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnChooseExistingGame = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btncreategame
            // 
            this.btncreategame.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btncreategame.Location = new System.Drawing.Point(12, 165);
            this.btncreategame.Name = "btncreategame";
            this.btncreategame.Size = new System.Drawing.Size(328, 66);
            this.btncreategame.TabIndex = 2;
            this.btncreategame.Text = "Create Game";
            this.btncreategame.UseVisualStyleBackColor = true;
            this.btncreategame.Click += new System.EventHandler(this.btncreategame_Click);
            // 
            // btneditgame
            // 
            this.btneditgame.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btneditgame.Location = new System.Drawing.Point(12, 237);
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
            this.btnplaygame.Location = new System.Drawing.Point(12, 309);
            this.btnplaygame.Name = "btnplaygame";
            this.btnplaygame.Size = new System.Drawing.Size(328, 66);
            this.btnplaygame.TabIndex = 4;
            this.btnplaygame.Text = "Play Game";
            this.btnplaygame.UseVisualStyleBackColor = true;
            this.btnplaygame.Click += new System.EventHandler(this.btnplaygame_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(52, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 30);
            this.label1.TabIndex = 5;
            this.label1.Text = "Adventure Game Maker";
            // 
            // btnChooseExistingGame
            // 
            this.btnChooseExistingGame.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnChooseExistingGame.Location = new System.Drawing.Point(12, 42);
            this.btnChooseExistingGame.Name = "btnChooseExistingGame";
            this.btnChooseExistingGame.Size = new System.Drawing.Size(328, 66);
            this.btnChooseExistingGame.TabIndex = 8;
            this.btnChooseExistingGame.Text = "Choose Existing Game";
            this.btnChooseExistingGame.UseVisualStyleBackColor = true;
            this.btnChooseExistingGame.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(245, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Chosen File: No File Chosen";
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 394);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnChooseExistingGame);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnplaygame);
            this.Controls.Add(this.btneditgame);
            this.Controls.Add(this.btncreategame);
            this.Name = "StartForm";
            this.Text = "StartForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btncreategame;
        private Button btneditgame;
        private Button btnplaygame;
        private Label label1;
        private Button btnChooseExistingGame;
        private Label label2;
    }
}