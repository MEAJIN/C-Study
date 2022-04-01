using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 씨샾겅부
{
    internal class 클래스
    {
        // 하기싫다 시발

        // 필드 : 클래스의 내부 데이터가 저장 됨
        private string name;
        private int age;

        // 이벤트 : 객체 내부의 특정 상태를 외부로 전달
        public event EventHandler NameChanged;

        // 생성자
        public 클래스()
        {
            name = string.Empty;
            age = -1;
        }

        // 속성 : 클래스 데이터를 외/내부에서 사용할 수 있게 함
        public string Name
        {
            get { return this.name; }
            set
            {
                this.name = value;
                if (NameChanged != null)
                {
                    NameChanged(this, EventArgs.Empty);
                }
            }
        }
    

    public int Age
    {
        get { return this.age; }
        set { this.age = value; }
    }

    // 메서드
    public string GetCustomerData()
    {
        string data = string.Format("Name: {0} (Age: {1})",
                    this.Name, this.Age);
        return data;
    }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 씨샾겅부
{
    public class MyCustomer
    {
        // 필드
        private string name;
        private int age;

        // 이벤트 
        public event EventHandler NameChanged;

        // 생성자 (Constructor)
        public MyCustomer()
        {
            name = string.Empty;
            age = -1;
        }

        // 속성
        public string Name
        {
            get { return this.name; }
            set
            {
                if (this.name != value)
                {
                    this.name = value;
                    if (NameChanged != null)
                    {
                        NameChanged(this, EventArgs.Empty);
                    }
                }
            }
        }
        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }

        // 메서드
        public string GetCustomerData()
        {
            string data = string.Format("Name: {0} (Age: {1})",
                        this.Name, this.Age);
            return data;
        }
    }
}
