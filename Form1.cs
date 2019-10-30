using System;
using System.Collections.Generic;
//using System.Collections.Specialized;
//using System.ComponentModel;
//using System.Data;
//using System.Diagnostics;
//using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
//using System.Threading;
//using System.Threading.Tasks;
using System.Windows.Forms;

namespace iwm_ClipToFileName
{
	public partial class Form1 : Form
	{
		private const string VERSION = @"Dir／Fileリスト iwm20191030";
		private const string CRLF = "\r\n";

		private readonly string[] ADirFile = { "Dir&File", "Dir", "File" };
		private readonly int[] DirLevel = { 0, 260 };
		private readonly List<string> LDirFileBase = new List<string>();
		private readonly List<string> LDirFileResult = new List<string>();
		private readonly StringBuilder SB = new StringBuilder();

		private const int EM_REPLACESEL = 0x00C2;

		[DllImport("User32.dll")]
		private static extern int SendMessage(IntPtr hWnd, int uMsg, int wParam, string lParam);

		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			Text = VERSION;

			// 初期化
			for (int _i1 = DirLevel[0]; _i1 <= DirLevel[1]; _i1++)
			{
				_ = CbDepth.Items.Add(_i1);
			}

			CmsDepth_上へ.Text = CbDepth.Text = DirLevel[0].ToString();
			CmsDepth_下へ.Text = DirLevel[1].ToString();

			foreach (string _s1 in ADirFile)
			{
				_ = CbType.Items.Add(_s1);
			}
			CbType.Text = ADirFile[0];

			TbSearch.Text = "";

			// クリップボードから読込
			if (Clipboard.ContainsFileDropList())
			{
				// 追記不可
				LDirFileBase.Clear();
				LDirFileResult.Clear();

				foreach (string _s1 in Clipboard.GetFileDropList())
				{
					string s02 = _s1;
					if (Directory.Exists(_s1))
					{
						s02 = s02.TrimEnd('\\') + @"\";
					}
					LDirFileBase.Add(s02);
				}
				LDirFileBase.Sort();

				SubTextboxToListInit(false);
			}
			else
			{
				TbResult.Text = "フォルダ／ファイル を ドロップ してください。";
				Lbl1.Text = "0";
			}
		}

		private void TbResult_DragEnter(object sender, DragEventArgs e)
		{
			// 追記不可
			TbResult.Text = "";

			LDirFileBase.Clear();
			LDirFileResult.Clear();

			foreach (string _s1 in (string[])e.Data.GetData(DataFormats.FileDrop, false))
			{
				string s02 = _s1.TrimEnd();
				if (Directory.Exists(s02))
				{
					s02 = s02.TrimEnd('\\') + @"\";
				}
				LDirFileBase.Add(s02);
			}
			LDirFileBase.Sort();

			SubTextboxToListInit(false);
		}

		private void CmsResult_フォルダ選択_Click(object sender, EventArgs e)
		{
			SubDirSelect();
			SubTextboxToListInit();
		}

		private void CmsResult_クリア_Click(object sender, EventArgs e)
		{
			TbResult.Text = "";
			Lbl1.Text = "";

			LDirFileBase.Clear();
			LDirFileResult.Clear();
		}

		private void CmsResult_全選択コピー_Click(object sender, EventArgs e)
		{
			_ = TbResult.Focus();
			TbResult.SelectAll();
			TbResult.Copy();
		}

