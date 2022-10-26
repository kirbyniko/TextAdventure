namespace AdventureMaker
{
    partial class VerbForm
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
            this.editVerb1 = new AdventureMaker.EditVerb();
            this.SuspendLayout();
            // 
            // editVerb1
            // 
            this.editVerb1.Location = new System.Drawing.Point(3, 2);
            this.editVerb1.Name = "editVerb1";
            this.editVerb1.Size = new System.Drawing.Size(172, 354);
            this.editVerb1.TabIndex = 0;
            // 
            // VerbForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(185, 328);
            this.Controls.Add(this.editVerb1);
            this.Name = "VerbForm";
            this.Text = "VerbForm";
            this.ResumeLayout(false);

        }

        #endregion

        private EditVerb editVerb1;
    }
}