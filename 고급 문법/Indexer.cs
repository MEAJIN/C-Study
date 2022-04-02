class MyClass
{
   private const int MAX = 10;
   private string name;

   // 내부의 정수 배열 데이타
   private int[] data = new int[MAX];

   // 인덱서 정의. int 파라미터 사용
   public int this[int index] 
   {
      get
      {            
         if (index < 0 || index >= MAX)
         {
            throw new IndexOutOfRangeException();
         }
         else
         {
            // 정수배열로부터 값 리턴
            return data[index];
         }
      }
      set
      {
         if (!(index < 0 || index >= MAX))
         {
            // 정수배열에 값 저장
            data[index] = value;
         }
      }
   }
}

class Program
{
   static void Main(string[] args)
   {
      MyClass cls = new MyClass();

      // 인덱서 set 사용
      cls[1] = 1024;

      // 인덱서 get 사용
      int i = cls[1];
   }
}
