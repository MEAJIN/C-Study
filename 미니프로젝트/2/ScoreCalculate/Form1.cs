using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;

namespace ScoreCalculate
{
    public partial class Form1 : Form
    {
        #region 공유변수
        string DirPath = $@"C:\Users\khj\Desktop\C#\세미나\6주차\Info\";

        #endregion

        public Form1()
        {
            InitializeComponent();
        }

        #region 메인
        private void start_btn_Click(object sender, EventArgs e)
        {
            main_view.Hide();
        }

        private void start_btn_MouseMove(object sender, MouseEventArgs e)
        {
            start_btn.BackColor = Color.White;
            start_btn.ForeColor = Color.Black;
        }

        private void start_btn_MouseLeave(object sender, EventArgs e)
        {
            start_btn.BackColor = Color.Black;
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

        #endregion

        #region List 형태로 파일 읽기

        #endregion

    }
}
