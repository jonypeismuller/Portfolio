﻿namespace UPVTube.GUI
{
    partial class Historial
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
            this.historial1 = new System.Windows.Forms.ListView();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "HISTORIAL";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // historial1
            // 
            this.historial1.HideSelection = false;
            this.historial1.Location = new System.Drawing.Point(37, 46);
            this.historial1.Name = "historial1";
            this.historial1.Size = new System.Drawing.Size(701, 358);
            this.historial1.TabIndex = 3;
            this.historial1.UseCompatibleStateImageBehavior = false;
            this.historial1.View = System.Windows.Forms.View.Details;
            this.historial1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // Historial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.historial1);
            this.Controls.Add(this.label1);
            this.Name = "Historial";
            this.Text = "Historial";
            this.Load += new System.EventHandler(this.Historial_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView historial1;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}