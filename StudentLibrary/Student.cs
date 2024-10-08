namespace StudentLibrary
{
    class Student
    {

        private int studentId;
        private string name;
        private int age;
        private static int studentCount = 0;

        public int StudentID
        {
            get { return studentId; }
            private set { studentId = value; } // Private set makes it read-only
        }

        public string Name
        {
            get { return name; }
            set { name = value; }   
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public static int StudentCount
        {
            get { return studentCount; }
            private set { StudentCount = value; }  // Private set makes it read-only
        }

        public Student(int studentId, string name, int age)
        {
            this.studentId = studentId;
            this.name = name;   
            this.age = age;
        }

        void DisplayInfo()
        {
            Console.WriteLine($"Student Name: {Name}");
            Console.WriteLine($"Student Age: {Age}");
        }
    }
}
