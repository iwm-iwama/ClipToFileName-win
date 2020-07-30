namespace iwm_ClipToFileName
{
	partial class Form1
	{
		/// <summary>
		/// 必要なデザイナー変数です。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 使用中のリソースをすべてクリーンアップします。
		/// </summary>
		/// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
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
			this.components = new System.ComponentModel.Container();
			this.TbResult = new System.Windows.Forms.TextBox();
			this.CmsResult = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.CmsResult_フォルダ選択 = new System.Windows.Forms.ToolStripMenuItem();
			this.CmsResult_L1 = new System.Windows.Forms.ToolStripSeparator();
			this.CmsResult_全コピー = new System.Windows.Forms.ToolStripMenuItem();
			this.CmsResult_コピー = new System.Windows.Forms.ToolStripMenuItem();
			this.CmsResult_L2 = new System.Windows.Forms.ToolStripSeparator();
			this.CmsResult_名前を付けて保存 = new System.Windows.Forms.ToolStripMenuItem();
			this.CmsResult_名前を付けて保存_ShiftJIS = new System.Windows.Forms.ToolStripMenuItem();
			this.CmsResult_名前を付けて保存_UTF8N = new System.Windows.Forms.ToolStripMenuItem();
			this.CbDepth = new System.Windows.Forms.ComboBox();
			this.CmsDepth = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.CmsDepth_上へ = new System.Windows.Forms.ToolStripMenuItem();
			this.CmsDepth_下へ = new System.Windows.Forms.ToolStripMenuItem();
			this.CmsNull = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.BtnExec = new System.Windows.Forms.Button();
			this.TbSearch = new System.Windows.Forms.TextBox();
			this.CmsSearch = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.CmsSearch_クリア = new System.Windows.Forms.ToolStripMenuItem();
			this.CmsSearch_貼り付け = new System.Windows.Forms.ToolStripMenuItem();
			this.CbType = new System.Windows.Forms.ComboBox();
			this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.BtnCopy = new System.Windows.Forms.Button();
			this.CmsResult.SuspendLayout();
			this.CmsDepth.SuspendLayout();
			this.CmsSearch.SuspendLayout();
			this.SuspendLayout();
			// 
			// TbResult
			// 
			this.TbResult.AllowDrop = true;
			this.TbResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.TbResult.BackColor = System.Drawing.Color.Black;
			this.TbResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.TbResult.ContextMenuStrip = this.CmsResult;
			this.TbResult.Font = new System.Drawing.Font("ＭＳ Ｐゴシック", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.TbResult.ForeColor = System.Drawing.Color.Lime;
			this.TbResult.Location = new System.Drawing.Point(10, 10);
			this.TbResult.Margin = new System.Windows.Forms.Padding(0);
			this.TbResult.MaxLength = 2147483647;
			this.TbResult.Multiline = true;
			this.TbResult.Name = "TbResult";
			this.TbResult.ReadOnly = true;
			this.TbResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.TbResult.Size = new System.Drawing.Size(315, 110);
			this.TbResult.TabIndex = 0;
			this.TbResult.TabStop = false;
			this.TbResult.WordWrap = false;
			this.TbResult.DragEnter += new System.Windows.Forms.DragEventHandler(this.TbResult_DragEnter);
			this.TbResult.MouseHover += new System.EventHandler(this.TbResult_MouseHover);
			// 
			// CmsResult
			// 
			this.CmsResult.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.CmsResult.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CmsResult_フォルダ選択,
            this.CmsResult_L1,
            this.CmsResult_全コピー,
            this.CmsResult_コピー,
            this.CmsResult_L2,
            this.CmsResult_名前を付けて保存});
			this.CmsResult.Name = "contextMenuStrip1";
			this.CmsResult.Size = new System.Drawing.Size(181, 126);
			// 
			// CmsResult_フォルダ選択
			// 
			this.CmsResult_フォルダ選択.Name = "CmsResult_フォルダ選択";
			this.CmsResult_フォルダ選択.Size = new System.Drawing.Size(180, 22);
			this.CmsResult_フォルダ選択.Text = "フォルダ選択";
			this.CmsResult_フォルダ選択.Click += new System.EventHandler(this.CmsResult_フォルダ選択_Click);
			// 
			// CmsResult_L1
			// 
			this.CmsResult_L1.Name = "CmsResult_L1";
			this.CmsResult_L1.Size = new System.Drawing.Size(177, 6);
			// 
			// CmsResult_全コピー
			// 
			this.CmsResult_全コピー.Name = "CmsResult_全コピー";
			this.CmsResult_全コピー.Size = new System.Drawing.Size(180, 22);
			this.CmsResult_全コピー.Text = "全コピー";
			this.CmsResult_全コピー.Click += new System.EventHandler(this.CmsResult_全コピー_Click);
			// 
			// CmsResult_コピー
			// 
			this.CmsResult_コピー.Name = "CmsResult_コピー";
			this.CmsResult_コピー.Size = new System.Drawing.Size(180, 22);
			this.CmsResult_コピー.Text = "コピー";
			this.CmsResult_コピー.Click += new System.EventHandler(this.CmsResult_コピー_Click);
			// 
			// CmsResult_L2
			// 
			this.CmsResult_L2.Name = "CmsResult_L2";
			this.CmsResult_L2.Size = new System.Drawing.Size(177, 6);
			// 
			// CmsResult_名前を付けて保存
			// 
			this.CmsResult_名前を付けて保存.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CmsResult_名前を付けて保存_ShiftJIS,
            this.CmsResult_名前を付けて保存_UTF8N});
			this.CmsResult_名前を付けて保存.Name = "CmsResult_名前を付けて保存";
			this.CmsResult_名前を付けて保存.Size = new System.Drawing.Size(180, 22);
			this.CmsResult_名前を付けて保存.Text = "名前を付けて保存";
			// 
			// CmsResult_名前を付けて保存_ShiftJIS
			// 
			this.CmsResult_名前を付けて保存_ShiftJIS.Name = "CmsResult_名前を付けて保存_ShiftJIS";
			this.CmsResult_名前を付けて保存_ShiftJIS.Size = new System.Drawing.Size(116, 22);
			this.CmsResult_名前を付けて保存_ShiftJIS.Text = "Shift_JIS";
			this.CmsResult_名前を付けて保存_ShiftJIS.Click += new System.EventHandler(this.CmsResult_名前を付けて保存_ShiftJIS_Click);
			// 
			// CmsResult_名前を付けて保存_UTF8N
			// 
			this.CmsResult_名前を付けて保存_UTF8N.Name = "CmsResult_名前を付けて保存_UTF8N";
			this.CmsResult_名前を付けて保存_UTF8N.Size = new System.Drawing.Size(116, 22);
			this.CmsResult_名前を付けて保存_UTF8N.Text = "UTF-8N";
			this.CmsResult_名前を付けて保存_UTF8N.Click += new System.EventHandler(this.CmsResult_名前を付けて保存_UTF8N_Click);
			// 
			// CbDepth
			// 
			this.CbDepth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.CbDepth.BackColor = System.Drawing.Color.DimGray;
			this.CbDepth.ContextMenuStrip = this.CmsDepth;
			this.CbDepth.DropDownHeight = 130;
			this.CbDepth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.CbDepth.DropDownWidth = 50;
			this.CbDepth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.CbDepth.Font = new System.Drawing.Font("ＭＳ Ｐゴシック", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.CbDepth.ForeColor = System.Drawing.Color.White;
			this.CbDepth.FormattingEnabled = true;
			this.CbDepth.IntegralHeight = false;
			this.CbDepth.ItemHeight = 13;
			this.CbDepth.Location = new System.Drawing.Point(85, 129);
			this.CbDepth.Margin = new System.Windows.Forms.Padding(0);
			this.CbDepth.Name = "CbDepth";
			this.CbDepth.Size = new System.Drawing.Size(45, 21);
			this.CbDepth.TabIndex = 3;
			this.CbDepth.TabStop = false;
			this.ToolTip1.SetToolTip(this.CbDepth, "表示する階層");
			// 
			// CmsDepth
			// 
			this.CmsDepth.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CmsDepth_上へ,
            this.CmsDepth_下へ});
			this.CmsDepth.Name = "contextMenuStrip3";
			this.CmsDepth.Size = new System.Drawing.Size(68, 48);
			// 
			// CmsDepth_上へ
			// 
			this.CmsDepth_上へ.ForeColor = System.Drawing.Color.Black;
			this.CmsDepth_上へ.Name = "CmsDepth_上へ";
			this.CmsDepth_上へ.Size = new System.Drawing.Size(67, 22);
			this.CmsDepth_上へ.Click += new System.EventHandler(this.CmsDepth_上へ_Click);
			// 
			// CmsDepth_下へ
			// 
			this.CmsDepth_下へ.ForeColor = System.Drawing.Color.Black;
			this.CmsDepth_下へ.Name = "CmsDepth_下へ";
			this.CmsDepth_下へ.Size = new System.Drawing.Size(67, 22);
			this.CmsDepth_下へ.Click += new System.EventHandler(this.CmsDepth_下へ_Click);
			// 
			// CmsNull
			// 
			this.CmsNull.Name = "contextMenuStrip0";
			this.CmsNull.Size = new System.Drawing.Size(61, 4);
			// 
			// BtnExec
			// 
			this.BtnExec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.BtnExec.BackColor = System.Drawing.Color.DimGray;
			this.BtnExec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnExec.Font = new System.Drawing.Font("ＭＳ Ｐゴシック", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.BtnExec.ForeColor = System.Drawing.Color.White;
			this.BtnExec.Location = new System.Drawing.Point(275, 128);
			this.BtnExec.Margin = new System.Windows.Forms.Padding(0);
			this.BtnExec.Name = "BtnExec";
			this.BtnExec.Size = new System.Drawing.Size(50, 22);
			this.BtnExec.TabIndex = 6;
			this.BtnExec.Text = "検索";
			this.BtnExec.UseVisualStyleBackColor = false;
			this.BtnExec.Click += new System.EventHandler(this.BtnExec_Click);
			// 
			// TbSearch
			// 
			this.TbSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.TbSearch.BackColor = System.Drawing.Color.WhiteSmoke;
			this.TbSearch.ContextMenuStrip = this.CmsSearch;
			this.TbSearch.Font = new System.Drawing.Font("ＭＳ ゴシック", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.TbSearch.ForeColor = System.Drawing.Color.Black;
			this.TbSearch.ImeMode = System.Windows.Forms.ImeMode.Off;
			this.TbSearch.Location = new System.Drawing.Point(207, 129);
			this.TbSearch.Margin = new System.Windows.Forms.Padding(0);
			this.TbSearch.Name = "TbSearch";
			this.TbSearch.Size = new System.Drawing.Size(65, 20);
			this.TbSearch.TabIndex = 5;
			this.ToolTip1.SetToolTip(this.TbSearch, "検索文字列");
			this.TbSearch.WordWrap = false;
			this.TbSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TbSearch_KeyUp);
			// 
			// CmsSearch
			// 
			this.CmsSearch.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CmsSearch_クリア,
            this.CmsSearch_貼り付け});
			this.CmsSearch.Name = "contextMenuStrip2";
			this.CmsSearch.Size = new System.Drawing.Size(116, 48);
			// 
			// CmsSearch_クリア
			// 
			this.CmsSearch_クリア.Name = "CmsSearch_クリア";
			this.CmsSearch_クリア.Size = new System.Drawing.Size(115, 22);
			this.CmsSearch_クリア.Text = "クリア";
			this.CmsSearch_クリア.Click += new System.EventHandler(this.CmsSearch_クリア_Click);
			// 
			// CmsSearch_貼り付け
			// 
			this.CmsSearch_貼り付け.Name = "CmsSearch_貼り付け";
			this.CmsSearch_貼り付け.Size = new System.Drawing.Size(115, 22);
			this.CmsSearch_貼り付け.Text = "貼り付け";
			this.CmsSearch_貼り付け.Click += new System.EventHandler(this.CmsSearch_貼り付け_Click);
			// 
			// CbType
			// 
			this.CbType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.CbType.BackColor = System.Drawing.Color.DimGray;
			this.CbType.ContextMenuStrip = this.CmsNull;
			this.CbType.DropDownHeight = 130;
			this.CbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.CbType.DropDownWidth = 50;
			this.CbType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.CbType.Font = new System.Drawing.Font("ＭＳ Ｐゴシック", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.CbType.ForeColor = System.Drawing.Color.White;
			this.CbType.FormattingEnabled = true;
			this.CbType.IntegralHeight = false;
			this.CbType.ItemHeight = 13;
			this.CbType.Location = new System.Drawing.Point(134, 129);
			this.CbType.Margin = new System.Windows.Forms.Padding(0);
			this.CbType.Name = "CbType";
			this.CbType.Size = new System.Drawing.Size(70, 21);
			this.CbType.TabIndex = 4;
			this.CbType.TabStop = false;
			this.ToolTip1.SetToolTip(this.CbType, "フィルタ");
			// 
			// BtnCopy
			// 
			this.BtnCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.BtnCopy.BackColor = System.Drawing.Color.DimGray;
			this.BtnCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnCopy.Font = new System.Drawing.Font("ＭＳ Ｐゴシック", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.BtnCopy.ForeColor = System.Drawing.Color.White;
			this.BtnCopy.Location = new System.Drawing.Point(10, 128);
			this.BtnCopy.Margin = new System.Windows.Forms.Padding(0);
			this.BtnCopy.Name = "BtnCopy";
			this.BtnCopy.Size = new System.Drawing.Size(65, 22);
			this.BtnCopy.TabIndex = 2;
			this.BtnCopy.TabStop = false;
			this.BtnCopy.Text = "コピー";
			this.BtnCopy.UseVisualStyleBackColor = false;
			this.BtnCopy.Click += new System.EventHandler(this.BtnCopy_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.DimGray;
			this.ClientSize = new System.Drawing.Size(334, 161);
			this.Controls.Add(this.BtnCopy);
			this.Controls.Add(this.CbType);
			this.Controls.Add(this.CbDepth);
			this.Controls.Add(this.TbSearch);
			this.Controls.Add(this.BtnExec);
			this.Controls.Add(this.TbResult);
			this.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.MinimumSize = new System.Drawing.Size(350, 200);
			this.Name = "Form1";
			this.ShowIcon = false;
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ダミータイトル";
			this.TopMost = true;
			this.Load += new System.EventHandler(this.Form1_Load);
			this.CmsResult.ResumeLayout(false);
			this.CmsDepth.ResumeLayout(false);
			this.CmsSearch.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox TbResult;
		private System.Windows.Forms.ComboBox CbDepth;
		private System.Windows.Forms.ContextMenuStrip CmsResult;
		private System.Windows.Forms.ToolStripMenuItem CmsResult_全コピー;
		private System.Windows.Forms.ToolStripMenuItem CmsResult_コピー;
		private System.Windows.Forms.Button BtnExec;
		private System.Windows.Forms.ToolStripSeparator CmsResult_L1;
		private System.Windows.Forms.ToolStripMenuItem CmsResult_フォルダ選択;
		private System.Windows.Forms.TextBox TbSearch;
		private System.Windows.Forms.ContextMenuStrip CmsSearch;
		private System.Windows.Forms.ToolStripMenuItem CmsSearch_クリア;
		private System.Windows.Forms.ToolStripMenuItem CmsSearch_貼り付け;
		private System.Windows.Forms.ComboBox CbType;
		private System.Windows.Forms.ContextMenuStrip CmsNull;
		private System.Windows.Forms.ContextMenuStrip CmsDepth;
		private System.Windows.Forms.ToolStripMenuItem CmsDepth_上へ;
		private System.Windows.Forms.ToolStripMenuItem CmsDepth_下へ;
		private System.Windows.Forms.ToolStripSeparator CmsResult_L2;
		private System.Windows.Forms.ToolStripMenuItem CmsResult_名前を付けて保存;
		private System.Windows.Forms.ToolStripMenuItem CmsResult_名前を付けて保存_ShiftJIS;
		private System.Windows.Forms.ToolStripMenuItem CmsResult_名前を付けて保存_UTF8N;
		private System.Windows.Forms.ToolTip ToolTip1;
		private System.Windows.Forms.Button BtnCopy;
	}
}

