using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace iwm_ClipToFileName
{
	public partial class Form1 : Form
	{
		private const string VERSION = "Dir／Fileリスト iwm20210614";
		private const string NL = "\r\n";

		private static readonly string[] ARGS = Environment.GetCommandLineArgs();
		private readonly string[] ADirFile = { "Dir&File", "Dir", "File" };
		private readonly int[] DirLevel = { 0, 260 };
		private readonly List<string> LDirFileBase = new List<string>();
		private readonly List<string> LDirFileResult = new List<string>();
		private readonly StringBuilder SB = new StringBuilder();

		private int DispCnt = 0;

		internal static class NativeMethods
		{
			[DllImport("User32.dll", CharSet = CharSet.Unicode)]
			internal static extern int SendMessage(IntPtr hWnd, int uMsg, int wParam, string lParam);
		}

		private const int EM_REPLACESEL = 0x00C2;

		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			StartPosition = FormStartPosition.Manual;
			SubForm1_StartPosition();

			Text = VERSION;

			// 初期化
			for (int _i1 = DirLevel[0]; _i1 <= DirLevel[1]; _i1++)
			{
				_ = CbDepth.Items.Add(_i1);
			}
			CbDepth.Text = CmsDepth_上へ.Text = DirLevel[0].ToString();
			CmsDepth_下へ.Text = DirLevel[1].ToString();

			foreach (string _s1 in ADirFile)
			{
				_ = CbType.Items.Add(_s1);
			}
			CbType.Text = ADirFile[0];

			TbSearch.Text = "";

			// SendTo 利用
			if (ARGS.Length > 1)
			{
				// 追記不可
				LDirFileBase.Clear();
				LDirFileResult.Clear();

				for (int _i1 = 1; _i1 < ARGS.Length; _i1++)
				{
					string _s1 = ARGS[_i1];
					if (Directory.Exists(_s1))
					{
						_s1 = _s1.TrimEnd('\\') + @"\";
					}
					LDirFileBase.Add(_s1);
				}
				LDirFileBase.Sort();

				SubTextboxToListInit();
			}
			else
			{
				TbResult.Text = "フォルダ／ファイル を ドロップ してください。";
			}
		}

		private void SubForm1_StartPosition()
		{
			int WorkingAreaW = Screen.PrimaryScreen.WorkingArea.Width;
			int WorkingAreaH = Screen.PrimaryScreen.WorkingArea.Height;

			int WorkingAreaX = Screen.PrimaryScreen.WorkingArea.X;
			int WorkingAreaY = Screen.PrimaryScreen.WorkingArea.Y;

			int MouseX = Cursor.Position.X;
			int MouseY = Cursor.Position.Y;

			// X = Width
			if (WorkingAreaW < MouseX + Size.Width)
			{
				MouseX -= Size.Width;
				if (MouseX < 0)
				{
					MouseX = WorkingAreaX + 10;
				}
			}

			// Y = Height
			if (WorkingAreaH < MouseY + Size.Height)
			{
				MouseY -= Size.Height;
				if (MouseY < 0)
				{
					MouseY = WorkingAreaY + 10;
				}
			}

			Location = new Point(MouseX, MouseY);
		}

		private void TbResult_DragEnter(object sender, DragEventArgs e)
		{
			e.Effect = e.Data.GetDataPresent(DataFormats.FileDrop) ? DragDropEffects.All : DragDropEffects.None;
		}

		private void TbResult_DragDrop(object sender, DragEventArgs e)
		{
			string[] aFn = (string[])e.Data.GetData(DataFormats.FileDrop, false);

			Directory.SetCurrentDirectory(Path.GetDirectoryName(aFn[0]));

			// 追記不可
			TbResult.Text = "";

			LDirFileBase.Clear();
			LDirFileResult.Clear();

			foreach (string _s1 in aFn)
			{
				string s02 = _s1.TrimEnd();
				if (Directory.Exists(s02))
				{
					s02 = s02.TrimEnd('\\') + @"\";
				}
				LDirFileBase.Add(s02);
			}
			LDirFileBase.Sort();

			SubTextboxToListInit();

			// 再検索
			BtnExec_Click(sender, e);
		}

		private void TbResult_MouseHover(object sender, EventArgs e)
		{
			ToolTip1.SetToolTip(TbResult, DispCnt.ToString() + "個");
		}

		private void CmsResult_フォルダ選択_Click(object sender, EventArgs e)
		{
			SubDirSelect();
			SubTextboxToListInit();
		}

		private void CmsResult_名前を付けて保存_ShiftJIS_Click(object sender, EventArgs e)
		{
			SubTextBoxToSaveFile(CmsResult_名前を付けて保存_ShiftJIS.Text);
		}

		private void CmsResult_名前を付けて保存_UTF8N_Click(object sender, EventArgs e)
		{
			SubTextBoxToSaveFile(CmsResult_名前を付けて保存_UTF8N.Text);
		}

		// ファイル保存
		private void SubTextBoxToSaveFile(
			string code
		)
		{
			TextBox TB = TbResult;

			SaveFileDialog sfd = new SaveFileDialog
			{
				FileName = DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".txt",
				Filter = "All files (*.*)|*.*",
				FilterIndex = 1,
				InitialDirectory = Environment.CurrentDirectory
			};

			if (sfd.ShowDialog() == DialogResult.OK)
			{
				switch (code.ToUpper())
				{
					case "UTF-8N":
						UTF8Encoding utf8nEnc = new UTF8Encoding(false);
						File.WriteAllText(sfd.FileName, TB.Text, utf8nEnc);
						break;

					default:
						File.WriteAllText(sfd.FileName, TB.Text, Encoding.GetEncoding("Shift_JIS"));
						break;
				}
			}
		}

		private void CmsDepth_上へ_Click(object sender, EventArgs e)
		{
			CbDepth.Text = CmsDepth_上へ.Text;
		}

		private void CmsDepth_下へ_Click(object sender, EventArgs e)
		{
			CbDepth.Text = CmsDepth_下へ.Text;
		}

		private void BtnCopy_Click(object sender, EventArgs e)
		{
			TbResult.SelectAll();
			TbResult.Copy();
		}

		private void TbSearch_KeyUp(object sender, KeyEventArgs e)
		{
			switch (e.KeyCode)
			{
				case (Keys.Enter):
					BtnExec_Click(sender, e);
					break;
			}
		}

		private void BtnExec_Click(object sender, EventArgs e)
		{
			Cursor.Current = Cursors.WaitCursor;
			
			TbResult.Text = "";

			if (LDirFileBase.Count == 0)
			{
				return;
			}

			LDirFileResult.Clear();

			string wildCard = "*.*";
			int depth = RtnStrToInt(CbDepth.Text);

			foreach (string dirName in LDirFileBase)
			{
				int levelMax = RtnSerchCharCnt(dirName.TrimEnd('\\'), '\\') + depth;

				SubGetDF01(dirName, wildCard, levelMax);
				SubGetDF11(dirName, wildCard, levelMax);
			}

			// 再検索
			try
			{
				LDirFileResult.Sort();

				_ = SB.Clear();

				if (TbSearch.Text.Length > 0 && LDirFileResult.Count > 0)
				{
					DispCnt = 0;
					foreach (string _s1 in LDirFileResult)
					{
						if (_s1.IndexOf(TbSearch.Text, StringComparison.OrdinalIgnoreCase) >= 0)
						{
							_ = SB.Append(_s1.TrimEnd() + NL);
							++DispCnt;
						}
					}
				}
				else
				{
					foreach (string _s1 in LDirFileResult)
					{
						_ = SB.Append(_s1.TrimEnd() + NL);
					}
					DispCnt = LDirFileResult.Count();
				}
				_ = NativeMethods.SendMessage(TbResult.Handle, EM_REPLACESEL, 1, SB.ToString());
			}
			catch
			{
			}

			Cursor.Current = Cursors.Default;
		}

		private void SubTextboxToListInit()
		{
			TbResult.Text = "";

			_ = SB.Clear();
			foreach (string _s1 in LDirFileBase)
			{
				_ = SB.Append(_s1 + NL);
			}
			_ = NativeMethods.SendMessage(TbResult.Handle, EM_REPLACESEL, 1, SB.ToString());

			DispCnt = LDirFileBase.Count();
		}

		private void SubGetDF01(
			string dirName,
			string wildCard,
			int levelMax
		)
		{
			// 親
			if (CbType.Text == ADirFile[0])
			{
				LDirFileResult.Add(dirName);
			}
			else if (CbType.Text == ADirFile[1] && Directory.Exists(dirName))
			{
				LDirFileResult.Add(dirName);
			}
			else if (CbType.Text == ADirFile[2] && File.Exists(dirName))
			{
				LDirFileResult.Add(dirName);
			}

			// 親直下
			SubGetDF12(dirName, wildCard, levelMax);
		}

		private void SubGetDF11(
			string dirName,
			string wildCard,
			int levelMax
		)
		{
			try
			{
				int iCnt = 1 + RtnSerchCharCnt(dirName.TrimEnd('\\'), '\\');

				// 子
				DirectoryInfo dirInfo = new DirectoryInfo(dirName);
				foreach (DirectoryInfo FI in dirInfo.EnumerateDirectories("*"))
				{
					if (levelMax >= iCnt)
					{
						SubGetDF12(FI.FullName, wildCard, levelMax);

						string dirName2 = FI.FullName + @"\";
						SubGetDF11(dirName2, wildCard, levelMax);

						if (CbType.Text != ADirFile[2])
						{
							LDirFileResult.Add(dirName2);
						}
					}
				}
			}
			catch
			{
				return; // Err
			}
		}

		private void SubGetDF12(
			string dirName,
			string wildCard,
			int levelMax
		)
		{
			if (CbType.Text == ADirFile[1])
			{
				return;
			}

			try
			{
				int iCnt = 1 + RtnSerchCharCnt(dirName.TrimEnd('\\'), '\\');

				DirectoryInfo dirInfo = new DirectoryInfo(dirName);
				foreach (FileInfo FI in dirInfo.EnumerateFiles(wildCard, SearchOption.TopDirectoryOnly))
				{
					if (levelMax >= iCnt)
					{
						LDirFileResult.Add(FI.FullName);
					}
				}
			}
			catch
			{
				return; // Err
			}
		}

		private int RtnSerchCharCnt(
			string s,
			char c
		)
		{
			int rtn = 0;
			foreach (char _c1 in s.ToCharArray())
			{
				if (_c1 == c)
				{
					++rtn;
				}
			}
			return rtn;
		}

		private void SubDirSelect()
		{
			FolderBrowserDialog fbd = new FolderBrowserDialog
			{
				Description = "フォルダを指定してください。",
				RootFolder = Environment.SpecialFolder.MyComputer,
				SelectedPath = Environment.CurrentDirectory,
				ShowNewFolderButton = false
			};

			if (fbd.ShowDialog(this) == DialogResult.OK)
			{
				Directory.SetCurrentDirectory(fbd.SelectedPath);

				LDirFileBase.Clear();
				LDirFileResult.Clear();

				foreach (string _s1 in fbd.SelectedPath.Split('\n'))
				{
					string s02 = _s1.TrimEnd();
					if (Directory.Exists(s02))
					{
						s02 = s02.TrimEnd('\\') + @"\";
					}
					LDirFileBase.Add(s02);
				}
				LDirFileBase.Sort();
			}
		}

		private void CmsSearch_全クリア_Click(object sender, EventArgs e)
		{
			TbSearch.Text = "";
			_ = TbSearch.Focus();
		}

		private void CmsSearch_貼り付け_Click(object sender, EventArgs e)
		{
			TbSearch.Text = Clipboard.GetText();
			_ = TbSearch.Focus();
		}

		public string GblCB3 = "";

		private int RtnStrToInt(
			string S
		)
		{
			try
			{
				return int.Parse(S);
			}
			catch
			{
				return 0;
			}
		}
	}
}
