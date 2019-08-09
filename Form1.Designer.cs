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
			this.CmsResult_クリア = new System.Windows.Forms.ToolStripMenuItem();
			this.CmsResult_全選択コピー = new System.Windows.Forms.ToolStripMenuItem();
			this.CmsResult_コピー = new System.Windows.Forms.ToolStripMenuItem();
			this.CmsResult_L2 = new System.Windows.Forms.ToolStripSeparator();
			this.CmsResult_名前を付けて保存 = new System.Windows.Forms.ToolStripMenuItem();
			this.CmsResult_名前を付けて保存_ShiftJIS = new System.Windows.Forms.ToolStripMenuItem();
			this.CmsResult_名前を付けて保存_UTF8N = new System.Windows.Forms.ToolStripMenuItem();
			this.CbDepth = new System.Windows.Forms.ComboBox();
			this.CmsDepth = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.CmsDepth_上へ = new System.Windows.Forms.ToolStripMenuItem();
			this.CmsDepth_L1 = new System.Windows.Forms.ToolStripSeparator();
			this.CmsDepth_下へ = new System.Windows.Forms.ToolStripMenuItem();
			this.CmsNull = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.Lbl2 = new System.Windows.Forms.Label();
			this.Lbl1 = new System.Windows.Forms.Label();
			this.BtnExec = new System.Windows.Forms.Button();
			this.TbSearch = new System.Windows.Forms.TextBox();
			this.CmsSearch = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.CmsSearch_クリア = new System.Windows.Forms.ToolStripMenuItem();
			this.CmsSearch_L1 = new System.Windows.Forms.ToolStripSeparator();
			this.CmsSearch_貼り付け = new System.Windows.Forms.ToolStripMenuItem();
			this.Lbl3 = new System.Windows.Forms.Label();
			this.CbType = new System.Windows.Forms.ComboBox();
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
			this.TbResult.Size = new System.Drawing.Size(445, 230);
			this.TbResult.TabIndex = 0;
			this.TbResult.TabStop = false;
			this.TbResult.WordWrap = false;
			this.TbResult.DragEnter += new System.Windows.Forms.DragEventHandler(this.TbResult_DragEnter);
			// 
			// CmsResult
			// 
			this.CmsResult.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.CmsResult.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CmsResult_フォルダ選択,
            this.CmsResult_L1,
            this.CmsResult_クリア,
            this.CmsResult_全選択コピー,
            this.CmsResult_コピー,
            this.CmsResult_L2,
            this.CmsResult_名前を付けて保存});
			this.CmsResult.Name = "contextMenuStrip1";
			this.CmsResult.Size = new System.Drawing.Size(162, 126);
			// 
			// CmsResult_フォルダ選択
			// 
			this.CmsResult_フォルダ選択.Name = "CmsResult_フォルダ選択";
			this.CmsResult_フォルダ選択.Size = new System.Drawing.Size(161, 22);
			this.CmsResult_フォルダ選択.Text = "フォルダ選択";
			this.CmsResult_フォルダ選択.Click += new System.EventHandler(this.CmsResult_フォルダ選択_Click);
			// 
			// CmsResult_L1
			// 
			this.CmsResult_L1.Name = "CmsResult_L1";
			this.CmsResult_L1.Size = new System.Drawing.Size(158, 6);
			// 
			// CmsResult_クリア
			// 
			this.CmsResult_クリア.Name = "CmsResult_クリア";
			this.CmsResult_クリア.Size = new System.Drawing.Size(161, 22);
			this.CmsResult_クリア.Text = "クリア";
			this.CmsResult_クリア.Click += new System.EventHandler(this.CmsResult_クリア_Click);
			// 
			// CmsResult_全選択コピー
			// 
			this.CmsResult_全選択コピー.Name = "CmsResult_全選択コピー";
			this.CmsResult_全選択コピー.Size = new System.Drawing.Size(161, 22);
			this.CmsResult_全選択コピー.Text = "全選択コピー";
			this.CmsResult_全選択コピー.Click += new System.EventHandler(this.CmsResult_全選択コピー_Click);
			// 
			// CmsResult_コピー
			// 
			this.CmsResult_コピー.Name = "CmsResult_コピー";
			this.CmsResult_コピー.Size = new System.Drawing.Size(161, 22);
			this.CmsResult_コピー.Text = "コピー";
			this.CmsResult_コピー.Click += new System.EventHandler(this.CmsResult_コピー_Click);
			// 
			// CmsResult_L2
			// 
			this.CmsResult_L2.Name = "CmsResult_L2";
			this.CmsResult_L2.Size = new System.Drawing.Size(158, 6);
			// 
			// CmsResult_名前を付けて保存
			// 
			this.CmsResult_名前を付けて保存.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CmsResult_名前を付けて保存_ShiftJIS,
            this.CmsResult_名前を付けて保存_UTF8N});
			this.CmsResult_名前を付けて保存.Name = "CmsResult_名前を付けて保存";
			this.CmsResult_名前を付けて保存.Size = new System.Drawing.Size(161, 22);
			this.CmsResult_名前を付けて保存.Text = "名前を付けて保存";
			// 
			// CmsResult_名前を付けて保存_ShiftJIS
			// 
			this.CmsResult_名前を付けて保存_ShiftJIS.Name = "CmsResult_名前を付けて保存_ShiftJIS";
			this.CmsResult_名前を付けて保存_ShiftJIS.Size = new System.Drawing.Size(180, 22);
			this.CmsResult_名前を付けて保存_ShiftJIS.Text = "Shift_JIS";
			this.CmsResult_名前を付けて保存_ShiftJIS.Click += new System.EventHandler(this.CmsResult_名前を付けて保存_ShiftJIS_Click);
			// 
			// CmsResult_名前を付けて保存_UTF8N
			// 
			this.CmsResult_名前を付けて保存_UTF8N.Name = "CmsResult_名前を付けて保存_UTF8N";
			this.CmsResult_名前を付けて保存_UTF8N.Size = new System.Drawing.Size(180, 22);
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
			this.CbDepth.Location = new System.Drawing.Point(145, 248);
			this.CbDepth.Margin = new System.Windows.Forms.Padding(0);
			this.CbDepth.Name = "CbDepth";
			this.CbDepth.Size = new System.Drawing.Size(45, 21);
			this.CbDepth.TabIndex = 3;
			// 
			// CmsDepth
			// 
			this.CmsDepth.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CmsDepth_上へ,
            this.CmsDepth_L1,
            this.CmsDepth_下へ});
			this.CmsDepth.Name = "contextMenuStrip3";
			this.CmsDepth.Size = new System.Drawing.Size(181, 76);
			// 
			// CmsDepth_上へ
			// 
			this.CmsDepth_上へ.ForeColor = System.Drawing.Color.Black;
			this.CmsDepth_上へ.Name = "CmsDepth_上へ";
			this.CmsDepth_上へ.Size = new System.Drawing.Size(180, 22);
			this.CmsDepth_上へ.Click += new System.EventHandler(this.CmsDepth_上へ_Click);
			// 
			// CmsDepth_L1
			// 
			this.CmsDepth_L1.Name = "CmsDepth_L1";
			this.CmsDepth_L1.Size = new System.Drawing.Size(177, 6);
			// 
			// CmsDepth_下へ
			// 
			this.CmsDepth_下へ.ForeColor = System.Drawing.Color.Black;
			this.CmsDepth_下へ.Name = "CmsDepth_下へ";
			this.CmsDepth_下へ.Size = new System.Drawing.Size(180, 22);
			this.CmsDepth_下へ.Click += new System.EventHandler(this.CmsDepth_下へ_Click);
			// 
			// CmsNull
			// 
			this.CmsNull.Name = "contextMenuStrip0";
			this.CmsNull.Size = new System.Drawing.Size(61, 4);
			// 
			// Lbl2
			// 
			this.Lbl2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.Lbl2.AutoSize = true;
			this.Lbl2.Font = new System.Drawing.Font("ＭＳ Ｐゴシック", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.Lbl2.ForeColor = System.Drawing.Color.Snow;
			this.Lbl2.Location = new System.Drawing.Point(112, 253);
			this.Lbl2.Margin = new System.Windows.Forms.Padding(0);
			this.Lbl2.Name = "Lbl2";
			this.Lbl2.Size = new System.Drawing.Size(33, 13);
			this.Lbl2.TabIndex = 2;
			this.Lbl2.Text = "階層";
			this.Lbl2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// Lbl1
			// 
			this.Lbl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.Lbl1.AutoSize = true;
			this.Lbl1.BackColor = System.Drawing.Color.Black;
			this.Lbl1.Font = new System.Drawing.Font("ＭＳ Ｐゴシック", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.Lbl1.ForeColor = System.Drawing.Color.Lime;
			this.Lbl1.Location = new System.Drawing.Point(10, 252);
			this.Lbl1.Margin = new System.Windows.Forms.Padding(0);
			this.Lbl1.Name = "Lbl1";
			this.Lbl1.Size = new System.Drawing.Size(43, 15);
			this.Lbl1.TabIndex = 1;
			this.Lbl1.Text = "label1";
			// 
			// BtnExec
			// 
			this.BtnExec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.BtnExec.BackColor = System.Drawing.Color.DimGray;
			this.BtnExec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnExec.Font = new System.Drawing.Font("ＭＳ Ｐゴシック", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.BtnExec.ForeColor = System.Drawing.Color.White;
			this.BtnExec.Location = new System.Drawing.Point(390, 247);
			this.BtnExec.Margin = new System.Windows.Forms.Padding(0);
			this.BtnExec.Name = "BtnExec";
			this.BtnExec.Size = new System.Drawing.Size(65, 24);
			this.BtnExec.TabIndex = 7;
			this.BtnExec.Text = "実行";
			this.BtnExec.UseVisualStyleBackColor = false;
			this.BtnExec.Click += new System.EventHandler(this.BtnExec_Click);
			// 
			// TbSearch
			// 
			this.TbSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.TbSearch.BackColor = System.Drawing.Color.GhostWhite;
			this.TbSearch.ContextMenuStrip = this.CmsSearch;
			this.TbSearch.Font = new System.Drawing.Font("ＭＳ ゴシック", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.TbSearch.ForeColor = System.Drawing.Color.Black;
			this.TbSearch.ImeMode = System.Windows.Forms.ImeMode.Off;
			this.TbSearch.Location = new System.Drawing.Point(300, 249);
			this.TbSearch.Margin = new System.Windows.Forms.Padding(0);
			this.TbSearch.Name = "TbSearch";
			this.TbSearch.Size = new System.Drawing.Size(80, 20);
			this.TbSearch.TabIndex = 6;
			this.TbSearch.WordWrap = false;
			// 
			// CmsSearch
			// 
			this.CmsSearch.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CmsSearch_クリア,
            this.CmsSearch_L1,
            this.CmsSearch_貼り付け});
			this.CmsSearch.Name = "contextMenuStrip2";
			this.CmsSearch.Size = new System.Drawing.Size(116, 54);
			// 
			// CmsSearch_クリア
			// 
			this.CmsSearch_クリア.Name = "CmsSearch_クリア";
			this.CmsSearch_クリア.Size = new System.Drawing.Size(115, 22);
			this.CmsSearch_クリア.Text = "クリア";
			this.CmsSearch_クリア.Click += new System.EventHandler(this.CmsSearch_クリア_Click);
			// 
			// CmsSearch_L1
			// 
			this.CmsSearch_L1.Name = "CmsSearch_L1";
			this.CmsSearch_L1.Size = new System.Drawing.Size(112, 6);
			// 
			// CmsSearch_貼り付け
			// 
			this.CmsSearch_貼り付け.Name = "CmsSearch_貼り付け";
			this.CmsSearch_貼り付け.Size = new System.Drawing.Size(115, 22);
			this.CmsSearch_貼り付け.Text = "貼り付け";
			this.CmsSearch_貼り付け.Click += new System.EventHandler(this.CmsSearch_貼り付け_Click);
			// 
			// Lbl3
			// 
			this.Lbl3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.Lbl3.AutoSize = true;
			this.Lbl3.Font = new System.Drawing.Font("ＭＳ Ｐゴシック", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.Lbl3.ForeColor = System.Drawing.Color.Snow;
			this.Lbl3.Location = new System.Drawing.Point(268, 253);
			this.Lbl3.Margin = new System.Windows.Forms.Padding(0);
			this.Lbl3.Name = "Lbl3";
			this.Lbl3.Size = new System.Drawing.Size(33, 13);
			this.Lbl3.TabIndex = 5;
			this.Lbl3.Text = "検索";
			this.Lbl3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
			this.CbType.Location = new System.Drawing.Point(195, 248);
			this.CbType.Margin = new System.Windows.Forms.Padding(0);
			this.CbType.Name = "CbType";
			this.CbType.Size = new System.Drawing.Size(70, 21);
			this.CbType.TabIndex = 4;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.DimGray;
			this.ClientSize = new System.Drawing.Size(464, 281);
			this.Controls.Add(this.CbType);
			this.Controls.Add(this.TbSearch);
			this.Controls.Add(this.Lbl3);
			this.Controls.Add(this.BtnExec);
			this.Controls.Add(this.Lbl1);
			this.Controls.Add(this.CbDepth);
			this.Controls.Add(this.Lbl2);
			this.Controls.Add(this.TbResult);
			this.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.MinimumSize = new System.Drawing.Size(480, 320);
			this.Name = "Form1";
			this.ShowIcon = false;
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
		private System.Windows.Forms.Label Lbl2;
		private System.Windows.Forms.ContextMenuStrip CmsResult;
		private System.Windows.Forms.ToolStripMenuItem CmsResult_全選択コピー;
		private System.Windows.Forms.ToolStripMenuItem CmsResult_コピー;
		private System.Windows.Forms.Label Lbl1;
		private System.Windows.Forms.Button BtnExec;
		private System.Windows.Forms.ToolStripMenuItem CmsResult_クリア;
		private System.Windows.Forms.ToolStripSeparator CmsResult_L1;
		private System.Windows.Forms.ToolStripMenuItem CmsResult_フォルダ選択;
		private System.Windows.Forms.TextBox TbSearch;
		private System.Windows.Forms.ContextMenuStrip CmsSearch;
		private System.Windows.Forms.ToolStripMenuItem CmsSearch_クリア;
		private System.Windows.Forms.ToolStripSeparator CmsSearch_L1;
		private System.Windows.Forms.ToolStripMenuItem CmsSearch_貼り付け;
		private System.Windows.Forms.Label Lbl3;
		private System.Windows.Forms.ComboBox CbType;
		private System.Windows.Forms.ContextMenuStrip CmsNull;
		private System.Windows.Forms.ContextMenuStrip CmsDepth;
		private System.Windows.Forms.ToolStripMenuItem CmsDepth_上へ;
		private System.Windows.Forms.ToolStripSeparator CmsDepth_L1;
		private System.Windows.Forms.ToolStripMenuItem CmsDepth_下へ;
		private System.Windows.Forms.ToolStripSeparator CmsResult_L2;
		private System.Windows.Forms.ToolStripMenuItem CmsResult_名前を付けて保存;
		private System.Windows.Forms.ToolStripMenuItem CmsResult_名前を付けて保存_ShiftJIS;
		private System.Windows.Forms.ToolStripMenuItem CmsResult_名前を付けて保存_UTF8N;
	}
}

