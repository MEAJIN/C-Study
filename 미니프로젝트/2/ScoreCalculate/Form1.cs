using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ScoreCalculate
{
    public partial class Form1 : Form
    {
        #region 공유변수
        string DirPath = $@"C:\Users\khj\source\repos\C-Study\미니프로젝트\2\Info\";
        string Date = DateTime.Now.ToString("yyyy-MM-dd");

        #endregion

        public Form1()
        {
            InitializeComponent();
            List();
        }

        #region 파일 쓰기
        private void Input()
        {
            string FileName = Date + ".csv";
            string FilePath = DirPath + FileName;

            string Name = name_tbox.Text;
            string School = school_tbox.Text;
            string Score = score_tbox.Text.ToString();

            FileStream stream = null;
            DirectoryInfo Dir = new DirectoryInfo(DirPath);
            FileInfo file = new FileInfo(FilePath);

            try
            {
                if (!Dir.Exists)
                {
                    Directory.CreateDirectory(DirPath);
                }

                using (StreamWriter writer = new StreamWriter(FilePath, true, Encoding.GetEncoding("utf-8")))
                {
                    writer.WriteLine("{0}, {1}, {2}", Name, School, Score);
                    writer.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "오류", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            finally
            {
                if (stream != null) stream.Dispose();

            }

            FileReader();
        }
        #endregion

        #region 입력 값 textbox로 출력
        private void WrietValue()
        {
            writeValue_tbox.AppendText("'" + name_tbox.Text + "',");
            writeValue_tbox.AppendText("'" + school_tbox.Text + "',");
            writeValue_tbox.AppendText("'" + score_tbox.Text + "'\r\n");
            writeValue_tbox.AppendText("\r\n");

            name_tbox.Text = "";
            school_tbox.Text = "";
            score_tbox.Text = "";

            label2.Text = "<입력값>";
            name_tbox.Focus();
        }
        #endregion

        #region List 형태로 파일 읽기 및 연산

        private void FileReader()
        {
            decimal sum = 0;
            decimal avg = 0;
            decimal max = 0;
            decimal score = 0;
            string name = "";
            string school = "";
            decimal scoreCompare = 0;
            int scoreCutLine = 60;

            List<String> _Name = new List<String>();
            List<String> _School = new List<String>();
            List<String> _Score = new List<String>();
            List<int> _scoreMax = new List<int>();

            DataTable table = new DataTable();
            DataTable tableExam = new DataTable();
            DataTable tableExam2 = new DataTable();

            StreamReader file = new StreamReader(DirPath + Date + ".csv");

            table.Columns.Add("이름");
            table.Columns.Add("학교");
            table.Columns.Add("점수");

            tableExam.Columns.Add("이름");
            tableExam.Columns.Add("점수");

            tableExam2.Columns.Add("이름");
            tableExam2.Columns.Add("점수");

            table.Clear();
            tableExam.Clear();
            tableExam2.Clear();

            while (!file.EndOfStream)
            {
                string line = file.ReadLine();
                string[] Data = line.Split(',');

                if (line.Contains("이름"))
                {
                    continue;
                }

                _Name.Add(Data[0]);
                _School.Add(Data[1]);
                _Score.Add(Data[2]);
                _scoreMax.Add(Convert.ToInt32(Data[2]));

                table.Rows.Add(Data[0], Data[1], Data[2]);
                tableExam.Rows.Add(Data[0], Data[2]);
                tableExam2.Rows.Add(Data[0], Data[2]);
            }

            dataGridView1.DataSource = table;
            file.Close();

            // 점수 연산
            max = Convert.ToDecimal(_scoreMax.Max());
            for (int i = 0; i < table.Rows.Count; i++)
            {
                sum += Convert.ToDecimal(dataGridView1.Rows[i].Cells["점수"].Value);
                avg = Math.Truncate(10 * (sum / table.Rows.Count)) / 10; // .0f
                score = Convert.ToDecimal(dataGridView1.Rows[i].Cells["점수"].Value);

                if (max == score)
                {
                    name = Convert.ToString(dataGridView1.Rows[i].Cells["이름"].Value);
                    school = Convert.ToString(dataGridView1.Rows[i].Cells["학교"].Value);
                    scoreCompare = Convert.ToDecimal(dataGridView1.Rows[i].Cells["점수"].Value);
                }
            }

            // 전체 평균
            all_Avg_Value_tbox.Text = avg.ToString();

            // 득점자
            best_Score_tBox.Text = $"{name},{school}, {scoreCompare}";

            //합/불격자
            tableExam.DefaultView.RowFilter = $"점수 > {scoreCutLine}";
            tableExam2.DefaultView.RowFilter = $"점수 < {scoreCutLine}";
            dataGridView2.DataSource = tableExam;
            dataGridView3.DataSource = tableExam2;
        }
        #endregion

        #region # 파일 리스트 출력
        public void List()
        {
            DirectoryInfo _dInfo = new DirectoryInfo(DirPath);
            FileInfo[] _fFiles = _dInfo.GetFiles("*.csv");

            foreach (FileInfo file in _fFiles)
            {
                csv_fileList.Items.Add(file.Name);
            }
        }
        #endregion

        #region 클릭한 파일 경로 생성
        private void csv_fileList_MouseClick_1(object sender, MouseEventArgs e)
        {
            string selectedFileName = csv_fileList.GetItemText(csv_fileList.SelectedItem);
            string setFilePath = DirPath + selectedFileName;
            ShowDataGridView(setFilePath);
        }
        #endregion

        #region 파일 내용 보기
        private void ShowDataGridView(string getFilePath)
        {
            List<String> _Name = new List<String>();
            List<String> _School = new List<String>();
            List<String> _Score = new List<String>();

            StreamReader file = new StreamReader(getFilePath);
            DataTable table = new DataTable();

            table.Columns.Add("이름");
            table.Columns.Add("학교");
            table.Columns.Add("점수");

            table.Clear();

            while (!file.EndOfStream)
            {
                string line = file.ReadLine();
                string[] data = line.Split(',');

                if (line.Contains("이름"))
                {
                    continue;
                }

                _Name.Add(data[0]);
                _School.Add(data[1]);
                _Score.Add(data[2]);

                table.Rows.Add(data[0], data[1], data[2]);
            }

            showDataGridView.DataSource = table;
            file.Close();
        }

        #endregion

        #region 이벤트
        private void start_btn_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }

        private void start_btn_MouseDown(object sender, MouseEventArgs e)
        {
            start_btn.ForeColor = Color.Yellow;

        }

        private void score_tbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Input();
                WrietValue();
            }
        }

        private void name_tbox_MouseMove(object sender, MouseEventArgs e)
        {
            name_tbox.BackColor = Color.White;
            name_tbox.ForeColor = Color.Black;
        }

        private void name_tbox_MouseLeave(object sender, EventArgs e)
        {
            name_tbox.BackColor = Color.Black;
            name_tbox.ForeColor = Color.White;
        }

        private void school_tbox_MouseMove(object sender, MouseEventArgs e)
        {
            school_tbox.BackColor = Color.White;
            school_tbox.ForeColor = Color.Black;
        }

        private void school_tbox_MouseLeave(object sender, EventArgs e)
        {
            school_tbox.BackColor = Color.Black;
            school_tbox.ForeColor = Color.White;
        }

        private void score_tbox_MouseMove(object sender, MouseEventArgs e)
        {
            score_tbox.BackColor = Color.White;
            score_tbox.ForeColor = Color.Black;
        }

        private void score_tbox_MouseLeave(object sender, EventArgs e)
        {
            score_tbox.BackColor = Color.Black;
            score_tbox.ForeColor = Color.White;
        }
        //
        private void newCreate_btn_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                newCreate_btn.BackColor = Color.GhostWhite;
                newCreate_btn.ForeColor = Color.Black;
            }
            else
            {
                newCreate_btn_Leave(sender, e);
            }
        }

        private void newCreate_btn_Leave(object sender, EventArgs e)
        {
            newCreate_btn.BackColor = Color.Black;
            newCreate_btn.ForeColor = Color.GhostWhite;
        }

        private void fileDel_btn_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                fileDel_btn.BackColor = Color.GhostWhite;
                fileDel_btn.ForeColor = Color.Black;
            }
            else
            {
                fileDel_btn_Leave(sender, e);
            }
        }

        private void fileDel_btn_Leave(object sender, EventArgs e)
        {
            fileDel_btn.BackColor = Color.Black;
            fileDel_btn.ForeColor = Color.GhostWhite;
        }

        private void fileSave_btn_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                fileSave_btn.BackColor = Color.GhostWhite;
                fileSave_btn.ForeColor = Color.Black;
            }
            else
            {
                fileSave_btn_Leave(sender, e);
            }
        }

        private void fileSave_btn_Leave(object sender, EventArgs e)
        {
            fileSave_btn.BackColor = Color.Black;
            fileSave_btn.ForeColor = Color.GhostWhite;
        }
        #endregion

        #region 새로 만들기
        private void newCreate_btn_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                newCreate_btn_Click(sender, e);
            }
        }

        private void newCreate_btn_Click(object sender, EventArgs e)
        {
            DataTable table = new DataTable();

            table.Columns.Add("이름");
            table.Columns.Add("학교");
            table.Columns.Add("점수");

            table.Rows.Add(name_tbox.Text, school_tbox.Text, score_tbox.Text);

            showDataGridView.DataSource = table;
        }
        #endregion

        #region 파일 삭제
        private void fileDel_btn_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                fileDel_btn_Click(sender, e);
            }
        }

        private void fileDel_btn_Click(object sender, EventArgs e)
        {
            string selectedFileName = csv_fileList.GetItemText(csv_fileList.SelectedItem);
            string setFilePath = DirPath + selectedFileName;

            File.Delete(setFilePath);

            showDataGridView.DataSource = null;
            csv_fileList.Items.Clear();

            MessageBox.Show("파일이 삭제되었습니다.");

            List();
        }

        #endregion

        #region CSV 저장 및 파일 리스트 초기화 

        private void fileSave_btn_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                fileSave_btn_Click(sender, e);
            }
        }

        private void fileSave_btn_Click(object sender, EventArgs e)
        {
            ExportToCSV();
            csv_fileList.Items.Clear();
            List();
        }

        private void ExportToCSV()
        {
            SaveFileDialog saveFileDialog = GetCSVSave();

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                SaveCSV(saveFileDialog.FileName, showDataGridView, true);
                this.csv_fileList.Refresh(); // Refresh : 실시간 GUI 갱신
            }
        }

        private SaveFileDialog GetCSVSave()
        {
            SaveFileDialog SaveFileDialog = new SaveFileDialog
            {
                InitialDirectory = DirPath,
                DefaultExt = ".csv",
                Filter = "csv (*.csv) | *.csv",
                FileName = "".ToString()
            };

            return SaveFileDialog;
        }

        private void SaveCSV(string fileName, DataGridView showDataGridView, bool header)
        {
            string delimeter = ",";
            FileStream fileStream = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            StreamWriter CsvExport = new StreamWriter(fileStream, Encoding.UTF8);

            if (showDataGridView.Rows.Count == 0) return;

            // 헤더 정보 출력
            if (header) 
            {
                for (int i = 0; i < showDataGridView.Columns.Count; i++)
                {
                    CsvExport.Write(showDataGridView.Columns[i].HeaderText);
                    if (i != showDataGridView.Columns.Count - 1)
                    {
                        CsvExport.Write(delimeter);
                    }
                }
            }

            CsvExport.Write(CsvExport.NewLine);

            // 데이터 출력
            foreach (DataGridViewRow row in showDataGridView.Rows) 
            {
                if (!row.IsNewRow)
                {
                    for (int i = 0; i < showDataGridView.Columns.Count; i++)
                    {
                        CsvExport.Write(row.Cells[i].Value);
                        if (i != showDataGridView.Columns.Count - 1)
                        {
                            CsvExport.Write(delimeter);
                        }
                    }
                    CsvExport.Write(CsvExport.NewLine);
                }
            }

            CsvExport.Flush(); // Flush : 버퍼를 지우고 버퍼링된 모든 데이터가 파일에 쓰여지도록 함
            CsvExport.Close(); // Close : Flush 하고, 점유하고 있던 자원을 반환 함
            fileStream.Close();

            MessageBox.Show("파일이 저장되었습니다.");
        }


        #endregion

        
    }
}
