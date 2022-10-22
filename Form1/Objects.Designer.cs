namespace Form1
{
    partial class Objects
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
            this.pnleditobjects = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnleditobjects
            // 
            this.pnleditobjects.Location = new System.Drawing.Point(21, 12);
            this.pnleditobjects.Name = "pnleditobjects";
            this.pnleditobjects.Size = new System.Drawing.Size(550, 278);
            this.pnleditobjects.TabIndex = 0;
            // 
            // Objects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 388);
            this.Controls.Add(this.pnleditobjects);
            this.Name = "Objects";
            this.Text = "Objects";
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private Panel pnleditobjects;
    }
}