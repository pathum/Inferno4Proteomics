using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DAnTE.Inferno
{
    partial class frmLOESSPar
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

        private Label mlblPickFactor;
        private Button mbtnOK;
        private Button mbtnCancel;

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLOESSPar));
            this.mlblPickFactor = new System.Windows.Forms.Label();
            this.mbtnOK = new System.Windows.Forms.Button();
            this.mbtnCancel = new System.Windows.Forms.Button();
            this.mbtnSelectFolder = new System.Windows.Forms.Button();
            this.mtxtBoxFolder = new System.Windows.Forms.TextBox();
            this.mchkBoxPlot = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mcmbBoxFactors = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mtrackBarSpan = new System.Windows.Forms.TrackBar();
            this.mlblSpan = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.mrBtnMinMissing = new System.Windows.Forms.RadioButton();
            this.mrBtnMedian = new System.Windows.Forms.RadioButton();
            this.mrBtnFirst = new System.Windows.Forms.RadioButton();
            this.mlblDataName = new System.Windows.Forms.Label();
            this.niceLine2 = new DAnTE.ExtraControls.NiceLine();
            this.niceLine1 = new DAnTE.ExtraControls.NiceLine();
            ((System.ComponentModel.ISupportInitialize)(this.mtrackBarSpan)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // mlblPickFactor
            // 
            this.mlblPickFactor.AutoSize = true;
            this.mlblPickFactor.Location = new System.Drawing.Point(41, 80);
            this.mlblPickFactor.Name = "mlblPickFactor";
            this.mlblPickFactor.Size = new System.Drawing.Size(181, 13);
            this.mlblPickFactor.TabIndex = 1;
            this.mlblPickFactor.Text = "Pick the Factor Denoting Replicates:";
            // 
            // mbtnOK
            // 
            this.mbtnOK.Location = new System.Drawing.Point(108, 478);
            this.mbtnOK.Name = "mbtnOK";
            this.mbtnOK.Size = new System.Drawing.Size(75, 23);
            this.mbtnOK.TabIndex = 2;
            this.mbtnOK.Text = "OK";
            this.mbtnOK.UseVisualStyleBackColor = true;
            this.mbtnOK.Click += new System.EventHandler(this.mbtnOK_Click);
            // 
            // mbtnCancel
            // 
            this.mbtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.mbtnCancel.Location = new System.Drawing.Point(210, 478);
            this.mbtnCancel.Name = "mbtnCancel";
            this.mbtnCancel.Size = new System.Drawing.Size(75, 23);
            this.mbtnCancel.TabIndex = 3;
            this.mbtnCancel.Text = "Cancel";
            this.mbtnCancel.UseVisualStyleBackColor = true;
            this.mbtnCancel.Click += new System.EventHandler(this.mbtnCancel_Click);
            // 
            // mbtnSelectFolder
            // 
            this.mbtnSelectFolder.Enabled = false;
            this.mbtnSelectFolder.Location = new System.Drawing.Point(353, 430);
            this.mbtnSelectFolder.Name = "mbtnSelectFolder";
            this.mbtnSelectFolder.Size = new System.Drawing.Size(25, 20);
            this.mbtnSelectFolder.TabIndex = 12;
            this.mbtnSelectFolder.Text = "...";
            this.mbtnSelectFolder.UseVisualStyleBackColor = true;
            this.mbtnSelectFolder.Click += new System.EventHandler(this.mbtnSelectFolder_Click);
            // 
            // mtxtBoxFolder
            // 
            this.mtxtBoxFolder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mtxtBoxFolder.Enabled = false;
            this.mtxtBoxFolder.Location = new System.Drawing.Point(49, 431);
            this.mtxtBoxFolder.Name = "mtxtBoxFolder";
            this.mtxtBoxFolder.Size = new System.Drawing.Size(298, 20);
            this.mtxtBoxFolder.TabIndex = 11;
            // 
            // mchkBoxPlot
            // 
            this.mchkBoxPlot.AutoSize = true;
            this.mchkBoxPlot.Location = new System.Drawing.Point(28, 408);
            this.mchkBoxPlot.Name = "mchkBoxPlot";
            this.mchkBoxPlot.Size = new System.Drawing.Size(229, 17);
            this.mchkBoxPlot.TabIndex = 10;
            this.mchkBoxPlot.Text = "Save MA plots (WARNING: Could be slow)";
            this.mchkBoxPlot.UseVisualStyleBackColor = true;
            this.mchkBoxPlot.Click += new System.EventHandler(this.mchkBoxPlot_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Span Value for LOESS:";
            // 
            // mcmbBoxFactors
            // 
            this.mcmbBoxFactors.FormattingEnabled = true;
            this.mcmbBoxFactors.Location = new System.Drawing.Point(227, 77);
            this.mcmbBoxFactors.Name = "mcmbBoxFactors";
            this.mcmbBoxFactors.Size = new System.Drawing.Size(124, 21);
            this.mcmbBoxFactors.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(151, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Data Source:";
            // 
            // mtrackBarSpan
            // 
            this.mtrackBarSpan.LargeChange = 1;
            this.mtrackBarSpan.Location = new System.Drawing.Point(17, 41);
            this.mtrackBarSpan.Name = "mtrackBarSpan";
            this.mtrackBarSpan.Size = new System.Drawing.Size(345, 45);
            this.mtrackBarSpan.TabIndex = 18;
            this.mtrackBarSpan.Value = 4;
            this.mtrackBarSpan.Scroll += new System.EventHandler(this.mtrackBarSpan_Scroll);
            // 
            // mlblSpan
            // 
            this.mlblSpan.AutoSize = true;
            this.mlblSpan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mlblSpan.Location = new System.Drawing.Point(138, 25);
            this.mlblSpan.Name = "mlblSpan";
            this.mlblSpan.Size = new System.Drawing.Size(22, 13);
            this.mlblSpan.TabIndex = 19;
            this.mlblSpan.Text = "0.4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "LOESS Normalization";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mtrackBarSpan);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.mlblSpan);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(22, 272);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(368, 107);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Window Width";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.mrBtnMinMissing);
            this.groupBox2.Controls.Add(this.mrBtnMedian);
            this.groupBox2.Controls.Add(this.mrBtnFirst);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox2.Location = new System.Drawing.Point(22, 124);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(368, 120);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pick Reference";
            // 
            // mrBtnMinMissing
            // 
            this.mrBtnMinMissing.AutoSize = true;
            this.mrBtnMinMissing.Checked = true;
            this.mrBtnMinMissing.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrBtnMinMissing.Location = new System.Drawing.Point(47, 89);
            this.mrBtnMinMissing.Name = "mrBtnMinMissing";
            this.mrBtnMinMissing.Size = new System.Drawing.Size(228, 17);
            this.mrBtnMinMissing.TabIndex = 2;
            this.mrBtnMinMissing.TabStop = true;
            this.mrBtnMinMissing.Text = "Dataset with Least Amount of Missing Data";
            this.mrBtnMinMissing.UseVisualStyleBackColor = true;
            // 
            // mrBtnMedian
            // 
            this.mrBtnMedian.AutoSize = true;
            this.mrBtnMedian.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrBtnMedian.Location = new System.Drawing.Point(47, 58);
            this.mrBtnMedian.Name = "mrBtnMedian";
            this.mrBtnMedian.Size = new System.Drawing.Size(235, 17);
            this.mrBtnMedian.TabIndex = 1;
            this.mrBtnMedian.Text = "Create the Median Set in Replicate Category";
            this.mrBtnMedian.UseVisualStyleBackColor = true;
            // 
            // mrBtnFirst
            // 
            this.mrBtnFirst.AutoSize = true;
            this.mrBtnFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrBtnFirst.Location = new System.Drawing.Point(47, 28);
            this.mrBtnFirst.Name = "mrBtnFirst";
            this.mrBtnFirst.Size = new System.Drawing.Size(167, 17);
            this.mrBtnFirst.TabIndex = 0;
            this.mrBtnFirst.Text = "First Set in Replicate Category";
            this.mrBtnFirst.UseVisualStyleBackColor = true;
            // 
            // mlblDataName
            // 
            this.mlblDataName.AutoSize = true;
            this.mlblDataName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mlblDataName.Location = new System.Drawing.Point(227, 43);
            this.mlblDataName.Name = "mlblDataName";
            this.mlblDataName.Size = new System.Drawing.Size(41, 13);
            this.mlblDataName.TabIndex = 55;
            this.mlblDataName.Text = "label8";
            // 
            // niceLine2
            // 
            this.niceLine2.Location = new System.Drawing.Point(12, 25);
            this.niceLine2.Name = "niceLine2";
            this.niceLine2.Size = new System.Drawing.Size(378, 15);
            this.niceLine2.TabIndex = 21;
            // 
            // niceLine1
            // 
            this.niceLine1.Location = new System.Drawing.Point(25, 457);
            this.niceLine1.Name = "niceLine1";
            this.niceLine1.Size = new System.Drawing.Size(365, 15);
            this.niceLine1.TabIndex = 4;
            // 
            // frmLOESSPar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 524);
            this.Controls.Add(this.mlblDataName);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.niceLine2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mcmbBoxFactors);
            this.Controls.Add(this.mbtnSelectFolder);
            this.Controls.Add(this.mtxtBoxFolder);
            this.Controls.Add(this.mchkBoxPlot);
            this.Controls.Add(this.niceLine1);
            this.Controls.Add(this.mbtnCancel);
            this.Controls.Add(this.mbtnOK);
            this.Controls.Add(this.mlblPickFactor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLOESSPar";
            this.ShowInTaskbar = false;
            this.Text = "Pick Parameters for LOESS";
            this.Load += new System.EventHandler(this.frmPickFactor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mtrackBarSpan)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private ExtraControls.NiceLine niceLine1;
        #endregion
        private Button mbtnSelectFolder;
        private TextBox mtxtBoxFolder;
        private CheckBox mchkBoxPlot;
        private Label label1;
        private ComboBox mcmbBoxFactors;
        private Label label2;
        private TrackBar mtrackBarSpan;
        private Label mlblSpan;
        private Label label3;
        private ExtraControls.NiceLine niceLine2;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private RadioButton mrBtnMinMissing;
        private RadioButton mrBtnMedian;
        private RadioButton mrBtnFirst;
        private Label mlblDataName;
    }
}