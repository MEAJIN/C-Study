
namespace CSV_InOutPut
{
    partial class 기메진
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(기메진));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_Score = new System.Windows.Forms.TextBox();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.txt_Phone = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.InfoSaveBtn = new System.Windows.Forms.Button();
            this.NewInsertBtn = new System.Windows.Forms.Button();
            this.InfoInputBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.FileFindBtn = new System.Windows.Forms.Button();
            this.ChoiceDirPath = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.CSV_FileList = new System.Windows.Forms.ListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.FileDeleteBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_Score);
            this.groupBox1.Controls.Add(this.txt_Name);
            this.groupBox1.Controls.Add(this.txt_Phone);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(17, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(434, 51);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "정보 입력";
            // 
            // txt_Score
            // 
            this.txt_Score.Location = new System.Drawing.Point(355, 19);
            this.txt_Score.Name = "txt_Score";
            this.txt_Score.Size = new System.Drawing.Size(61, 21);
            this.txt_Score.TabIndex = 3;
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(57, 19);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(70, 21);
            this.txt_Name.TabIndex = 1;
            // 
            // txt_Phone
            // 
            this.txt_Phone.Location = new System.Drawing.Point(188, 19);
            this.txt_Phone.Mask = "000-9000-0000";
            this.txt_Phone.Name = "txt_Phone";
            this.txt_Phone.Size = new System.Drawing.Size(116, 21);
            this.txt_Phone.TabIndex = 2;
            this.txt_Phone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(135, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "연락처 :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(312, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "점수 :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "이름 :";
            // 
            // InfoSaveBtn
            // 
            this.InfoSaveBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.InfoSaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InfoSaveBtn.Font = new System.Drawing.Font("돋움", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.InfoSaveBtn.ForeColor = System.Drawing.Color.White;
            this.InfoSaveBtn.Location = new System.Drawing.Point(800, 20);
            this.InfoSaveBtn.Name = "InfoSaveBtn";
            this.InfoSaveBtn.Size = new System.Drawing.Size(95, 44);
            this.InfoSaveBtn.TabIndex = 225;
            this.InfoSaveBtn.Text = "저장";
            this.InfoSaveBtn.UseVisualStyleBackColor = false;
            this.InfoSaveBtn.Click += new System.EventHandler(this.InfoSaveBtn_Click);
            // 
            // NewInsertBtn
            // 
            this.NewInsertBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.NewInsertBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewInsertBtn.Font = new System.Drawing.Font("돋움", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.NewInsertBtn.ForeColor = System.Drawing.Color.White;
            this.NewInsertBtn.Location = new System.Drawing.Point(583, 20);
            this.NewInsertBtn.Name = "NewInsertBtn";
            this.NewInsertBtn.Size = new System.Drawing.Size(95, 44);
            this.NewInsertBtn.TabIndex = 224;
            this.NewInsertBtn.Text = "새로 만들기";
            this.NewInsertBtn.UseVisualStyleBackColor = false;
            this.NewInsertBtn.Click += new System.EventHandler(this.NewInsertBtn_Click);
            // 
            // InfoInputBtn
            // 
            this.InfoInputBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.InfoInputBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InfoInputBtn.Font = new System.Drawing.Font("돋움", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.InfoInputBtn.ForeColor = System.Drawing.Color.White;
            this.InfoInputBtn.Location = new System.Drawing.Point(475, 20);
            this.InfoInputBtn.Name = "InfoInputBtn";
            this.InfoInputBtn.Size = new System.Drawing.Size(95, 44);
            this.InfoInputBtn.TabIndex = 222;
            this.InfoInputBtn.Text = "입력";
            this.InfoInputBtn.UseVisualStyleBackColor = false;
            this.InfoInputBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(289, 79);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(607, 451);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "파일 내용";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(6, 26);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(593, 412);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.TabStop = false;
            // 
            // FileFindBtn
            // 
            this.FileFindBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.FileFindBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FileFindBtn.Location = new System.Drawing.Point(781, 25);
            this.FileFindBtn.Name = "FileFindBtn";
            this.FileFindBtn.Size = new System.Drawing.Size(90, 25);
            this.FileFindBtn.TabIndex = 5;
            this.FileFindBtn.Text = "찾기";
            this.FileFindBtn.UseVisualStyleBackColor = false;
            // 
            // ChoiceDirPath
            // 
            this.ChoiceDirPath.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ChoiceDirPath.Location = new System.Drawing.Point(7, 25);
            this.ChoiceDirPath.Multiline = true;
            this.ChoiceDirPath.Name = "ChoiceDirPath";
            this.ChoiceDirPath.ReadOnly = true;
            this.ChoiceDirPath.Size = new System.Drawing.Size(768, 25);
            this.ChoiceDirPath.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.CSV_FileList);
            this.groupBox3.Location = new System.Drawing.Point(17, 79);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(266, 451);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "파일 목록";
            // 
            // CSV_FileList
            // 
            this.CSV_FileList.BackColor = System.Drawing.SystemColors.Window;
            this.CSV_FileList.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(140)));
            this.CSV_FileList.FormattingEnabled = true;
            this.CSV_FileList.ItemHeight = 12;
            this.CSV_FileList.Location = new System.Drawing.Point(7, 26);
            this.CSV_FileList.Name = "CSV_FileList";
            this.CSV_FileList.Size = new System.Drawing.Size(250, 412);
            this.CSV_FileList.Sorted = true;
            this.CSV_FileList.TabIndex = 0;
            this.CSV_FileList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CSV_FileList_MouseClick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.ChoiceDirPath);
            this.groupBox4.Controls.Add(this.FileFindBtn);
            this.groupBox4.Location = new System.Drawing.Point(9, 558);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(879, 63);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "폴더 찾기";
            this.groupBox4.Visible = false;
            // 
            // FileDeleteBtn
            // 
            this.FileDeleteBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.FileDeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FileDeleteBtn.Font = new System.Drawing.Font("돋움", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FileDeleteBtn.ForeColor = System.Drawing.Color.White;
            this.FileDeleteBtn.Location = new System.Drawing.Point(692, 20);
            this.FileDeleteBtn.Name = "FileDeleteBtn";
            this.FileDeleteBtn.Size = new System.Drawing.Size(95, 44);
            this.FileDeleteBtn.TabIndex = 226;
            this.FileDeleteBtn.Text = "파일 삭제";
            this.FileDeleteBtn.UseVisualStyleBackColor = false;
            this.FileDeleteBtn.Click += new System.EventHandler(this.FileDeleteBtn_Click);
            // 
            // 기메진
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(911, 539);
            this.Controls.Add(this.FileDeleteBtn);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.InfoSaveBtn);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.InfoInputBtn);
            this.Controls.Add(this.NewInsertBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "기메진";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "기메진";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txt_Phone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button InfoInputBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button FileFindBtn;
        private System.Windows.Forms.TextBox ChoiceDirPath;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.TextBox txt_Score;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox CSV_FileList;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button NewInsertBtn;
        private System.Windows.Forms.Button InfoSaveBtn;
        private System.Windows.Forms.Button FileDeleteBtn;
    }
}

