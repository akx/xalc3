using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using LuaInterface;

namespace Xalc3
{
	public partial class MainForm : Form
	{
		Lua lua;
		List<string> history;
		int historyIndex = 0;
		string lastResult = "";
		
		public MainForm()
		{
			InitializeComponent();
			lua = new Lua();
			history = new List<string>();
		}
		
		void MainFormActivated(object sender, EventArgs e)
		{
			entryBox.Focus();
			Opacity = 1;
		}
		
		void MainFormDeactivate(object sender, EventArgs e)
		{
			Opacity = .3;
		}
		
		void EntryBoxKeyPress(object sender, KeyPressEventArgs e)
		{
			if(e.KeyChar == 13) {
				string line = entryBox.Text.Trim();
				if(line == "") {
					Clipboard.SetText(lastResult);
					AddString("Last result " + lastResult + " copied.", Color.DarkOrange, true);
				} else {
					history.Insert(0, entryBox.Text);
					historyIndex = 0;
					EvaluateLine(entryBox.Text);
					entryBox.Text = "";
				}
				e.Handled = true;
			}
		}
		
		void EntryBoxKeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Up) {
				if(history.Count > 0) {
					int pos = entryBox.SelectionStart;
					entryBox.Text = history[(historyIndex++) % history.Count];
					entryBox.SelectionStart = pos + 1;
				}
			}
		}
		
		void EvaluateLine(string line) {
			bool isAssign = false;
			
			try {
				string func = line;
				if(line.Contains("=")) { // assume assignment
					isAssign = true;
				} else {
					func = "_ = " + func;
				}
				lua.DoString(func);
			} catch(Exception e) {
				AddString("Error: " + e.Message, Color.Red, true);
				return;
			}
			if(isAssign) {
				AddString("OK", Color.Green, true);
			} else {
				AddString(line, Color.Gray);
				AddString(" = ", Color.Black);
				object obj = lua["_"];
				if(obj == null) {
					AddString("?", Color.Purple, true);	
					return;
				} else if(obj is double) {
					double val = (double)obj;
					lastResult = val.ToString(CultureInfo.InvariantCulture);
				} else {
					lastResult = obj.ToString();
				}
				
				AddString(lastResult, Color.Black, true);
				Text = lastResult + " - Xalc3";
			}
		}
		
		void AddString(string text, Color color, bool addNewline) {
			outputBox.SelectionColor = color;
			outputBox.AppendText(text);
			if(addNewline) {
				outputBox.AppendText("\n");
				outputBox.ScrollToCaret();
			}
		}
		
		void AddString(string text, Color color) {
			AddString(text, color, false);
		}
		
		
		void CopyTranscriptToolStripMenuItemClick(object sender, EventArgs e)
		{
			Clipboard.SetText(outputBox.Text);
		}
	}
}
