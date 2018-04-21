﻿namespace BaseBallGameWindows
{
    partial class BaseGame
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
            this.tNumber1 = new System.Windows.Forms.TextBox();
            this.tNumber2 = new System.Windows.Forms.TextBox();
            this.tNumber3 = new System.Windows.Forms.TextBox();
            this.bInput = new System.Windows.Forms.Button();
            this.statusLable = new System.Windows.Forms.Label();
            this.bClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tNumber1
            // 
            this.tNumber1.Location = new System.Drawing.Point(12, 12);
            this.tNumber1.Name = "tNumber1";
            this.tNumber1.Size = new System.Drawing.Size(100, 21);
            this.tNumber1.TabIndex = 0;
            // 
            // tNumber2
            // 
            this.tNumber2.Location = new System.Drawing.Point(12, 39);
            this.tNumber2.Name = "tNumber2";
            this.tNumber2.Size = new System.Drawing.Size(100, 21);
            this.tNumber2.TabIndex = 1;
            // 
            // tNumber3
            // 
            this.tNumber3.Location = new System.Drawing.Point(12, 66);
            this.tNumber3.Name = "tNumber3";
            this.tNumber3.Size = new System.Drawing.Size(100, 21);
            this.tNumber3.TabIndex = 2;
            // 
            // bInput
            // 
            this.bInput.Location = new System.Drawing.Point(12, 94);
            this.bInput.Name = "bInput";
            this.bInput.Size = new System.Drawing.Size(100, 87);
            this.bInput.TabIndex = 3;
            this.bInput.Text = "Play";
            this.bInput.UseVisualStyleBackColor = true;
            this.bInput.Click += new System.EventHandler(this.bInput_Click);
            // 
            // statusLable
            // 
            this.statusLable.AutoSize = true;
            this.statusLable.Location = new System.Drawing.Point(137, 39);
            this.statusLable.Name = "statusLable";
            this.statusLable.Size = new System.Drawing.Size(67, 12);
            this.statusLable.TabIndex = 4;
            this.statusLable.Text = "Play Ball!!!";
            // 
            // bClear
            // 
            this.bClear.Location = new System.Drawing.Point(139, 94);
            this.bClear.Name = "bClear";
            this.bClear.Size = new System.Drawing.Size(80, 37);
            this.bClear.TabIndex = 5;
            this.bClear.Text = "Clear";
            this.bClear.UseVisualStyleBackColor = true;
            this.bClear.Click += new System.EventHandler(this.bClear_Click);
            // 
            // BaseGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 215);
            this.Controls.Add(this.bClear);
            this.Controls.Add(this.statusLable);
            this.Controls.Add(this.bInput);
            this.Controls.Add(this.tNumber3);
            this.Controls.Add(this.tNumber2);
            this.Controls.Add(this.tNumber1);
            this.Name = "BaseGame";
            this.Text = "BaseGame";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tNumber1;
        private System.Windows.Forms.TextBox tNumber2;
        private System.Windows.Forms.TextBox tNumber3;
        private System.Windows.Forms.Button bInput;
        private System.Windows.Forms.Label statusLable;
        private System.Windows.Forms.Button bClear;
    }
}