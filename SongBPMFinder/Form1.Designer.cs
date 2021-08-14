﻿namespace SongBPMFinder
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
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.textOutput = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.playPauseButton = new System.Windows.Forms.Button();
            this.buttonSpeed1x = new System.Windows.Forms.Button();
            this.buttonSpeed075x = new System.Windows.Forms.Button();
            this.buttonSpeed050x = new System.Windows.Forms.Button();
            this.buttonSpeed025x = new System.Windows.Forms.Button();
            this.waveformTabs = new System.Windows.Forms.TabControl();
            this.songWaveformTab = new System.Windows.Forms.TabPage();
            this.testWaveformTab = new System.Windows.Forms.TabPage();
            this.testWaveformTab2 = new System.Windows.Forms.TabPage();
            this.testWaveformTab3 = new System.Windows.Forms.TabPage();
            this.testWaveformTab4 = new System.Windows.Forms.TabPage();
            this.testWaveformTab5 = new System.Windows.Forms.TabPage();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openAudioForTimingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculateTimingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToClipboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xMLFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.osuTimingPointsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.songPositionChangedInterrupt = new System.Windows.Forms.Timer(this.components);
            this.outputToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToClipboardToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.audioViewer = new SongBPMFinder.CustomWaveViewer();
            this.debugPlot1 = new SongBPMFinder.CustomWaveViewer();
            this.debugPlot2 = new SongBPMFinder.CustomWaveViewer();
            this.debugPlot3 = new SongBPMFinder.CustomWaveViewer();
            this.debugPlot4 = new SongBPMFinder.CustomWaveViewer();
            this.debugPlot5 = new SongBPMFinder.CustomWaveViewer();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.waveformTabs.SuspendLayout();
            this.songWaveformTab.SuspendLayout();
            this.testWaveformTab.SuspendLayout();
            this.testWaveformTab2.SuspendLayout();
            this.testWaveformTab3.SuspendLayout();
            this.testWaveformTab4.SuspendLayout();
            this.testWaveformTab5.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.menuStrip1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1113, 585);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.textOutput, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 26);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 79.1019F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.8981F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1107, 556);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // textOutput
            // 
            this.textOutput.BackColor = System.Drawing.Color.Black;
            this.textOutput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textOutput.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textOutput.ForeColor = System.Drawing.Color.White;
            this.textOutput.Location = new System.Drawing.Point(3, 442);
            this.textOutput.Name = "textOutput";
            this.textOutput.ReadOnly = true;
            this.textOutput.Size = new System.Drawing.Size(1101, 111);
            this.textOutput.TabIndex = 1;
            this.textOutput.Text = "awdwdadw";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.waveformTabs, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1101, 433);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.playPauseButton);
            this.flowLayoutPanel1.Controls.Add(this.buttonSpeed1x);
            this.flowLayoutPanel1.Controls.Add(this.buttonSpeed075x);
            this.flowLayoutPanel1.Controls.Add(this.buttonSpeed050x);
            this.flowLayoutPanel1.Controls.Add(this.buttonSpeed025x);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1095, 40);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // playPauseButton
            // 
            this.playPauseButton.Font = new System.Drawing.Font("Webdings", 16F);
            this.playPauseButton.Location = new System.Drawing.Point(0, 0);
            this.playPauseButton.Margin = new System.Windows.Forms.Padding(0);
            this.playPauseButton.Name = "playPauseButton";
            this.playPauseButton.Size = new System.Drawing.Size(69, 40);
            this.playPauseButton.TabIndex = 0;
            this.playPauseButton.Text = "4";
            this.playPauseButton.UseVisualStyleBackColor = true;
            this.playPauseButton.Click += new System.EventHandler(this.playPauseButton_Click);
            // 
            // buttonSpeed1x
            // 
            this.buttonSpeed1x.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSpeed1x.Location = new System.Drawing.Point(69, 0);
            this.buttonSpeed1x.Margin = new System.Windows.Forms.Padding(0);
            this.buttonSpeed1x.Name = "buttonSpeed1x";
            this.buttonSpeed1x.Size = new System.Drawing.Size(110, 40);
            this.buttonSpeed1x.TabIndex = 1;
            this.buttonSpeed1x.Text = "1x";
            this.buttonSpeed1x.UseVisualStyleBackColor = true;
            this.buttonSpeed1x.Click += new System.EventHandler(this.buttonSpeed1x_Click);
            // 
            // buttonSpeed075x
            // 
            this.buttonSpeed075x.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSpeed075x.Location = new System.Drawing.Point(179, 0);
            this.buttonSpeed075x.Margin = new System.Windows.Forms.Padding(0);
            this.buttonSpeed075x.Name = "buttonSpeed075x";
            this.buttonSpeed075x.Size = new System.Drawing.Size(110, 40);
            this.buttonSpeed075x.TabIndex = 2;
            this.buttonSpeed075x.Text = "0.75x";
            this.buttonSpeed075x.UseVisualStyleBackColor = true;
            this.buttonSpeed075x.Click += new System.EventHandler(this.buttonSpeed075x_Click);
            // 
            // buttonSpeed050x
            // 
            this.buttonSpeed050x.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSpeed050x.Location = new System.Drawing.Point(289, 0);
            this.buttonSpeed050x.Margin = new System.Windows.Forms.Padding(0);
            this.buttonSpeed050x.Name = "buttonSpeed050x";
            this.buttonSpeed050x.Size = new System.Drawing.Size(110, 40);
            this.buttonSpeed050x.TabIndex = 3;
            this.buttonSpeed050x.Text = "0.5x";
            this.buttonSpeed050x.UseVisualStyleBackColor = true;
            this.buttonSpeed050x.Click += new System.EventHandler(this.buttonSpeed050x_Click);
            // 
            // buttonSpeed025x
            // 
            this.buttonSpeed025x.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSpeed025x.Location = new System.Drawing.Point(399, 0);
            this.buttonSpeed025x.Margin = new System.Windows.Forms.Padding(0);
            this.buttonSpeed025x.Name = "buttonSpeed025x";
            this.buttonSpeed025x.Size = new System.Drawing.Size(110, 40);
            this.buttonSpeed025x.TabIndex = 4;
            this.buttonSpeed025x.Text = "0.25x";
            this.buttonSpeed025x.UseVisualStyleBackColor = true;
            this.buttonSpeed025x.Click += new System.EventHandler(this.buttonSpeed025x_Click);
            // 
            // waveformTabs
            // 
            this.waveformTabs.Controls.Add(this.songWaveformTab);
            this.waveformTabs.Controls.Add(this.testWaveformTab);
            this.waveformTabs.Controls.Add(this.testWaveformTab2);
            this.waveformTabs.Controls.Add(this.testWaveformTab3);
            this.waveformTabs.Controls.Add(this.testWaveformTab4);
            this.waveformTabs.Controls.Add(this.testWaveformTab5);
            this.waveformTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.waveformTabs.Location = new System.Drawing.Point(3, 49);
            this.waveformTabs.Name = "waveformTabs";
            this.waveformTabs.SelectedIndex = 0;
            this.waveformTabs.Size = new System.Drawing.Size(1095, 381);
            this.waveformTabs.TabIndex = 7;
            // 
            // songWaveformTab
            // 
            this.songWaveformTab.Controls.Add(this.audioViewer);
            this.songWaveformTab.Location = new System.Drawing.Point(4, 22);
            this.songWaveformTab.Name = "songWaveformTab";
            this.songWaveformTab.Padding = new System.Windows.Forms.Padding(3);
            this.songWaveformTab.Size = new System.Drawing.Size(1087, 355);
            this.songWaveformTab.TabIndex = 0;
            this.songWaveformTab.Text = "Song Waveform";
            this.songWaveformTab.UseVisualStyleBackColor = true;
            // 
            // testWaveformTab
            // 
            this.testWaveformTab.Controls.Add(this.debugPlot1);
            this.testWaveformTab.Location = new System.Drawing.Point(4, 22);
            this.testWaveformTab.Name = "testWaveformTab";
            this.testWaveformTab.Padding = new System.Windows.Forms.Padding(3);
            this.testWaveformTab.Size = new System.Drawing.Size(1087, 355);
            this.testWaveformTab.TabIndex = 1;
            this.testWaveformTab.Text = "Debug plot";
            this.testWaveformTab.UseVisualStyleBackColor = true;
            // 
            // testWaveformTab2
            // 
            this.testWaveformTab2.Controls.Add(this.debugPlot2);
            this.testWaveformTab2.Location = new System.Drawing.Point(4, 22);
            this.testWaveformTab2.Name = "testWaveformTab2";
            this.testWaveformTab2.Padding = new System.Windows.Forms.Padding(3);
            this.testWaveformTab2.Size = new System.Drawing.Size(1087, 355);
            this.testWaveformTab2.TabIndex = 2;
            this.testWaveformTab2.Text = "Debug Plot 2";
            this.testWaveformTab2.UseVisualStyleBackColor = true;
            // 
            // testWaveformTab3
            // 
            this.testWaveformTab3.Controls.Add(this.debugPlot3);
            this.testWaveformTab3.Location = new System.Drawing.Point(4, 22);
            this.testWaveformTab3.Name = "testWaveformTab3";
            this.testWaveformTab3.Padding = new System.Windows.Forms.Padding(3);
            this.testWaveformTab3.Size = new System.Drawing.Size(1087, 355);
            this.testWaveformTab3.TabIndex = 3;
            this.testWaveformTab3.Text = "Debug plot 3";
            this.testWaveformTab3.UseVisualStyleBackColor = true;
            // 
            // testWaveformTab4
            // 
            this.testWaveformTab4.Controls.Add(this.debugPlot4);
            this.testWaveformTab4.Location = new System.Drawing.Point(4, 22);
            this.testWaveformTab4.Name = "testWaveformTab4";
            this.testWaveformTab4.Padding = new System.Windows.Forms.Padding(3);
            this.testWaveformTab4.Size = new System.Drawing.Size(1087, 355);
            this.testWaveformTab4.TabIndex = 4;
            this.testWaveformTab4.Text = "Debug plot 4";
            this.testWaveformTab4.UseVisualStyleBackColor = true;
            // 
            // testWaveformTab5
            // 
            this.testWaveformTab5.Controls.Add(this.debugPlot5);
            this.testWaveformTab5.Location = new System.Drawing.Point(4, 22);
            this.testWaveformTab5.Name = "testWaveformTab5";
            this.testWaveformTab5.Padding = new System.Windows.Forms.Padding(3);
            this.testWaveformTab5.Size = new System.Drawing.Size(1087, 355);
            this.testWaveformTab5.TabIndex = 5;
            this.testWaveformTab5.Text = "Debug plot 5";
            this.testWaveformTab5.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.timingToolStripMenuItem,
            this.copyToClipboardToolStripMenuItem,
            this.outputToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1113, 23);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openAudioForTimingToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 19);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openAudioForTimingToolStripMenuItem
            // 
            this.openAudioForTimingToolStripMenuItem.Name = "openAudioForTimingToolStripMenuItem";
            this.openAudioForTimingToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.openAudioForTimingToolStripMenuItem.Text = "Open audio for timing";
            this.openAudioForTimingToolStripMenuItem.Click += new System.EventHandler(this.openAudioForTimingToolStripMenuItem_Click);
            // 
            // timingToolStripMenuItem
            // 
            this.timingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculateTimingToolStripMenuItem});
            this.timingToolStripMenuItem.Name = "timingToolStripMenuItem";
            this.timingToolStripMenuItem.Size = new System.Drawing.Size(56, 19);
            this.timingToolStripMenuItem.Text = "Timing";
            // 
            // calculateTimingToolStripMenuItem
            // 
            this.calculateTimingToolStripMenuItem.Name = "calculateTimingToolStripMenuItem";
            this.calculateTimingToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.calculateTimingToolStripMenuItem.Text = "Calculate timing";
            this.calculateTimingToolStripMenuItem.Click += new System.EventHandler(this.calculateTimingToolStripMenuItem_Click);
            // 
            // copyToClipboardToolStripMenuItem
            // 
            this.copyToClipboardToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xMLFileToolStripMenuItem,
            this.osuTimingPointsToolStripMenuItem});
            this.copyToClipboardToolStripMenuItem.Name = "copyToClipboardToolStripMenuItem";
            this.copyToClipboardToolStripMenuItem.Size = new System.Drawing.Size(114, 19);
            this.copyToClipboardToolStripMenuItem.Text = "Copy to clipboard";
            // 
            // xMLFileToolStripMenuItem
            // 
            this.xMLFileToolStripMenuItem.Name = "xMLFileToolStripMenuItem";
            this.xMLFileToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.xMLFileToolStripMenuItem.Text = "XML file";
            this.xMLFileToolStripMenuItem.Click += new System.EventHandler(this.xMLFileToolStripMenuItem_Click);
            // 
            // osuTimingPointsToolStripMenuItem
            // 
            this.osuTimingPointsToolStripMenuItem.Name = "osuTimingPointsToolStripMenuItem";
            this.osuTimingPointsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.osuTimingPointsToolStripMenuItem.Text = "osu! timing points";
            this.osuTimingPointsToolStripMenuItem.Click += new System.EventHandler(this.osuTimingPointsToolStripMenuItem_Click);
            // 
            // outputToolStripMenuItem
            // 
            this.outputToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToClipboardToolStripMenuItem1,
            this.clearToolStripMenuItem});
            this.outputToolStripMenuItem.Name = "outputToolStripMenuItem";
            this.outputToolStripMenuItem.Size = new System.Drawing.Size(57, 19);
            this.outputToolStripMenuItem.Text = "Output";
            // 
            // copyToClipboardToolStripMenuItem1
            // 
            this.copyToClipboardToolStripMenuItem1.Name = "copyToClipboardToolStripMenuItem1";
            this.copyToClipboardToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.copyToClipboardToolStripMenuItem1.Text = "Copy to clipboard";
            this.copyToClipboardToolStripMenuItem1.Click += new System.EventHandler(this.copyToClipboardToolStripMenuItem1_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // audioViewer
            // 
            this.audioViewer.AudioData = null;
            this.audioViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.audioViewer.Location = new System.Drawing.Point(3, 3);
            this.audioViewer.Name = "audioViewer";
            this.audioViewer.Size = new System.Drawing.Size(1081, 349);
            this.audioViewer.TabIndex = 0;
            // 
            // debugPlot1
            // 
            this.debugPlot1.AudioData = null;
            this.debugPlot1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.debugPlot1.Location = new System.Drawing.Point(3, 3);
            this.debugPlot1.Name = "debugPlot1";
            this.debugPlot1.Size = new System.Drawing.Size(1081, 349);
            this.debugPlot1.TabIndex = 0;
            // 
            // debugPlot2
            // 
            this.debugPlot2.AudioData = null;
            this.debugPlot2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.debugPlot2.Location = new System.Drawing.Point(3, 3);
            this.debugPlot2.Name = "debugPlot2";
            this.debugPlot2.Size = new System.Drawing.Size(1081, 349);
            this.debugPlot2.TabIndex = 0;
            // 
            // debugPlot3
            // 
            this.debugPlot3.AudioData = null;
            this.debugPlot3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.debugPlot3.Location = new System.Drawing.Point(3, 3);
            this.debugPlot3.Name = "debugPlot3";
            this.debugPlot3.Size = new System.Drawing.Size(1081, 349);
            this.debugPlot3.TabIndex = 0;
            // 
            // debugPlot4
            // 
            this.debugPlot4.AudioData = null;
            this.debugPlot4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.debugPlot4.Location = new System.Drawing.Point(3, 3);
            this.debugPlot4.Name = "debugPlot4";
            this.debugPlot4.Size = new System.Drawing.Size(1081, 349);
            this.debugPlot4.TabIndex = 0;
            // 
            // debugPlot5
            // 
            this.debugPlot5.AudioData = null;
            this.debugPlot5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.debugPlot5.Location = new System.Drawing.Point(3, 3);
            this.debugPlot5.Name = "debugPlot5";
            this.debugPlot5.Size = new System.Drawing.Size(1081, 349);
            this.debugPlot5.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 585);
            this.Controls.Add(this.tableLayoutPanel1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Music Timer";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.waveformTabs.ResumeLayout(false);
            this.songWaveformTab.ResumeLayout(false);
            this.testWaveformTab.ResumeLayout(false);
            this.testWaveformTab2.ResumeLayout(false);
            this.testWaveformTab3.ResumeLayout(false);
            this.testWaveformTab4.ResumeLayout(false);
            this.testWaveformTab5.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.RichTextBox textOutput;
        private System.Windows.Forms.Timer songPositionChangedInterrupt;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openAudioForTimingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem timingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculateTimingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToClipboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xMLFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem osuTimingPointsToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button playPauseButton;
        private System.Windows.Forms.Button buttonSpeed1x;
        private System.Windows.Forms.Button buttonSpeed075x;
        private System.Windows.Forms.Button buttonSpeed050x;
        private System.Windows.Forms.Button buttonSpeed025x;
        private System.Windows.Forms.TabControl waveformTabs;
        private System.Windows.Forms.TabPage songWaveformTab;
        private CustomWaveViewer audioViewer;
        private System.Windows.Forms.TabPage testWaveformTab;
        private CustomWaveViewer debugPlot1;
        private System.Windows.Forms.TabPage testWaveformTab2;
        private CustomWaveViewer debugPlot2;
        private System.Windows.Forms.TabPage testWaveformTab3;
        private CustomWaveViewer debugPlot3;
        private System.Windows.Forms.TabPage testWaveformTab4;
        private CustomWaveViewer debugPlot4;
        private System.Windows.Forms.TabPage testWaveformTab5;
        private CustomWaveViewer debugPlot5;
        private System.Windows.Forms.ToolStripMenuItem outputToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToClipboardToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
    }
}

