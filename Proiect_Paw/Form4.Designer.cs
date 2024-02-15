namespace Proiect_Paw
{
    partial class Form4
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
            this.label2 = new System.Windows.Forms.Label();
            this.tbNumeControl = new System.Windows.Forms.TextBox();
            this.tbParolaControl = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Parola";
            // 
            // tbNumeControl
            // 
            this.tbNumeControl.Location = new System.Drawing.Point(125, 59);
            this.tbNumeControl.Name = "tbNumeControl";
            this.tbNumeControl.Size = new System.Drawing.Size(100, 22);
            this.tbNumeControl.TabIndex = 2;
            // 
            // tbParolaControl
            // 
            this.tbParolaControl.Location = new System.Drawing.Point(125, 101);
            this.tbParolaControl.Name = "tbParolaControl";
            this.tbParolaControl.Size = new System.Drawing.Size(100, 22);
            this.tbParolaControl.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(68, 212);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 33);
            this.button1.TabIndex = 4;
            this.button1.Text = "Baza de date";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 337);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbParolaControl);
            this.Controls.Add(this.tbNumeControl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNumeControl;
        private System.Windows.Forms.TextBox tbParolaControl;
        private System.Windows.Forms.Button button1;
    }
}