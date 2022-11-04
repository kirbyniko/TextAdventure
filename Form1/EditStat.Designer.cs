namespace AdventureMaker
{
    partial class EditStat
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
            this.editStats1 = new AdventureMaker.EditStats();
            this.SuspendLayout();
            // 
            // editStats1
            // 
            this.editStats1.Location = new System.Drawing.Point(1, 2);
            this.editStats1.Name = "editStats1";
            this.editStats1.Size = new System.Drawing.Size(393, 262);
            this.editStats1.TabIndex = 0;
            this.editStats1.Load += new System.EventHandler(this.editStats1_Load);
            // 
            // EditStat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 288);
            this.Controls.Add(this.editStats1);
            this.Name = "EditStat";
            this.Text = "EditStat";
            this.VisibleChanged += new System.EventHandler(this.EditStat_VisibleChanged);
            this.ResumeLayout(false);

        }

        #endregion

        private EditStats editStats1;
    }
}