﻿namespace AvaliacaoDesktop
{
    partial class frmPrincipalU
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
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(141, 96);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(166, 93);
            this.button2.TabIndex = 2;
            this.button2.Text = "Listar Avião";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(486, 245);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(166, 93);
            this.button3.TabIndex = 4;
            this.button3.Text = "Gerenciar Relatórios";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(141, 245);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(166, 93);
            this.button4.TabIndex = 5;
            this.button4.Text = "Gerenciar companhia";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(486, 96);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(166, 93);
            this.button5.TabIndex = 6;
            this.button5.Text = "Gerenciar Avião";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // frmPrincipalU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Name = "frmPrincipalU";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPrincipalU";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}