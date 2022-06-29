using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;
using System.Data;
using System.Text;

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
            string Score = score_tbox.Text.ToString();

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
            List<String> Name = new List<String>();
            List<String> School = new List<String>();
            List<String> Score = new List<String>();

            StreamReader file = new StreamReader(DirPath + "2022-06-28.csv");
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

                Name.Add(data[0]);
                School.Add(data[1]);
                Score.Add(data[2]);

                table.Rows.Add(data[0], data[1], data[2]);
            }

            dataGridView.DataSource = table;
            file.Close();
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
