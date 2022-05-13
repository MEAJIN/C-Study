using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Class2
    {
        // 값 입력받고 연산처리해서 파일로 저장
        struct GRADE
        {
            public int kor, eng, math, total;
            public int average;
        }
        static void Main(string[] args)
        {

            string str;
            float average;
            Console.Write("성적 처리를 위한 학생 수를 입력해주세여: ");
            int nCount = int.Parse(Console.ReadLine());

            Console.WriteLine("국어 영어 수학 순서로 입력해 주세여: ");

            GRADE[] Grade = new GRADE[nCount];

            StreamWriter sw = new StreamWriter("test.txt");
            sw.WriteLine("학생수: {0}", nCount);

            for (int i = 0; i < nCount; i++)
            {
                str = Console.ReadLine();
                string[] DataString = str.Split(new char[] { ' ' });
                Grade[i].kor = int.Parse(DataString[0]);
                Grade[i].eng = int.Parse(DataString[1]);
                Grade[i].math = int.Parse(DataString[2]);
                Grade[i].total = Grade[i].kor + Grade[i].eng + Grade[i].math;
                average = Grade[i].total / 3.0f;
                Grade[i].average = (int)Math.Round(average);
            }

            for (int i = 0; i < nCount; i++)
            {
                sw.WriteLine("{0} {1} {2} {3} {4}",
                    Grade[i].kor, Grade[i].eng, Grade[i].math, Grade[i].total, Grade[i].average);
                
            }

            sw.Close();

            // 쓰기
            //int value = 12;
            //float value2 = 3.14f;
            //string str1 = "hello world!";

            //filestream fs = new filestream("test_file.txt", filemode.create);
            //streamwriter sw = new streamwriter(fs);

            //sw.write(value);
            //sw.write(value2);
            //sw.write(str1);
            //sw.close();


            // 읽기
            //string str = "국어: 90 영어: 100 수학: 70";
            //string[] str_Element = str.Split(new char[] { ' ' });
            //int kor = int.Parse(str_Element[1]);
            //int eng = int.Parse(str_Element[3]);
            //int math = int.Parse(str_Element[5]);
            //int total = kor + eng + math;
            //float average = total / 3.0f;
            //Console.WriteLine("{0} {1} {2} {3} {4}", kor, eng, math, total, Math.Round(average));




        }
    }
}
