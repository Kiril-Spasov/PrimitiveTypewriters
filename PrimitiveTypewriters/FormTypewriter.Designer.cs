namespace PrimitiveTypewriters
{
    partial class FormTypewriter
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
            this.BtnCheckCost = new System.Windows.Forms.Button();
            this.TxtResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnCheckCost
            // 
            this.BtnCheckCost.Location = new System.Drawing.Point(50, 67);
            this.BtnCheckCost.Name = "BtnCheckCost";
            this.BtnCheckCost.Size = new System.Drawing.Size(191, 62);
            this.BtnCheckCost.TabIndex = 0;
            this.BtnCheckCost.Text = "Check Cost";
            this.BtnCheckCost.UseVisualStyleBackColor = true;
            this.BtnCheckCost.Click += new System.EventHandler(this.BtnCheckCost_Click);
            // 
            // TxtResult
            // 
            this.TxtResult.Location = new System.Drawing.Point(325, 67);
            this.TxtResult.Multiline = true;
            this.TxtResult.Name = "TxtResult";
            this.TxtResult.Size = new System.Drawing.Size(368, 334);
            this.TxtResult.TabIndex = 1;
            // 
            // FormTypewriter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TxtResult);
            this.Controls.Add(this.BtnCheckCost);
            this.Name = "FormTypewriter";
            this.Text = "Typewriter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCheckCost;
        private System.Windows.Forms.TextBox TxtResult;
    }
}

