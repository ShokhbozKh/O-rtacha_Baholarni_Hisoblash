namespace oop_vazifa_1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student();
            student1.Name = "Jack";
            student1.RollNumber = 1;

            student1.DisplayInfo();
            Console.WriteLine();

            Student student2 = new Student();
            student2.Name = "Mark";
            student2.RollNumber = 2;
            student2.Marks = new int[] { 3, 3, 3, 4, 5, 0 };

            student2.DisplayInfo();

        }
    }
    class Student
    {
        public string Name { get; set; }
        public int RollNumber { get; set; }

        public int[] Marks { get; set; }


        //create constructor;
        public Student()
        {
            Marks = new int[] { 4, 5, 5, 5, 5, 5 };
            Name = string.Empty; // yoki "";
            RollNumber = 12;// default qiymat  qiymat bush bulsa beriladi

        }

        public float CalculateAverage(int[] Marks)
        {
            int sum = 0;
            float result;

            foreach (int i in Marks)
            {
                sum = sum + i;
            }

            result = (sum / Marks.Length);

            return result;
        }
        public void DisplayInfo()
        {

            Console.WriteLine($"Name :{Name} \n RollNumber :{RollNumber} \n O\'rtacha baho: {CalculateAverage(Marks)}");
        }
    }
}