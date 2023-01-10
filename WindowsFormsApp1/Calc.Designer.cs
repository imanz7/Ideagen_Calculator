
namespace WindowsFormsApp1
{
    partial class Calc
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
            this.label1 = new System.Windows.Forms.Label();
            this.Calculate = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            this.Input = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(136, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please enter value";
            // 
            // Calculate
            // 
            this.Calculate.Location = new System.Drawing.Point(130, 288);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(155, 46);
            this.Calculate.TabIndex = 1;
            this.Calculate.Text = "Calculate";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(130, 340);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(155, 46);
            this.Reset.TabIndex = 2;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // Input
            // 
            this.Input.Location = new System.Drawing.Point(130, 203);
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(155, 26);
            this.Input.TabIndex = 3;
            // 
            // Calc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 524);
            this.Controls.Add(this.Input);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.label1);
            this.Name = "Calc";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.TextBox Input;
    }
}

