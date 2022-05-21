namespace Haversine
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
            this.cmdCheck = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.GeoFence = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtR = new System.Windows.Forms.TextBox();
            this.txtLong = new System.Windows.Forms.TextBox();
            this.txtLat = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtQLong = new System.Windows.Forms.TextBox();
            this.txtQLat = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblResults = new System.Windows.Forms.Label();
            this.GeoFence.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdCheck
            // 
            this.cmdCheck.Location = new System.Drawing.Point(319, 171);
            this.cmdCheck.Margin = new System.Windows.Forms.Padding(4);
            this.cmdCheck.Name = "cmdCheck";
            this.cmdCheck.Size = new System.Drawing.Size(100, 34);
            this.cmdCheck.TabIndex = 0;
            this.cmdCheck.Text = "Check ";
            this.cmdCheck.UseVisualStyleBackColor = true;
            this.cmdCheck.Click += new System.EventHandler(this.cmdCheck_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Latitude ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Longitude ";
            // 
            // GeoFence
            // 
            this.GeoFence.Controls.Add(this.label3);
            this.GeoFence.Controls.Add(this.txtR);
            this.GeoFence.Controls.Add(this.txtLong);
            this.GeoFence.Controls.Add(this.txtLat);
            this.GeoFence.Controls.Add(this.label1);
            this.GeoFence.Controls.Add(this.label2);
            this.GeoFence.Location = new System.Drawing.Point(30, 21);
            this.GeoFence.Name = "GeoFence";
            this.GeoFence.Size = new System.Drawing.Size(401, 100);
            this.GeoFence.TabIndex = 3;
            this.GeoFence.TabStop = false;
            this.GeoFence.Text = "GeoFence";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(203, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Radius KM (100 m = 0.1 km)";
            // 
            // txtR
            // 
            this.txtR.Location = new System.Drawing.Point(251, 58);
            this.txtR.Name = "txtR";
            this.txtR.Size = new System.Drawing.Size(100, 25);
            this.txtR.TabIndex = 6;
            this.txtR.Text = "0.05";
            this.txtR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtR.TextChanged += new System.EventHandler(this.txtR_TextChanged);
            // 
            // txtLong
            // 
            this.txtLong.Location = new System.Drawing.Point(85, 58);
            this.txtLong.Name = "txtLong";
            this.txtLong.Size = new System.Drawing.Size(112, 25);
            this.txtLong.TabIndex = 4;
            this.txtLong.Text = "-122.11402486016958";
            // 
            // txtLat
            // 
            this.txtLat.Location = new System.Drawing.Point(85, 27);
            this.txtLat.Name = "txtLat";
            this.txtLat.Size = new System.Drawing.Size(112, 25);
            this.txtLat.TabIndex = 3;
            this.txtLat.Text = "37.3956302464915";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtQLong);
            this.groupBox1.Controls.Add(this.txtQLat);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(30, 141);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(242, 100);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Query";
            // 
            // txtQLong
            // 
            this.txtQLong.Location = new System.Drawing.Point(85, 58);
            this.txtQLong.Name = "txtQLong";
            this.txtQLong.Size = new System.Drawing.Size(136, 25);
            this.txtQLong.TabIndex = 4;
            // 
            // txtQLat
            // 
            this.txtQLat.Location = new System.Drawing.Point(85, 27);
            this.txtQLat.Name = "txtQLat";
            this.txtQLat.Size = new System.Drawing.Size(136, 25);
            this.txtQLat.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 19);
            this.label5.TabIndex = 1;
            this.label5.Text = "Latitude ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 19);
            this.label6.TabIndex = 2;
            this.label6.Text = "Longitude ";
            // 
            // lblResults
            // 
            this.lblResults.AutoSize = true;
            this.lblResults.Location = new System.Drawing.Point(26, 273);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(0, 19);
            this.lblResults.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 331);
            this.Controls.Add(this.lblResults);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GeoFence);
            this.Controls.Add(this.cmdCheck);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Amol\'s check if in geofence";
            this.GeoFence.ResumeLayout(false);
            this.GeoFence.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdCheck;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox GeoFence;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtR;
        private System.Windows.Forms.TextBox txtLong;
        private System.Windows.Forms.TextBox txtLat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtQLong;
        private System.Windows.Forms.TextBox txtQLat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblResults;
    }
}

