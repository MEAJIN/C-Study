using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 씨샾겅부
{
  

    // 클래스 내의 이벤트 정의
    class MyButton
    {
        public string Text;
        // 이벤트 정의
        public event EventHandler Click;

        public void MouseButtonDown()
        {
            if (this.Click != null)
            {
                // 이벤트핸들러들을 호출
                Click(this, EventArgs.Empty);
            }
        }
    }

    // 이벤트 사용
    public void Run()
    {
        MyButton btn = new MyButton();
        // Click 이벤트에 대한 이벤트핸들러로
        // btn_Click 이라는 메서드를 지정함
        btn.Click += new EventHandler(btn_Click);
        btn.Text = "Run";
        //....
    }

    void btn_Click(object sender, EventArgs e)
    {
        MessageBox.Show("Button 클릭");
    }


}
