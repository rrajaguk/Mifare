namespace MifareCalculator
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.InputKeyA = new System.Windows.Forms.TextBox();
            this.InputKeyB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PasswordResult = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(39, 76);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Generate Password!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Key A";
            // 
            // InputKeyA
            // 
            this.InputKeyA.Location = new System.Drawing.Point(90, 24);
            this.InputKeyA.MaxLength = 12;
            this.InputKeyA.Name = "InputKeyA";
            this.InputKeyA.Size = new System.Drawing.Size(113, 20);
            this.InputKeyA.TabIndex = 2;
            // 
            // InputKeyB
            // 
            this.InputKeyB.Location = new System.Drawing.Point(90, 50);
            this.InputKeyB.MaxLength = 12;
            this.InputKeyB.Name = "InputKeyB";
            this.InputKeyB.Size = new System.Drawing.Size(113, 20);
            this.InputKeyB.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Key B";
            // 
            // PasswordResult
            // 
            this.PasswordResult.Location = new System.Drawing.Point(90, 111);
            this.PasswordResult.Name = "PasswordResult";
            this.PasswordResult.Size = new System.Drawing.Size(113, 20);
            this.PasswordResult.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Password";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(215, 177);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PasswordResult);
            this.Controls.Add(this.InputKeyB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.InputKeyA);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Classic Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox InputKeyA;
        private System.Windows.Forms.TextBox InputKeyB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PasswordResult;
        private System.Windows.Forms.Label label3;
    }
}

