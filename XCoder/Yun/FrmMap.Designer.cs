﻿namespace XCoder.Yun
{
    partial class FrmMap
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
            this.lbMethod = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbCoordtype = new System.Windows.Forms.ComboBox();
            this.cbMethod = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chkFormatAddress = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.cbMap = new System.Windows.Forms.ComboBox();
            this.pgResult = new System.Windows.Forms.PropertyGrid();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.btnInvoke = new System.Windows.Forms.Button();
            this.txtReceive = new System.Windows.Forms.RichTextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.gbReceive = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtLocation2 = new System.Windows.Forms.TextBox();
            this.gbReceive.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbMethod
            // 
            this.lbMethod.AutoSize = true;
            this.lbMethod.Location = new System.Drawing.Point(490, 16);
            this.lbMethod.Name = "lbMethod";
            this.lbMethod.Size = new System.Drawing.Size(53, 12);
            this.lbMethod.TabIndex = 39;
            this.lbMethod.Text = "方法签名";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(284, 32);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 24);
            this.label6.TabIndex = 35;
            this.label6.Text = "坐标系：";
            // 
            // cbCoordtype
            // 
            this.cbCoordtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCoordtype.FormattingEnabled = true;
            this.cbCoordtype.Location = new System.Drawing.Point(392, 24);
            this.cbCoordtype.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cbCoordtype.Name = "cbCoordtype";
            this.cbCoordtype.Size = new System.Drawing.Size(138, 32);
            this.cbCoordtype.TabIndex = 34;
            // 
            // cbMethod
            // 
            this.cbMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMethod.FormattingEnabled = true;
            this.cbMethod.Location = new System.Drawing.Point(631, 24);
            this.cbMethod.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cbMethod.Name = "cbMethod";
            this.cbMethod.Size = new System.Drawing.Size(231, 32);
            this.cbMethod.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(544, 32);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 24);
            this.label5.TabIndex = 32;
            this.label5.Text = "接口：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 32);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 24);
            this.label4.TabIndex = 31;
            this.label4.Text = "地图：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(627, 96);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 24);
            this.label2.TabIndex = 30;
            this.label2.Text = "城市：";
            // 
            // chkFormatAddress
            // 
            this.chkFormatAddress.AutoSize = true;
            this.chkFormatAddress.Checked = true;
            this.chkFormatAddress.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkFormatAddress.Location = new System.Drawing.Point(884, 92);
            this.chkFormatAddress.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.chkFormatAddress.Name = "chkFormatAddress";
            this.chkFormatAddress.Size = new System.Drawing.Size(126, 28);
            this.chkFormatAddress.TabIndex = 38;
            this.chkFormatAddress.Text = "格式化地址";
            this.chkFormatAddress.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 96);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 24);
            this.label1.TabIndex = 29;
            this.label1.Text = "地址：";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(116, 88);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(466, 30);
            this.txtAddress.TabIndex = 27;
            this.txtAddress.Text = "陆家嘴银城中路501号";
            // 
            // cbMap
            // 
            this.cbMap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMap.FormattingEnabled = true;
            this.cbMap.Location = new System.Drawing.Point(116, 24);
            this.cbMap.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cbMap.Name = "cbMap";
            this.cbMap.Size = new System.Drawing.Size(160, 32);
            this.cbMap.TabIndex = 26;
            this.cbMap.SelectedIndexChanged += new System.EventHandler(this.cbMap_SelectedIndexChanged);
            // 
            // pgResult
            // 
            this.pgResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pgResult.LineColor = System.Drawing.SystemColors.ControlDark;
            this.pgResult.Location = new System.Drawing.Point(708, 216);
            this.pgResult.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pgResult.Name = "pgResult";
            this.pgResult.PropertySort = System.Windows.Forms.PropertySort.NoSort;
            this.pgResult.Size = new System.Drawing.Size(515, 750);
            this.pgResult.TabIndex = 25;
            // 
            // btnInvoke
            // 
            this.btnInvoke.Location = new System.Drawing.Point(1025, 16);
            this.btnInvoke.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnInvoke.Name = "btnInvoke";
            this.btnInvoke.Size = new System.Drawing.Size(123, 58);
            this.btnInvoke.TabIndex = 23;
            this.btnInvoke.Text = "调用";
            this.btnInvoke.UseVisualStyleBackColor = true;
            this.btnInvoke.Click += new System.EventHandler(this.btnInvoke_Click);
            // 
            // txtReceive
            // 
            this.txtReceive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtReceive.HideSelection = false;
            this.txtReceive.Location = new System.Drawing.Point(6, 29);
            this.txtReceive.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtReceive.Name = "txtReceive";
            this.txtReceive.Size = new System.Drawing.Size(686, 721);
            this.txtReceive.TabIndex = 22;
            this.txtReceive.Text = "";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(719, 88);
            this.txtCity.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(134, 30);
            this.txtCity.TabIndex = 28;
            this.txtCity.Text = "上海";
            // 
            // gbReceive
            // 
            this.gbReceive.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbReceive.Controls.Add(this.txtReceive);
            this.gbReceive.Location = new System.Drawing.Point(4, 216);
            this.gbReceive.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.gbReceive.Name = "gbReceive";
            this.gbReceive.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.gbReceive.Size = new System.Drawing.Size(698, 756);
            this.gbReceive.TabIndex = 24;
            this.gbReceive.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 154);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 24);
            this.label3.TabIndex = 36;
            this.label3.Text = "坐标：";
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(116, 146);
            this.txtLocation.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(384, 30);
            this.txtLocation.TabIndex = 37;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(548, 154);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 24);
            this.label7.TabIndex = 39;
            this.label7.Text = "第二坐标：";
            // 
            // txtLocation2
            // 
            this.txtLocation2.Location = new System.Drawing.Point(678, 146);
            this.txtLocation2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtLocation2.Name = "txtLocation2";
            this.txtLocation2.Size = new System.Drawing.Size(384, 30);
            this.txtLocation2.TabIndex = 40;
            // 
            // FrmMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1228, 976);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtLocation2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbCoordtype);
            this.Controls.Add(this.cbMethod);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.cbMap);
            this.Controls.Add(this.pgResult);
            this.Controls.Add(this.btnInvoke);
            this.Controls.Add(this.gbReceive);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.chkFormatAddress);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "FrmMap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "地图接口";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.gbReceive.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbMethod;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbCoordtype;
        private System.Windows.Forms.ComboBox cbMethod;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkFormatAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.ComboBox cbMap;
        private System.Windows.Forms.PropertyGrid pgResult;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Button btnInvoke;
        private System.Windows.Forms.RichTextBox txtReceive;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.GroupBox gbReceive;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtLocation2;
    }
}