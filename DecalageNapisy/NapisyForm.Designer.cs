/*    DecalageNapisy allows users to shift the time of SRT files, forward or backwards.
    Copyright (C) 2011  Louis Kottmann (louis.kottmann@gmail.com)

    This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program.  If not, see <http://www.gnu.org/licenses/>. 
 */

namespace DecalageNapisy
{
    partial class NapisyForm
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
            this.buttonLoad = new System.Windows.Forms.Button();
            this.textBoxLoad = new System.Windows.Forms.TextBox();
            this.textBoxDecaler = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelMs = new System.Windows.Forms.Label();
            this.buttonDecaler = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBoxPM = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonLoad
            // 
            this.buttonLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLoad.Location = new System.Drawing.Point(194, 16);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(75, 23);
            this.buttonLoad.TabIndex = 0;
            this.buttonLoad.Text = "Load subtitle";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // textBoxLoad
            // 
            this.textBoxLoad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxLoad.Enabled = false;
            this.textBoxLoad.Location = new System.Drawing.Point(9, 18);
            this.textBoxLoad.Name = "textBoxLoad";
            this.textBoxLoad.Size = new System.Drawing.Size(179, 20);
            this.textBoxLoad.TabIndex = 1;
            // 
            // textBoxDecaler
            // 
            this.textBoxDecaler.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDecaler.Location = new System.Drawing.Point(45, 19);
            this.textBoxDecaler.Name = "textBoxDecaler";
            this.textBoxDecaler.Size = new System.Drawing.Size(117, 20);
            this.textBoxDecaler.TabIndex = 2;
            this.textBoxDecaler.TextChanged += new System.EventHandler(this.textBoxDecaler_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.comboBoxPM);
            this.groupBox1.Controls.Add(this.labelMs);
            this.groupBox1.Controls.Add(this.buttonDecaler);
            this.groupBox1.Controls.Add(this.textBoxDecaler);
            this.groupBox1.Location = new System.Drawing.Point(3, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(276, 52);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Décalage";
            // 
            // labelMs
            // 
            this.labelMs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMs.AutoSize = true;
            this.labelMs.Location = new System.Drawing.Point(168, 22);
            this.labelMs.Name = "labelMs";
            this.labelMs.Size = new System.Drawing.Size(20, 13);
            this.labelMs.TabIndex = 4;
            this.labelMs.Text = "ms";
            // 
            // buttonDecaler
            // 
            this.buttonDecaler.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDecaler.Location = new System.Drawing.Point(194, 17);
            this.buttonDecaler.Name = "buttonDecaler";
            this.buttonDecaler.Size = new System.Drawing.Size(75, 23);
            this.buttonDecaler.TabIndex = 3;
            this.buttonDecaler.Text = "Décaler!";
            this.buttonDecaler.UseVisualStyleBackColor = true;
            this.buttonDecaler.Click += new System.EventHandler(this.buttonDecaler_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.textBoxLoad);
            this.groupBox2.Controls.Add(this.buttonLoad);
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(275, 44);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Napisy";
            // 
            // comboBoxPM
            // 
            this.comboBoxPM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBoxPM.FormattingEnabled = true;
            this.comboBoxPM.Items.AddRange(new object[] {
            "+",
            "-"});
            this.comboBoxPM.Location = new System.Drawing.Point(9, 19);
            this.comboBoxPM.Name = "comboBoxPM";
            this.comboBoxPM.Size = new System.Drawing.Size(30, 21);
            this.comboBoxPM.TabIndex = 5;
            this.comboBoxPM.SelectedIndexChanged += new System.EventHandler(this.comboBoxPM_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 112);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MinimumSize = new System.Drawing.Size(300, 150);
            this.Name = "MainForm";
            this.Text = "Decalage Napisy";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.TextBox textBoxLoad;
        private System.Windows.Forms.TextBox textBoxDecaler;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonDecaler;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelMs;
        private System.Windows.Forms.ComboBox comboBoxPM;
    }
}

