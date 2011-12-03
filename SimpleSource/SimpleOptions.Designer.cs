//SimpleSource - This incident source is an example of how to create a source plugin using the interfaces provided by Incident Watcher
//Copyright (C) 2011  comicalcow

//This program is free software; you can redistribute it and/or
//modify it under the terms of the GNU General Public License
//as published by the Free Software Foundation; either version 2
//of the License, or (at your option) any later version.

//This program is distributed in the hope that it will be useful,
//but WITHOUT ANY WARRANTY; without even the implied warranty of
//MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//GNU General Public License for more details.

//You should have received a copy of the GNU General Public License
//along with this program; if not, write to the Free Software
//Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301, USA.
namespace SimpleSource
{
    partial class SimpleOptions
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label8;
            System.Windows.Forms.Label label9;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.txtAppliances = new System.Windows.Forms.TextBox();
            this.txtRegion = new System.Windows.Forms.TextBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.txtType = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtSuburb = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(6, 16);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(21, 13);
            label1.TabIndex = 0;
            label1.Text = "ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(6, 42);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(44, 13);
            label2.TabIndex = 1;
            label2.Text = "Suburb:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(6, 68);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(48, 13);
            label3.TabIndex = 2;
            label3.Text = "Address:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(6, 94);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(34, 13);
            label4.TabIndex = 3;
            label4.Text = "Type:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(6, 120);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(40, 13);
            label5.TabIndex = 4;
            label5.Text = "Status:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(6, 146);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(44, 13);
            label6.TabIndex = 5;
            label6.Text = "Region:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(6, 172);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(62, 13);
            label8.TabIndex = 7;
            label8.Text = "Appliances:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(6, 198);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(30, 13);
            label9.TabIndex = 8;
            label9.Text = "Size:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSize);
            this.groupBox1.Controls.Add(this.txtAppliances);
            this.groupBox1.Controls.Add(this.txtRegion);
            this.groupBox1.Controls.Add(this.txtStatus);
            this.groupBox1.Controls.Add(this.txtType);
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Controls.Add(this.txtSuburb);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(label9);
            this.groupBox1.Controls.Add(label8);
            this.groupBox1.Controls.Add(label6);
            this.groupBox1.Controls.Add(label5);
            this.groupBox1.Controls.Add(label4);
            this.groupBox1.Controls.Add(label3);
            this.groupBox1.Controls.Add(label2);
            this.groupBox1.Controls.Add(label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(197, 224);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Values to Return";
            // 
            // txtSize
            // 
            this.txtSize.Location = new System.Drawing.Point(42, 195);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(138, 20);
            this.txtSize.TabIndex = 17;
            this.txtSize.Text = "Medium";
            // 
            // txtAppliances
            // 
            this.txtAppliances.Location = new System.Drawing.Point(74, 169);
            this.txtAppliances.Name = "txtAppliances";
            this.txtAppliances.Size = new System.Drawing.Size(106, 20);
            this.txtAppliances.TabIndex = 16;
            this.txtAppliances.Text = "7";
            // 
            // txtRegion
            // 
            this.txtRegion.Location = new System.Drawing.Point(56, 143);
            this.txtRegion.Name = "txtRegion";
            this.txtRegion.Size = new System.Drawing.Size(124, 20);
            this.txtRegion.TabIndex = 14;
            this.txtRegion.Text = "SIMPLEFB";
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(52, 117);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(128, 20);
            this.txtStatus.TabIndex = 13;
            this.txtStatus.Text = "Not Yet Under Control";
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(46, 91);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(134, 20);
            this.txtType.TabIndex = 12;
            this.txtType.Text = "Simple Fire";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(56, 65);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(124, 20);
            this.txtAddress.TabIndex = 11;
            this.txtAddress.Text = "23 Simple St";
            // 
            // txtSuburb
            // 
            this.txtSuburb.Location = new System.Drawing.Point(56, 39);
            this.txtSuburb.Name = "txtSuburb";
            this.txtSuburb.Size = new System.Drawing.Size(124, 20);
            this.txtSuburb.TabIndex = 10;
            this.txtSuburb.Text = "Simple Town";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(33, 13);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(147, 20);
            this.txtID.TabIndex = 9;
            this.txtID.Text = "90800995";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(134, 242);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SimpleOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 270);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SimpleOptions";
            this.ShowIcon = false;
            this.Text = "Simple Source Settings";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtSuburb;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.TextBox txtAppliances;
        private System.Windows.Forms.TextBox txtRegion;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.TextBox txtType;
    }
}