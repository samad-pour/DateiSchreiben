namespace DateiSchreiben
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSchreiben = new System.Windows.Forms.Button();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSchreiben
            // 
            this.btnSchreiben.Location = new System.Drawing.Point(12, 35);
            this.btnSchreiben.Name = "btnSchreiben";
            this.btnSchreiben.Size = new System.Drawing.Size(188, 58);
            this.btnSchreiben.TabIndex = 0;
            this.btnSchreiben.Text = "Schreiben";
            this.btnSchreiben.UseVisualStyleBackColor = true;
            this.btnSchreiben.Click += new System.EventHandler(this.btnSchreiben_Click);
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(12, 120);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(344, 207);
            this.txtInput.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 335);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.btnSchreiben);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnSchreiben;
        private TextBox txtInput;
    }
}