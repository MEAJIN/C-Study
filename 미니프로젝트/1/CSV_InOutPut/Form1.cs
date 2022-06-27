using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace CSV_InOutPut
{
    public partial class 기메진 : Form
    {
        string DirPath = $@"C:\Users\khj\Desktop\C#\세미나\4주차\csvFile\";
        public 기메진()
        {
            InitializeComponent();
            List();
        }

        #region # 파일 쓰기
        private void button1_Click(object sender, EventArgs e)
        {
            string Date = DateTime.Now.ToString("yyyy-MM-dd");
            string FileName = Date + ".csv";
            string FilePath = DirPath + FileName;
            string Name = txt_Name.Text;
            string Phone = txt_Phone.Text.ToString();
            string Score = txt_Score.Text;

            FileStream stream = null;
            DirectoryInfo Dir = new DirectoryInfo(DirPath);
            FileInfo File = new FileInfo(FilePath);

            try
            {
                if (!Dir.Exists)
                {
                    Directory.CreateDirectory(DirPath);
                }

                if (!File.Exists)
                {
                    using (StreamWriter writer = new StreamWriter(FilePath, true, Encoding.GetEncoding("utf-8")))
                    {
                        writer.WriteLine("{0}, {1}, {2}", Name, Score, Phone);
                        writer.Close();
                    }
                }
                else
                {
                    using (StreamWriter writer = new StreamWriter(FilePath, true, Encoding.GetEncoding("utf-8")))
                    {
                        writer.WriteLine("{0}, {1}, {2}", Name, Score, Phone);
                        writer.Close();
                    }
                }
            }
            finally
            {
                if (stream != null) stream.Dispose();
                txt_Name.Clear(); txt_Score.Clear(); txt_Phone.Clear();
            }
        }
        #endregion

        #region # CSV 저장 및 파일 리스트 초기화 -- 김찬영
        private void InfoSaveBtn_Click(object sender, EventArgs e)
        {
            ExportToCSV();
            CSV_FileList.Items.Clear();
            List();
        }

        private void ExportToCSV()
        {
            SaveFileDialog saveFileDialog = GetCSVSave();

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                SaveCSV(saveFileDialog.FileName, dataGridView1, true);
                this.CSV_FileList.Refresh(); // Refresh : 실시간 GUI 갱신
            }
        }

        private SaveFileDialog GetCSVSave()
        {
            SaveFileDialog SaveFileDialog = new SaveFileDialog();

            SaveFileDialog.InitialDirectory = DirPath;
            SaveFileDialog.DefaultExt = ".csv";
            SaveFileDialog.Filter = "csv (*.csv) | *.csv";
            SaveFileDialog.FileName = "".ToString();

            return SaveFileDialog;
        }

        private void SaveCSV(string fileName, DataGridView dataGridView1, bool header)
        {
            string delimeter = ",";
            FileStream fileStream = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            StreamWriter CsvExport = new StreamWriter(fileStream, System.Text.Encoding.UTF8);

            if (dataGridView1.Rows.Count == 0) return;

            if (header)
            {
                for (int i = 0; i < dataGridView1.Columns.Count; i++)
                {
                    CsvExport.Write(dataGridView1.Columns[i].HeaderText);
                    if (i != dataGridView1.Columns.Count - 1)
                    {
                        CsvExport.Write(delimeter);
                    }
                }
            }

            CsvExport.Write(CsvExport.NewLine);

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (!row.IsNewRow)
                {
                    for (int i = 0; i < dataGridView1.Columns.Count; i++)
                    {
                        CsvExport.Write(row.Cells[i].Value);
                        if (i != dataGridView1.Columns.Count - 1)
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

        #region # 파일 리스트 출력
        FolderBrowserDialog _Ldialog = new FolderBrowserDialog();
        public void List()
        {
            DirectoryInfo _dInfo = new DirectoryInfo(DirPath);
            FileInfo[] _fFiles = _dInfo.GetFiles("*.csv");

            foreach (FileInfo file in _fFiles)
            {
                CSV_FileList.Items.Add(file.Name);
            }
            #region 폴더 지정 (파일 찾기) (사용X)
            //if (_Ldialog.ShowDialog() == DialogResult.OK)
            //{
            //    string _LDirPath = _Ldialog.SelectedPath;
            //    this.CSV_FileList.Refresh();

            //    DirectoryInfo Dir = new DirectoryInfo(_LDirPath);

            //    if (Dir.Exists == true)
            //    {
            //        DataTable dataTable = new DataTable();
            //        dataTable.Columns.Add("FileName", typeof(string));

            //        DataRow dataRow = null;

            //        foreach (FileInfo file in Dir.GetFiles())
            //        {
            //            dataRow = dataTable.NewRow();
            //            dataRow["FileName"] = file.Name.Substring(0, file.Name.Length);
            //            dataTable.Rows.Add(dataRow);
            //        }

            //        CSV_FileList.DataSource = dataTable;
            //        CSV_FileList.DisplayMember = "FileName";
            //        ChoiceDirPath.Text = _LDirPath;
            //    }
            //}
            #endregion
        }
        #endregion

        #region # 클릭한 파일 경로 생성
        private void CSV_FileList_MouseClick(object sender, MouseEventArgs e)
        {
            string selectedFileName = CSV_FileList.GetItemText(CSV_FileList.SelectedItem);
            string setFilePath = DirPath + selectedFileName;
            showDataGridView(setFilePath);
        }
        #endregion

        #region # 파일 내용 보기
        private void showDataGridView(string getFilePath)
        {
            List<String> _tName = new List<String>();
            List<String> _tScore = new List<String>();
            List<String> _tPhone = new List<String>();

            StreamReader file = new StreamReader(getFilePath);
            DataTable table = new DataTable();

            table.Columns.Add("이름");
            table.Columns.Add("점수");
            table.Columns.Add("연락처");

            table.Clear();

            while (!file.EndOfStream)
            {
                string line = file.ReadLine();
                string[] data = line.Split(',');

                if (line.Contains("이름"))
                {
                    continue;
                }

                _tName.Add(data[0]);
                _tScore.Add(data[1]);
                _tPhone.Add(data[2]);

                table.Rows.Add(data[0], data[1], data[2]);
            }

            dataGridView1.DataSource = table;
            file.Close();
        }
        #endregion

        #region # 새로 만들기 버튼
        private void NewInsertBtn_Click(object sender, EventArgs e)
        {
            DataTable table = new DataTable();

            table.Columns.Add("이름");
            table.Columns.Add("점수");
            table.Columns.Add("연락처");

            table.Rows.Add(txt_Name.Text, txt_Score.Text, txt_Phone.Text);

            dataGridView1.DataSource = table;
        }
        #endregion

        #region # 파일 삭제 버튼
        private void FileDeleteBtn_Click(object sender, EventArgs e)
        {
            string selectedFileName = CSV_FileList.GetItemText(CSV_FileList.SelectedItem);
            string setFilePath = DirPath + selectedFileName;

            File.Delete(setFilePath);

            dataGridView1.DataSource = null;
            CSV_FileList.Items.Clear();
            List();

            MessageBox.Show("파일이 삭제되었습니다.");
        }
        #endregion
    }
}