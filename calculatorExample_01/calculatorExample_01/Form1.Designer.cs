namespace calculatorExample_01
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnAc = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnDivision = new System.Windows.Forms.Button();
            this.btnNum7 = new System.Windows.Forms.Button();
            this.btnNum8 = new System.Windows.Forms.Button();
            this.btnNum9 = new System.Windows.Forms.Button();
            this.btnMultiple = new System.Windows.Forms.Button();
            this.btnNum4 = new System.Windows.Forms.Button();
            this.btnNum5 = new System.Windows.Forms.Button();
            this.btnNum6 = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnNum1 = new System.Windows.Forms.Button();
            this.btnNum2 = new System.Windows.Forms.Button();
            this.btnNum3 = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnNum0 = new System.Windows.Forms.Button();
            this.btnDot = new System.Windows.Forms.Button();
            this.btnEqual = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(408, 551);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.txtResult, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnAc, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnClear, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnDel, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnDivision, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnNum7, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnNum8, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnNum9, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnMultiple, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnNum4, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.btnNum5, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.btnNum6, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.btnMinus, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.btnNum1, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.btnNum2, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.btnNum3, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.btnPlus, 3, 6);
            this.tableLayoutPanel1.Controls.Add(this.btnNum0, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.btnDot, 2, 7);
            this.tableLayoutPanel1.Controls.Add(this.btnEqual, 3, 7);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(408, 551);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // txtResult
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txtResult, 4);
            this.txtResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtResult.Location = new System.Drawing.Point(3, 3);
            this.txtResult.Name = "txtResult";
            this.tableLayoutPanel1.SetRowSpan(this.txtResult, 3);
            this.txtResult.Size = new System.Drawing.Size(402, 21);
            this.txtResult.TabIndex = 0;
            // 
            // btnAc
            // 
            this.btnAc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAc.Location = new System.Drawing.Point(3, 207);
            this.btnAc.Name = "btnAc";
            this.btnAc.Size = new System.Drawing.Size(96, 62);
            this.btnAc.TabIndex = 1;
            this.btnAc.Text = "CE";
            this.btnAc.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClear.Location = new System.Drawing.Point(105, 207);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(96, 62);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnDel
            // 
            this.btnDel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDel.Location = new System.Drawing.Point(207, 207);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(96, 62);
            this.btnDel.TabIndex = 3;
            this.btnDel.Text = "⌫";
            this.btnDel.UseVisualStyleBackColor = true;
            // 
            // btnDivision
            // 
            this.btnDivision.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDivision.Location = new System.Drawing.Point(309, 207);
            this.btnDivision.Name = "btnDivision";
            this.btnDivision.Size = new System.Drawing.Size(96, 62);
            this.btnDivision.TabIndex = 4;
            this.btnDivision.Text = "/";
            this.btnDivision.UseVisualStyleBackColor = true;
            // 
            // btnNum7
            // 
            this.btnNum7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNum7.Location = new System.Drawing.Point(3, 275);
            this.btnNum7.Name = "btnNum7";
            this.btnNum7.Size = new System.Drawing.Size(96, 62);
            this.btnNum7.TabIndex = 5;
            this.btnNum7.Text = "7";
            this.btnNum7.UseVisualStyleBackColor = true;
            this.btnNum7.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // btnNum8
            // 
            this.btnNum8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNum8.Location = new System.Drawing.Point(105, 275);
            this.btnNum8.Name = "btnNum8";
            this.btnNum8.Size = new System.Drawing.Size(96, 62);
            this.btnNum8.TabIndex = 6;
            this.btnNum8.Text = "8";
            this.btnNum8.UseVisualStyleBackColor = true;
            this.btnNum8.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // btnNum9
            // 
            this.btnNum9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNum9.Location = new System.Drawing.Point(207, 275);
            this.btnNum9.Name = "btnNum9";
            this.btnNum9.Size = new System.Drawing.Size(96, 62);
            this.btnNum9.TabIndex = 7;
            this.btnNum9.Text = "9";
            this.btnNum9.UseVisualStyleBackColor = true;
            this.btnNum9.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // btnMultiple
            // 
            this.btnMultiple.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMultiple.Location = new System.Drawing.Point(309, 275);
            this.btnMultiple.Name = "btnMultiple";
            this.btnMultiple.Size = new System.Drawing.Size(96, 62);
            this.btnMultiple.TabIndex = 8;
            this.btnMultiple.Text = "X";
            this.btnMultiple.UseVisualStyleBackColor = true;
            // 
            // btnNum4
            // 
            this.btnNum4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNum4.Location = new System.Drawing.Point(3, 343);
            this.btnNum4.Name = "btnNum4";
            this.btnNum4.Size = new System.Drawing.Size(96, 62);
            this.btnNum4.TabIndex = 9;
            this.btnNum4.Text = "4";
            this.btnNum4.UseVisualStyleBackColor = true;
            this.btnNum4.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // btnNum5
            // 
            this.btnNum5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNum5.Location = new System.Drawing.Point(105, 343);
            this.btnNum5.Name = "btnNum5";
            this.btnNum5.Size = new System.Drawing.Size(96, 62);
            this.btnNum5.TabIndex = 10;
            this.btnNum5.Text = "5";
            this.btnNum5.UseVisualStyleBackColor = true;
            this.btnNum5.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // btnNum6
            // 
            this.btnNum6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNum6.Location = new System.Drawing.Point(207, 343);
            this.btnNum6.Name = "btnNum6";
            this.btnNum6.Size = new System.Drawing.Size(96, 62);
            this.btnNum6.TabIndex = 11;
            this.btnNum6.Text = "6";
            this.btnNum6.UseVisualStyleBackColor = true;
            this.btnNum6.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMinus.Location = new System.Drawing.Point(309, 343);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(96, 62);
            this.btnMinus.TabIndex = 12;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            // 
            // btnNum1
            // 
            this.btnNum1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNum1.Location = new System.Drawing.Point(3, 411);
            this.btnNum1.Name = "btnNum1";
            this.btnNum1.Size = new System.Drawing.Size(96, 62);
            this.btnNum1.TabIndex = 13;
            this.btnNum1.Text = "1";
            this.btnNum1.UseVisualStyleBackColor = true;
            this.btnNum1.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // btnNum2
            // 
            this.btnNum2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNum2.Location = new System.Drawing.Point(105, 411);
            this.btnNum2.Name = "btnNum2";
            this.btnNum2.Size = new System.Drawing.Size(96, 62);
            this.btnNum2.TabIndex = 14;
            this.btnNum2.Text = "2";
            this.btnNum2.UseVisualStyleBackColor = true;
            this.btnNum2.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // btnNum3
            // 
            this.btnNum3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNum3.Location = new System.Drawing.Point(207, 411);
            this.btnNum3.Name = "btnNum3";
            this.btnNum3.Size = new System.Drawing.Size(96, 62);
            this.btnNum3.TabIndex = 15;
            this.btnNum3.Text = "3";
            this.btnNum3.UseVisualStyleBackColor = true;
            this.btnNum3.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPlus.Location = new System.Drawing.Point(309, 411);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(96, 62);
            this.btnPlus.TabIndex = 16;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            // 
            // btnNum0
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.btnNum0, 2);
            this.btnNum0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNum0.Location = new System.Drawing.Point(3, 479);
            this.btnNum0.Name = "btnNum0";
            this.btnNum0.Size = new System.Drawing.Size(198, 69);
            this.btnNum0.TabIndex = 17;
            this.btnNum0.Text = "0";
            this.btnNum0.UseVisualStyleBackColor = true;
            this.btnNum0.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // btnDot
            // 
            this.btnDot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDot.Location = new System.Drawing.Point(207, 479);
            this.btnDot.Name = "btnDot";
            this.btnDot.Size = new System.Drawing.Size(96, 69);
            this.btnDot.TabIndex = 19;
            this.btnDot.Text = ".";
            this.btnDot.UseVisualStyleBackColor = true;
            // 
            // btnEqual
            // 
            this.btnEqual.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEqual.Location = new System.Drawing.Point(309, 479);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(96, 69);
            this.btnEqual.TabIndex = 20;
            this.btnEqual.Text = "=";
            this.btnEqual.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 551);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnAc;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnDivision;
        private System.Windows.Forms.Button btnNum7;
        private System.Windows.Forms.Button btnNum8;
        private System.Windows.Forms.Button btnNum9;
        private System.Windows.Forms.Button btnMultiple;
        private System.Windows.Forms.Button btnNum4;
        private System.Windows.Forms.Button btnNum5;
        private System.Windows.Forms.Button btnNum6;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnNum1;
        private System.Windows.Forms.Button btnNum2;
        private System.Windows.Forms.Button btnNum3;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnNum0;
        private System.Windows.Forms.Button btnDot;
        private System.Windows.Forms.Button btnEqual;
    }
}

