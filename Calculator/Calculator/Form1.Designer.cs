namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Button Button4;
            this.ResultDisplay = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Button0 = new System.Windows.Forms.Button();
            this.ButtonClear = new System.Windows.Forms.Button();
            this.Button_plus = new System.Windows.Forms.Button();
            this.ButtonPoint = new System.Windows.Forms.Button();
            this.Button7 = new System.Windows.Forms.Button();
            this.Button8 = new System.Windows.Forms.Button();
            this.Button9 = new System.Windows.Forms.Button();
            this.Button_divde = new System.Windows.Forms.Button();
            this.Button5 = new System.Windows.Forms.Button();
            this.Button6 = new System.Windows.Forms.Button();
            this.Button_multiply = new System.Windows.Forms.Button();
            this.Button1 = new System.Windows.Forms.Button();
            this.Button2 = new System.Windows.Forms.Button();
            this.Button3 = new System.Windows.Forms.Button();
            this.Button_minus = new System.Windows.Forms.Button();
            this.ButtonResult = new System.Windows.Forms.Button();
            Button4 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Button4
            // 
            Button4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            Button4.BackColor = System.Drawing.Color.White;
            Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            Button4.Cursor = System.Windows.Forms.Cursors.IBeam;
            Button4.Font = new System.Drawing.Font("한컴산뜻돋움", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            Button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            Button4.Location = new System.Drawing.Point(1, 56);
            Button4.Margin = new System.Windows.Forms.Padding(1);
            Button4.Name = "Button4";
            Button4.Size = new System.Drawing.Size(67, 53);
            Button4.TabIndex = 7;
            Button4.Text = "4";
            Button4.UseVisualStyleBackColor = false;
            Button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // ResultDisplay
            // 
            this.ResultDisplay.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ResultDisplay.BackColor = System.Drawing.Color.Ivory;
            this.ResultDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ResultDisplay.Font = new System.Drawing.Font("함초롬돋움 확장", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ResultDisplay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ResultDisplay.Location = new System.Drawing.Point(8, 26);
            this.ResultDisplay.Name = "ResultDisplay";
            this.ResultDisplay.Size = new System.Drawing.Size(275, 60);
            this.ResultDisplay.TabIndex = 0;
            this.ResultDisplay.Text = "0";
            this.ResultDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.Button0, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.ButtonClear, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.Button_plus, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.ButtonPoint, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.Button7, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Button8, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.Button9, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.Button_divde, 3, 0);
            this.tableLayoutPanel1.Controls.Add(Button4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.Button5, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.Button6, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.Button_multiply, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.Button1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.Button2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.Button3, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.Button_minus, 3, 2);
            this.tableLayoutPanel1.Font = new System.Drawing.Font("함초롬돋움", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(8, 89);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(276, 223);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // Button0
            // 
            this.Button0.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Button0.BackColor = System.Drawing.Color.White;
            this.Button0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Button0.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Button0.Font = new System.Drawing.Font("한컴산뜻돋움", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Button0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Button0.Location = new System.Drawing.Point(70, 166);
            this.Button0.Margin = new System.Windows.Forms.Padding(1);
            this.Button0.Name = "Button0";
            this.Button0.Size = new System.Drawing.Size(67, 56);
            this.Button0.TabIndex = 17;
            this.Button0.Text = "0";
            this.Button0.UseVisualStyleBackColor = false;
            this.Button0.Click += new System.EventHandler(this.Button0_Click);
            // 
            // ButtonClear
            // 
            this.ButtonClear.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonClear.BackColor = System.Drawing.Color.LemonChiffon;
            this.ButtonClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ButtonClear.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ButtonClear.Font = new System.Drawing.Font("한컴산뜻돋움", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ButtonClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ButtonClear.Location = new System.Drawing.Point(1, 166);
            this.ButtonClear.Margin = new System.Windows.Forms.Padding(1);
            this.ButtonClear.Name = "ButtonClear";
            this.ButtonClear.Size = new System.Drawing.Size(67, 56);
            this.ButtonClear.TabIndex = 16;
            this.ButtonClear.Text = "AC";
            this.ButtonClear.UseVisualStyleBackColor = false;
            this.ButtonClear.Click += new System.EventHandler(this.ButtonClear_Click);
            // 
            // Button_plus
            // 
            this.Button_plus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_plus.BackColor = System.Drawing.Color.Moccasin;
            this.Button_plus.Font = new System.Drawing.Font("한컴산뜻돋움", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Button_plus.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Button_plus.Location = new System.Drawing.Point(208, 166);
            this.Button_plus.Margin = new System.Windows.Forms.Padding(1);
            this.Button_plus.Name = "Button_plus";
            this.Button_plus.Size = new System.Drawing.Size(67, 56);
            this.Button_plus.TabIndex = 18;
            this.Button_plus.Text = "+";
            this.Button_plus.UseVisualStyleBackColor = false;
            this.Button_plus.Click += new System.EventHandler(this.Button_plus_Click);
            // 
            // ButtonPoint
            // 
            this.ButtonPoint.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonPoint.BackColor = System.Drawing.Color.LemonChiffon;
            this.ButtonPoint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ButtonPoint.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ButtonPoint.Font = new System.Drawing.Font("한컴산뜻돋움", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ButtonPoint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ButtonPoint.Location = new System.Drawing.Point(139, 166);
            this.ButtonPoint.Margin = new System.Windows.Forms.Padding(1);
            this.ButtonPoint.Name = "ButtonPoint";
            this.ButtonPoint.Size = new System.Drawing.Size(67, 56);
            this.ButtonPoint.TabIndex = 15;
            this.ButtonPoint.Text = ".";
            this.ButtonPoint.UseVisualStyleBackColor = false;
            this.ButtonPoint.Click += new System.EventHandler(this.ButtonPoint_Click);
            // 
            // Button7
            // 
            this.Button7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Button7.BackColor = System.Drawing.Color.White;
            this.Button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Button7.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Button7.Font = new System.Drawing.Font("한컴산뜻돋움", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Button7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Button7.Location = new System.Drawing.Point(1, 1);
            this.Button7.Margin = new System.Windows.Forms.Padding(1);
            this.Button7.Name = "Button7";
            this.Button7.Size = new System.Drawing.Size(67, 53);
            this.Button7.TabIndex = 0;
            this.Button7.Text = "7";
            this.Button7.UseVisualStyleBackColor = false;
            this.Button7.Click += new System.EventHandler(this.Button7_Click);
            // 
            // Button8
            // 
            this.Button8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Button8.BackColor = System.Drawing.Color.White;
            this.Button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Button8.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Button8.Font = new System.Drawing.Font("한컴산뜻돋움", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Button8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Button8.Location = new System.Drawing.Point(70, 1);
            this.Button8.Margin = new System.Windows.Forms.Padding(1);
            this.Button8.Name = "Button8";
            this.Button8.Size = new System.Drawing.Size(67, 53);
            this.Button8.TabIndex = 1;
            this.Button8.Text = "8";
            this.Button8.UseVisualStyleBackColor = false;
            this.Button8.Click += new System.EventHandler(this.Button8_Click);
            // 
            // Button9
            // 
            this.Button9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Button9.BackColor = System.Drawing.Color.White;
            this.Button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Button9.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Button9.Font = new System.Drawing.Font("한컴산뜻돋움", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Button9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Button9.Location = new System.Drawing.Point(139, 1);
            this.Button9.Margin = new System.Windows.Forms.Padding(1);
            this.Button9.Name = "Button9";
            this.Button9.Size = new System.Drawing.Size(67, 53);
            this.Button9.TabIndex = 2;
            this.Button9.Text = "9";
            this.Button9.UseVisualStyleBackColor = false;
            this.Button9.Click += new System.EventHandler(this.Button9_Click);
            // 
            // Button_divde
            // 
            this.Button_divde.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_divde.BackColor = System.Drawing.Color.Moccasin;
            this.Button_divde.Font = new System.Drawing.Font("한컴산뜻돋움", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Button_divde.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Button_divde.Location = new System.Drawing.Point(208, 1);
            this.Button_divde.Margin = new System.Windows.Forms.Padding(1);
            this.Button_divde.Name = "Button_divde";
            this.Button_divde.Size = new System.Drawing.Size(67, 53);
            this.Button_divde.TabIndex = 6;
            this.Button_divde.Text = "÷";
            this.Button_divde.UseVisualStyleBackColor = false;
            this.Button_divde.Click += new System.EventHandler(this.Button_divde_Click);
            // 
            // Button5
            // 
            this.Button5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Button5.BackColor = System.Drawing.Color.White;
            this.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Button5.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Button5.Font = new System.Drawing.Font("한컴산뜻돋움", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Button5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Button5.Location = new System.Drawing.Point(70, 56);
            this.Button5.Margin = new System.Windows.Forms.Padding(1);
            this.Button5.Name = "Button5";
            this.Button5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Button5.Size = new System.Drawing.Size(67, 53);
            this.Button5.TabIndex = 9;
            this.Button5.Text = "5";
            this.Button5.UseVisualStyleBackColor = false;
            this.Button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // Button6
            // 
            this.Button6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Button6.BackColor = System.Drawing.Color.White;
            this.Button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Button6.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Button6.Font = new System.Drawing.Font("한컴산뜻돋움", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Button6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Button6.Location = new System.Drawing.Point(139, 56);
            this.Button6.Margin = new System.Windows.Forms.Padding(1);
            this.Button6.Name = "Button6";
            this.Button6.Size = new System.Drawing.Size(67, 53);
            this.Button6.TabIndex = 8;
            this.Button6.Text = "6";
            this.Button6.UseVisualStyleBackColor = false;
            this.Button6.Click += new System.EventHandler(this.Button6_Click);
            // 
            // Button_multiply
            // 
            this.Button_multiply.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_multiply.BackColor = System.Drawing.Color.Moccasin;
            this.Button_multiply.Font = new System.Drawing.Font("한컴산뜻돋움", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Button_multiply.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Button_multiply.Location = new System.Drawing.Point(208, 56);
            this.Button_multiply.Margin = new System.Windows.Forms.Padding(1);
            this.Button_multiply.Name = "Button_multiply";
            this.Button_multiply.Size = new System.Drawing.Size(67, 53);
            this.Button_multiply.TabIndex = 10;
            this.Button_multiply.Text = "×";
            this.Button_multiply.UseVisualStyleBackColor = false;
            this.Button_multiply.Click += new System.EventHandler(this.Button_multiply_Click);
            // 
            // Button1
            // 
            this.Button1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Button1.BackColor = System.Drawing.Color.White;
            this.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Button1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Button1.Font = new System.Drawing.Font("한컴산뜻돋움", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Button1.Location = new System.Drawing.Point(1, 111);
            this.Button1.Margin = new System.Windows.Forms.Padding(1);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(67, 53);
            this.Button1.TabIndex = 13;
            this.Button1.Text = "1";
            this.Button1.UseVisualStyleBackColor = false;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Button2
            // 
            this.Button2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Button2.BackColor = System.Drawing.Color.White;
            this.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Button2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Button2.Font = new System.Drawing.Font("한컴산뜻돋움", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Button2.Location = new System.Drawing.Point(70, 111);
            this.Button2.Margin = new System.Windows.Forms.Padding(1);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(67, 53);
            this.Button2.TabIndex = 12;
            this.Button2.Text = "2";
            this.Button2.UseVisualStyleBackColor = false;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Button3
            // 
            this.Button3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Button3.BackColor = System.Drawing.Color.White;
            this.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Button3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Button3.Font = new System.Drawing.Font("한컴산뜻돋움", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Button3.Location = new System.Drawing.Point(139, 111);
            this.Button3.Margin = new System.Windows.Forms.Padding(1);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(67, 53);
            this.Button3.TabIndex = 14;
            this.Button3.Text = "3";
            this.Button3.UseVisualStyleBackColor = false;
            this.Button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // Button_minus
            // 
            this.Button_minus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_minus.BackColor = System.Drawing.Color.Moccasin;
            this.Button_minus.Font = new System.Drawing.Font("한컴산뜻돋움", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Button_minus.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Button_minus.Location = new System.Drawing.Point(208, 111);
            this.Button_minus.Margin = new System.Windows.Forms.Padding(1);
            this.Button_minus.Name = "Button_minus";
            this.Button_minus.Size = new System.Drawing.Size(67, 53);
            this.Button_minus.TabIndex = 11;
            this.Button_minus.Text = "－";
            this.Button_minus.UseVisualStyleBackColor = false;
            this.Button_minus.Click += new System.EventHandler(this.Button_minus_Click);
            // 
            // ButtonResult
            // 
            this.ButtonResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonResult.BackColor = System.Drawing.Color.LemonChiffon;
            this.ButtonResult.Font = new System.Drawing.Font("한컴산뜻돋움", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ButtonResult.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ButtonResult.Location = new System.Drawing.Point(7, 316);
            this.ButtonResult.Margin = new System.Windows.Forms.Padding(1);
            this.ButtonResult.Name = "ButtonResult";
            this.ButtonResult.Size = new System.Drawing.Size(280, 42);
            this.ButtonResult.TabIndex = 2;
            this.ButtonResult.Text = "=";
            this.ButtonResult.UseVisualStyleBackColor = false;
            this.ButtonResult.Click += new System.EventHandler(this.ButtonResult_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(292, 367);
            this.Controls.Add(this.ButtonResult);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.ResultDisplay);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label ResultDisplay;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button Button7;
        private System.Windows.Forms.Button Button8;
        private System.Windows.Forms.Button Button9;
        private System.Windows.Forms.Button Button0;
        private System.Windows.Forms.Button ButtonClear;
        private System.Windows.Forms.Button Button_plus;
        private System.Windows.Forms.Button ButtonPoint;
        private System.Windows.Forms.Button Button_divde;
        private System.Windows.Forms.Button Button5;
        private System.Windows.Forms.Button Button6;
        private System.Windows.Forms.Button Button1;
        private System.Windows.Forms.Button Button2;
        private System.Windows.Forms.Button Button3;
        private System.Windows.Forms.Button Button_minus;
        private System.Windows.Forms.Button ButtonResult;
        private System.Windows.Forms.Button Button_multiply;
    }
}

