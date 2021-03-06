﻿namespace Cube.Pdf.App.Pages
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.LayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.FooterPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.ExitButtonPanel = new System.Windows.Forms.Panel();
            this.ExitButton = new Cube.Forms.Button();
            this.SplitButtonPanel = new System.Windows.Forms.Panel();
            this.SplitButton = new Cube.Forms.Button();
            this.MergeButtonPanel = new System.Windows.Forms.Panel();
            this.MergeButton = new Cube.Forms.Button();
            this.ContentsPanel = new System.Windows.Forms.TableLayoutPanel();
            this.ButtonsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.FileButton = new Cube.Forms.Button();
            this.UpButton = new Cube.Forms.Button();
            this.DownButton = new Cube.Forms.Button();
            this.RemoveButton = new Cube.Forms.Button();
            this.ClearButton = new Cube.Forms.Button();
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.ImagePictureBox = new System.Windows.Forms.PictureBox();
            this.TitleButton = new System.Windows.Forms.PictureBox();
            this.FileListView = new Cube.Pdf.App.Pages.FileGridView();
            this.LayoutPanel.SuspendLayout();
            this.FooterPanel.SuspendLayout();
            this.ExitButtonPanel.SuspendLayout();
            this.SplitButtonPanel.SuspendLayout();
            this.MergeButtonPanel.SuspendLayout();
            this.ContentsPanel.SuspendLayout();
            this.ButtonsPanel.SuspendLayout();
            this.HeaderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImagePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TitleButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FileListView)).BeginInit();
            this.SuspendLayout();
            //
            // LayoutPanel
            //
            this.LayoutPanel.ColumnCount = 1;
            this.LayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.LayoutPanel.Controls.Add(this.FooterPanel, 0, 2);
            this.LayoutPanel.Controls.Add(this.ContentsPanel, 0, 1);
            this.LayoutPanel.Controls.Add(this.HeaderPanel, 0, 0);
            this.LayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.LayoutPanel.Name = "LayoutPanel";
            this.LayoutPanel.RowCount = 3;
            this.LayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.LayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.LayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.LayoutPanel.Size = new System.Drawing.Size(684, 311);
            this.LayoutPanel.TabIndex = 0;
            //
            // FooterPanel
            //
            this.FooterPanel.AllowDrop = true;
            this.FooterPanel.Controls.Add(this.ExitButtonPanel);
            this.FooterPanel.Controls.Add(this.SplitButtonPanel);
            this.FooterPanel.Controls.Add(this.MergeButtonPanel);
            this.FooterPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FooterPanel.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.FooterPanel.Location = new System.Drawing.Point(0, 251);
            this.FooterPanel.Margin = new System.Windows.Forms.Padding(0);
            this.FooterPanel.Name = "FooterPanel";
            this.FooterPanel.Padding = new System.Windows.Forms.Padding(0, 10, 10, 0);
            this.FooterPanel.Size = new System.Drawing.Size(684, 60);
            this.FooterPanel.TabIndex = 1;
            //
            // ExitButtonPanel
            //
            this.ExitButtonPanel.BackColor = System.Drawing.Color.Gainsboro;
            this.ExitButtonPanel.Controls.Add(this.ExitButton);
            this.ExitButtonPanel.Location = new System.Drawing.Point(572, 12);
            this.ExitButtonPanel.Margin = new System.Windows.Forms.Padding(2);
            this.ExitButtonPanel.Name = "ExitButtonPanel";
            this.ExitButtonPanel.Size = new System.Drawing.Size(100, 37);
            this.ExitButtonPanel.TabIndex = 1000;
            //
            // ExitButton
            //
            this.ExitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.ExitButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.ExitButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(151)))), ((int)(((byte)(151)))));
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.ForeColor = System.Drawing.Color.White;
            this.ExitButton.Location = new System.Drawing.Point(0, 0);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(0);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(100, 35);
            this.ExitButton.TabIndex = 0;
            this.ExitButton.Text = "終了";
            this.ExitButton.UseVisualStyleBackColor = false;
            //
            // SplitButtonPanel
            //
            this.SplitButtonPanel.BackColor = System.Drawing.Color.Gainsboro;
            this.SplitButtonPanel.Controls.Add(this.SplitButton);
            this.SplitButtonPanel.Location = new System.Drawing.Point(433, 12);
            this.SplitButtonPanel.Margin = new System.Windows.Forms.Padding(2);
            this.SplitButtonPanel.Name = "SplitButtonPanel";
            this.SplitButtonPanel.Size = new System.Drawing.Size(135, 37);
            this.SplitButtonPanel.TabIndex = 1000;
            //
            // SplitButton
            //
            this.SplitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(49)))), ((int)(((byte)(146)))));
            this.SplitButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.SplitButton.FlatAppearance.BorderSize = 0;
            this.SplitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SplitButton.ForeColor = System.Drawing.Color.White;
            this.SplitButton.Location = new System.Drawing.Point(0, 0);
            this.SplitButton.Margin = new System.Windows.Forms.Padding(0);
            this.SplitButton.Name = "SplitButton";
            this.SplitButton.Size = new System.Drawing.Size(135, 35);
            this.SplitButton.TabIndex = 2;
            this.SplitButton.Text = "分割(&S)";
            this.SplitButton.UseVisualStyleBackColor = false;
            //
            // MergeButtonPanel
            //
            this.MergeButtonPanel.BackColor = System.Drawing.Color.Gainsboro;
            this.MergeButtonPanel.Controls.Add(this.MergeButton);
            this.MergeButtonPanel.Location = new System.Drawing.Point(294, 12);
            this.MergeButtonPanel.Margin = new System.Windows.Forms.Padding(2);
            this.MergeButtonPanel.Name = "MergeButtonPanel";
            this.MergeButtonPanel.Size = new System.Drawing.Size(135, 37);
            this.MergeButtonPanel.TabIndex = 1000;
            //
            // MergeButton
            //
            this.MergeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(39)))), ((int)(((byte)(45)))));
            this.MergeButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.MergeButton.FlatAppearance.BorderSize = 0;
            this.MergeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MergeButton.ForeColor = System.Drawing.Color.White;
            this.MergeButton.Location = new System.Drawing.Point(0, 0);
            this.MergeButton.Margin = new System.Windows.Forms.Padding(0);
            this.MergeButton.Name = "MergeButton";
            this.MergeButton.Size = new System.Drawing.Size(135, 35);
            this.MergeButton.TabIndex = 1;
            this.MergeButton.Text = "結合(&M)";
            this.MergeButton.UseVisualStyleBackColor = false;
            //
            // ContentsPanel
            //
            this.ContentsPanel.ColumnCount = 2;
            this.ContentsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ContentsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 124F));
            this.ContentsPanel.Controls.Add(this.ButtonsPanel, 1, 0);
            this.ContentsPanel.Controls.Add(this.FileListView, 0, 0);
            this.ContentsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContentsPanel.Location = new System.Drawing.Point(0, 35);
            this.ContentsPanel.Margin = new System.Windows.Forms.Padding(0);
            this.ContentsPanel.Name = "ContentsPanel";
            this.ContentsPanel.RowCount = 1;
            this.ContentsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ContentsPanel.Size = new System.Drawing.Size(684, 216);
            this.ContentsPanel.TabIndex = 2;
            //
            // ButtonsPanel
            //
            this.ButtonsPanel.AllowDrop = true;
            this.ButtonsPanel.Controls.Add(this.FileButton);
            this.ButtonsPanel.Controls.Add(this.UpButton);
            this.ButtonsPanel.Controls.Add(this.DownButton);
            this.ButtonsPanel.Controls.Add(this.RemoveButton);
            this.ButtonsPanel.Controls.Add(this.ClearButton);
            this.ButtonsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonsPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.ButtonsPanel.Location = new System.Drawing.Point(560, 0);
            this.ButtonsPanel.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonsPanel.Name = "ButtonsPanel";
            this.ButtonsPanel.Padding = new System.Windows.Forms.Padding(10, 8, 10, 0);
            this.ButtonsPanel.Size = new System.Drawing.Size(124, 216);
            this.ButtonsPanel.TabIndex = 2;
            //
            // FileButton
            //
            this.FileButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.FileButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.FileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FileButton.ForeColor = System.Drawing.Color.White;
            this.FileButton.Location = new System.Drawing.Point(12, 10);
            this.FileButton.Margin = new System.Windows.Forms.Padding(2);
            this.FileButton.Name = "FileButton";
            this.FileButton.Size = new System.Drawing.Size(100, 30);
            this.FileButton.TabIndex = 0;
            this.FileButton.Text = "追加(&O) ...";
            this.FileButton.UseVisualStyleBackColor = false;
            //
            // UpButton
            //
            this.UpButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.UpButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.UpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpButton.ForeColor = System.Drawing.Color.White;
            this.UpButton.Location = new System.Drawing.Point(12, 44);
            this.UpButton.Margin = new System.Windows.Forms.Padding(2);
            this.UpButton.Name = "UpButton";
            this.UpButton.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.UpButton.Size = new System.Drawing.Size(100, 30);
            this.UpButton.TabIndex = 1;
            this.UpButton.Text = "上へ";
            this.UpButton.UseVisualStyleBackColor = false;
            //
            // DownButton
            //
            this.DownButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.DownButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.DownButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DownButton.ForeColor = System.Drawing.Color.White;
            this.DownButton.Location = new System.Drawing.Point(12, 78);
            this.DownButton.Margin = new System.Windows.Forms.Padding(2);
            this.DownButton.Name = "DownButton";
            this.DownButton.Size = new System.Drawing.Size(100, 30);
            this.DownButton.TabIndex = 2;
            this.DownButton.Text = "下へ";
            this.DownButton.UseVisualStyleBackColor = false;
            //
            // RemoveButton
            //
            this.RemoveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.RemoveButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.RemoveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveButton.ForeColor = System.Drawing.Color.White;
            this.RemoveButton.Location = new System.Drawing.Point(12, 112);
            this.RemoveButton.Margin = new System.Windows.Forms.Padding(2);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(100, 30);
            this.RemoveButton.TabIndex = 3;
            this.RemoveButton.Text = "削除(&D)";
            this.RemoveButton.UseVisualStyleBackColor = false;
            //
            // ClearButton
            //
            this.ClearButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClearButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.ClearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearButton.ForeColor = System.Drawing.Color.White;
            this.ClearButton.Location = new System.Drawing.Point(12, 146);
            this.ClearButton.Margin = new System.Windows.Forms.Padding(2);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(100, 30);
            this.ClearButton.TabIndex = 4;
            this.ClearButton.Text = "すべて削除";
            this.ClearButton.UseVisualStyleBackColor = false;
            //
            // HeaderPanel
            //
            this.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(39)))), ((int)(((byte)(45)))));
            this.HeaderPanel.Controls.Add(this.ImagePictureBox);
            this.HeaderPanel.Controls.Add(this.TitleButton);
            this.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.HeaderPanel.Margin = new System.Windows.Forms.Padding(0);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(684, 35);
            this.HeaderPanel.TabIndex = 3;
            //
            // ImagePictureBox
            //
            this.ImagePictureBox.BackgroundImage = global::Cube.Pdf.App.Pages.Properties.Resources.HeaderImage;
            this.ImagePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ImagePictureBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.ImagePictureBox.Location = new System.Drawing.Point(418, 0);
            this.ImagePictureBox.Name = "ImagePictureBox";
            this.ImagePictureBox.Size = new System.Drawing.Size(266, 35);
            this.ImagePictureBox.TabIndex = 1;
            this.ImagePictureBox.TabStop = false;
            //
            // TitleButton
            //
            this.TitleButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TitleButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.TitleButton.Image = global::Cube.Pdf.App.Pages.Properties.Resources.HeaderTitle;
            this.TitleButton.Location = new System.Drawing.Point(0, 0);
            this.TitleButton.Margin = new System.Windows.Forms.Padding(0);
            this.TitleButton.Name = "TitleButton";
            this.TitleButton.Size = new System.Drawing.Size(160, 35);
            this.TitleButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.TitleButton.TabIndex = 0;
            this.TitleButton.TabStop = false;
            //
            // FileListView
            //
            this.FileListView.AllowUserToAddRows = false;
            this.FileListView.AllowUserToDeleteRows = false;
            this.FileListView.AllowUserToResizeRows = false;
            this.FileListView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.FileListView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.FileListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FileListView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.FileListView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.FileListView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.FileListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FileListView.GridColor = System.Drawing.SystemColors.Control;
            this.FileListView.Location = new System.Drawing.Point(0, 0);
            this.FileListView.Margin = new System.Windows.Forms.Padding(0);
            this.FileListView.Name = "FileListView";
            this.FileListView.ReadOnly = true;
            this.FileListView.RowHeadersVisible = false;
            this.FileListView.RowTemplate.Height = 21;
            this.FileListView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.FileListView.Size = new System.Drawing.Size(560, 216);
            this.FileListView.TabIndex = 3;
            //
            // MainForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.ClientSize = new System.Drawing.Size(684, 311);
            this.Controls.Add(this.LayoutPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Location = new System.Drawing.Point(0, 0);
            this.MinimumSize = new System.Drawing.Size(300, 280);
            this.Name = "MainForm";
            this.Text = "CubePDF Page";
            this.LayoutPanel.ResumeLayout(false);
            this.FooterPanel.ResumeLayout(false);
            this.ExitButtonPanel.ResumeLayout(false);
            this.SplitButtonPanel.ResumeLayout(false);
            this.MergeButtonPanel.ResumeLayout(false);
            this.ContentsPanel.ResumeLayout(false);
            this.ButtonsPanel.ResumeLayout(false);
            this.HeaderPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ImagePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TitleButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FileListView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel LayoutPanel;
        private System.Windows.Forms.FlowLayoutPanel FooterPanel;
        private System.Windows.Forms.TableLayoutPanel ContentsPanel;
        private System.Windows.Forms.FlowLayoutPanel ButtonsPanel;
        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.PictureBox TitleButton;
        private System.Windows.Forms.PictureBox ImagePictureBox;
        private Cube.Forms.Button FileButton;
        private Cube.Forms.Button UpButton;
        private Cube.Forms.Button DownButton;
        private Cube.Forms.Button RemoveButton;
        private Cube.Forms.Button ClearButton;
        private System.Windows.Forms.Panel ExitButtonPanel;
        private Forms.Button ExitButton;
        private System.Windows.Forms.Panel SplitButtonPanel;
        private Forms.Button SplitButton;
        private System.Windows.Forms.Panel MergeButtonPanel;
        private Forms.Button MergeButton;
        private FileGridView FileListView;
    }
}

