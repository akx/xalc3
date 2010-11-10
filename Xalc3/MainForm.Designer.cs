
namespace Xalc3
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.entryBox = new System.Windows.Forms.TextBox();
			this.outputBox = new System.Windows.Forms.RichTextBox();
			this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.copyTranscriptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tableLayoutPanel1.SuspendLayout();
			this.contextMenu.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.entryBox, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.outputBox, 0, 1);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(284, 262);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// entryBox
			// 
			this.entryBox.AcceptsReturn = true;
			this.entryBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.entryBox.Location = new System.Drawing.Point(0, 0);
			this.entryBox.Margin = new System.Windows.Forms.Padding(0);
			this.entryBox.Name = "entryBox";
			this.entryBox.Size = new System.Drawing.Size(284, 22);
			this.entryBox.TabIndex = 0;
			this.entryBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EntryBoxKeyDown);
			this.entryBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EntryBoxKeyPress);
			// 
			// outputBox
			// 
			this.outputBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.outputBox.ContextMenuStrip = this.contextMenu;
			this.outputBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.outputBox.Location = new System.Drawing.Point(0, 22);
			this.outputBox.Margin = new System.Windows.Forms.Padding(0);
			this.outputBox.Name = "outputBox";
			this.outputBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
			this.outputBox.Size = new System.Drawing.Size(284, 240);
			this.outputBox.TabIndex = 1;
			this.outputBox.Text = "";
			// 
			// contextMenu
			// 
			this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.copyTranscriptToolStripMenuItem});
			this.contextMenu.Name = "contextMenu";
			this.contextMenu.ShowImageMargin = false;
			this.contextMenu.Size = new System.Drawing.Size(134, 26);
			// 
			// copyTranscriptToolStripMenuItem
			// 
			this.copyTranscriptToolStripMenuItem.Name = "copyTranscriptToolStripMenuItem";
			this.copyTranscriptToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
			this.copyTranscriptToolStripMenuItem.Text = "Copy Transcript";
			this.copyTranscriptToolStripMenuItem.Click += new System.EventHandler(this.CopyTranscriptToolStripMenuItemClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 262);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.Name = "MainForm";
			this.Text = "Xalc3";
			this.TopMost = true;
			this.Deactivate += new System.EventHandler(this.MainFormDeactivate);
			this.Activated += new System.EventHandler(this.MainFormActivated);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.contextMenu.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.ToolStripMenuItem copyTranscriptToolStripMenuItem;
		private System.Windows.Forms.ContextMenuStrip contextMenu;
		private System.Windows.Forms.RichTextBox outputBox;
		private System.Windows.Forms.TextBox entryBox;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
	}
}
