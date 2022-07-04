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


        #endregion

        public Form1()
        {
            InitializeComponent();
            FileReader();
        }

        #region 시작 화면
        private void start_btn_Click(object sender, EventArgs e)
        {
            main_Panel.Hide();
        }

        private void start_btn_MouseMove(object sender, MouseEventArgs e)
        {
            start_btn.ForeColor = Color.Yellow;
        }

        private void start_btn_MouseLeave(object sender, EventArgs e)
        {
            start_btn.ForeColor = Color.White;
        }

        private void start_btn_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                start_btn_Click(sender, e);
            }
        }
        #endregion

        #region 파일 쓰기
        private void score_tbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Input();
                WrietValue();
            }
        }

        private void Input()
        {
            string Date = DateTime.Now.ToString("yyyy-MM-dd");
            string FileName = Date + ".csv";
            string FilePath = DirPath + FileName;

            string Name = name_tbox.Text;
            string School = school_tbox.Text;
            double Score = Convert.ToDouble(score_tbox.Text);

            FileStream stream = null;
            DirectoryInfo Dir = new DirectoryInfo(DirPath);
            FileInfo File = new FileInfo(FilePath);

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
            finally
            {
                if (stream != null) stream.Dispose();
            }
        }
        #endregion

        #region List 형태로 파일 읽기

        private void FileReader()
        {
            using (StreamReader file = new StreamReader(DirPath + "2022-07-04.csv"))
            {
                FileStream stream = null;
                decimal sum = 0;
                decimal avg = 0;
                decimal max = 0;
                decimal score = 0;
                string name = "";
                string school = "";
                decimal scoreCompare = 0;

                try
                {
                    List<String> _Name = new List<String>();
                    List<String> _School = new List<String>();
                    List<String> _Score = new List<String>();
                    List<int> _scoreMax = new List<int>();

                    DataTable table = new DataTable();

                    table.Columns.Add("이름");
                    table.Columns.Add("학교");
                    table.Columns.Add("점수");

                    table.Clear();

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
                    }                 

                    dataGridView1.DataSource = table;
                    file.Close();

                    // 점수 연산
                    max = Convert.ToDecimal(_scoreMax.Max());
                    for (int i = 0; i < table.Rows.Count; i++)
                    {
                        sum += Convert.ToDecimal(dataGridView1.Rows[i].Cells["점수"].Value);
                        avg = Math.Truncate(10*(sum / table.Rows.Count))/10; // .0f
                        score = Convert.ToDecimal(dataGridView1.Rows[i].Cells["점수"].Value);
                     
                        if (max == score)
                        {                       
                            name = Convert.ToString(dataGridView1.Rows[i].Cells["이름"].Value);
                            school = Convert.ToString(dataGridView1.Rows[i].Cells["학교"].Value);
                            scoreCompare = Convert.ToDecimal(dataGridView1.Rows[i].Cells["점수"].Value);
                        }
                    }
               
                    Calculate(avg, max, name, school, scoreCompare);                 
                }
                finally
                {
                    if (stream != null) stream.Dispose();
                }
            }
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

        #region 값구하기

        private void Calculate(Decimal avg, Decimal max, string name, string school, Decimal scoreCompare)
        {
            all_Avg_Value_tbox.Text = avg.ToString();
            best_Score_tBox.Text = $"{name},{school}, {scoreCompare}";

            // 득점자


        }

        #endregion

        #region 이벤트
        // 정보입력
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

        #endregion

    }
}