		private void CmsResult_コピー_Click(object sender, EventArgs e)
		{
			TbResult.Copy();
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
			using (SaveFileDialog saveFileDialog1 = new SaveFileDialog
			{
				InitialDirectory = ".",
				FileName = DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".txt",
				Filter = "All files (*.*)|*.*",
				FilterIndex = 1
			})
			{
				if (saveFileDialog1.ShowDialog() == DialogResult.OK)
				{
					switch (code.ToUpper())
					{
						case "UTF-8N":
							UTF8Encoding utf8nEnc = new UTF8Encoding(false);
							File.WriteAllText(saveFileDialog1.FileName, TB.Text, utf8nEnc);
							break;

						default:
							File.WriteAllText(saveFileDialog1.FileName, TB.Text, Encoding.GetEncoding("Shift_JIS"));
							break;
					}
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

		private void BtnExec_Click(object sender, EventArgs e)
		{
			TbResult.Text = "";
			Lbl1.Text = "0";

			if (LDirFileBase.Count == 0)
			{
				return;
			}

			Cursor.Current = Cursors.WaitCursor;

			LDirFileResult.Clear();

			string wildCard = @"*.*";
			int depth = RtnStrToInt(CbDepth.Text);

			foreach (string dirName in LDirFileBase)
			{
				int levelMax = RtnSerchCharCnt(dirName, '\\') + depth;
				--levelMax;// -1 しておく

				SubGetDF01(dirName, wildCard, levelMax);
				SubGetDF11(dirName, wildCard, levelMax);
			}

			// 検索
			try
			{
				LDirFileResult.Sort();

				int cnt = 0;

				_ = SB.Clear();

				if (TbSearch.Text.Length > 0 && LDirFileResult.Count > 0)
				{
					foreach (string _s1 in LDirFileResult)
					{
						if (_s1.IndexOf(TbSearch.Text, StringComparison.OrdinalIgnoreCase) >= 0)
						{
							_ = SB.Append(_s1.TrimEnd() + CRLF);
							++cnt;
						}
					}
				}
				else
				{
					foreach (string _s1 in LDirFileResult)
					{
						_ = SB.Append(_s1.TrimEnd() + CRLF);
					}
					cnt = LDirFileResult.Count;
				}
				_ = SendMessage(TbResult.Handle, EM_REPLACESEL, 1, SB.ToString());
				Lbl1.Text = cnt.ToString();
			}
			catch
			{
			}

			Cursor.Current = Cursor.Current;
		}

		private void SubTextboxToListInit(
			bool B = true
		)
		{
			TbResult.Text = "";

			_ = SB.Clear();
			foreach (string _s1 in LDirFileBase)
			{
				_ = SB.Append(_s1 + CRLF);
			}
			_ = SendMessage(TbResult.Handle, EM_REPLACESEL, 1, SB.ToString());

			int cnt = LDirFileBase.Count();

			Lbl1.Text = B ? cnt.ToString() : "";
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
			if (levelMax <= RtnSerchCharCnt(dirName.TrimEnd('\\'), '\\'))
			{
				return;
			}

			try
			{
				// 子
				DirectoryInfo dirInfo = new DirectoryInfo(dirName);
				foreach (DirectoryInfo FI in dirInfo.EnumerateDirectories("*"))
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
			catch
			{
				return;// Err
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
				DirectoryInfo dirInfo = new DirectoryInfo(dirName);
				foreach (FileInfo FI in dirInfo.EnumerateFiles(wildCard, SearchOption.TopDirectoryOnly))
				{
					LDirFileResult.Add(FI.FullName);
				}
			}
			catch
			{
				return;// Err
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
			using (FolderBrowserDialog fbd = new FolderBrowserDialog
			{
				Description = "フォルダを指定してください。",
				RootFolder = Environment.SpecialFolder.Desktop,
				SelectedPath = Environment.CurrentDirectory,
				ShowNewFolderButton = true
			})
			{
				if (fbd.ShowDialog(this) == DialogResult.OK)
				{
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
		}

		private void CmsSearch_クリア_Click(object sender, EventArgs e)
		{
			TbSearch.Text = "";
			TbSearch.Focus();
		}

		private void CmsSearch_貼り付け_Click(object sender, EventArgs e)
		{
			TbSearch.Text = Clipboard.GetText();
			TbSearch.Focus();
		}

		public string GblCB3 = "";

		private void ComboBox3_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
		{
			GblCB3 = CbType.Text;
		}

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
