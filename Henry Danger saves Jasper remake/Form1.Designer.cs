namespace Henry_Danger_saves_Jasper_remake
{
    partial class Form1
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
            this.Tex = new System.Windows.Forms.TextBox();
            this.NameOfObject = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Tex
            // 
            this.Tex.BackColor = System.Drawing.Color.Cyan;
            this.Tex.Location = new System.Drawing.Point(666, 172);
            this.Tex.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Tex.Multiline = true;
            this.Tex.Name = "Tex";
            this.Tex.Size = new System.Drawing.Size(148, 32);
            this.Tex.TabIndex = 0;
            this.Tex.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NameOfObject
            // 
            this.NameOfObject.BackColor = System.Drawing.Color.White;
            this.NameOfObject.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NameOfObject.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameOfObject.Location = new System.Drawing.Point(0, 289);
            this.NameOfObject.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NameOfObject.Name = "NameOfObject";
            this.NameOfObject.Size = new System.Drawing.Size(417, 49);
            this.NameOfObject.TabIndex = 1;
            this.NameOfObject.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 703);
            this.Controls.Add(this.NameOfObject);
            this.Controls.Add(this.Tex);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Tex;
        private System.Windows.Forms.TextBox NameOfObject;
    }
}

