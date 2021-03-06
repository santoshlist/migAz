// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

namespace MigAz.UserControls
{
    partial class MigAzMigrationSourceSelection
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAmazonWebServices = new System.Windows.Forms.Button();
            this.btnAzure = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAmazonWebServices);
            this.groupBox1.Controls.Add(this.btnAzure);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(333, 227);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Migration Source";
            // 
            // btnAmazonWebServices
            // 
            this.btnAmazonWebServices.Enabled = false;
            this.btnAmazonWebServices.Location = new System.Drawing.Point(32, 129);
            this.btnAmazonWebServices.Name = "btnAmazonWebServices";
            this.btnAmazonWebServices.Size = new System.Drawing.Size(272, 45);
            this.btnAmazonWebServices.TabIndex = 2;
            this.btnAmazonWebServices.Text = "AWS (Under Development)";
            this.btnAmazonWebServices.UseVisualStyleBackColor = true;
            this.btnAmazonWebServices.Click += new System.EventHandler(this.btnAmazonWebServices_Click);
            // 
            // btnAzure
            // 
            this.btnAzure.Location = new System.Drawing.Point(32, 51);
            this.btnAzure.Name = "btnAzure";
            this.btnAzure.Size = new System.Drawing.Size(123, 45);
            this.btnAzure.TabIndex = 0;
            this.btnAzure.Text = "Azure";
            this.btnAzure.UseVisualStyleBackColor = true;
            this.btnAzure.Click += new System.EventHandler(this.btnAzure_Click);
            // 
            // MigAzMigrationSourceSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "MigAzMigrationSourceSelection";
            this.Size = new System.Drawing.Size(361, 663);
            this.Resize += new System.EventHandler(this.MigAzMigrationSourceSelection_Resize);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAzure;
        private System.Windows.Forms.Button btnAmazonWebServices;
    }
}

