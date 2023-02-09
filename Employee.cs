using System;
namespace Class07._02._2023HM
{
    public class Employee
    {
        //1
        /*public static string Name { set; get; } 
        public string Age { set; get; }
        public string Contact_Tel { set; get; }
        public string Email { set; get; }
        public string Job { set; get; }
        public string Duty { set; get; }


        public Employee()
        { }

        public Employee(string A, string C, string E, string J, string D)
        {
            Age = A;
            Contact_Tel = C;
            Email = E;
            Job = J;
            Duty = D;
        }

        public static void SetN(string N)
        {
            Name = N;
        }

        public static string GetN()
        {
            return Name;
        }

        static Employee()
        {
            Console.Write("Введите имя:");
            Name = Convert.ToString(Console.ReadLine());
        }

        public void Enter()
        {
            Console.Write("Введите возраст:");
            Age = Convert.ToString(Console.ReadLine());
            Console.Write("Введите контактный номер:");
            Contact_Tel = Convert.ToString(Console.ReadLine());
            Console.Write("Введите контактный email:");
            Email = Convert.ToString(Console.ReadLine());
            Console.Write("Введите должность:");
            Job = Convert.ToString(Console.ReadLine());
            Console.Write("Введите обязанность:");
            Duty = Convert.ToString(Console.ReadLine());
        }

        public void Print()
        {
            Console.WriteLine($"Имя:{Name}\nВозраст:{Age}\nКонтактный номер:{Contact_Tel}\nКонтактный email{Email}\nДолжность:{Job}\nОбязанность:{Duty}\n");
        }

        public override string ToString()
        {
            return $"Имя:{Name}\nВозраст:{Age}\nКонтактный номер:{Contact_Tel}\nКонтактный email{Email}\nДолжность:{Job}\nОбязанность:{Duty}\n";
        }*/

        //2
        /*public string Name_P { set; get; }
        public string Name_M { set; get; }
        public static int Age { set; get; }
        public string Type_P { set; get; }

        public Employee() { }
        public Employee(string NP, string NM, string TP)
        {
            Name_P = NP;
            Name_M = NM;
            Type_P = TP;
        }
        public static void SetA(int A)
        {
            Age = A;
        }
        public static int GetA()
        {
            return Age;
        }
        static Employee()
        {
            Console.Write("Введите год выпуска самолета:");
            Age = Convert.ToInt32(Console.Read());
        }
        public void Enter()
        {
            Console.WriteLine("Введите название самолета:");
            Name_P = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Введите название производителя:");
            Name_M = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Введите тип самолета:");
            Type_P = Convert.ToString(Console.ReadLine());
            
        }
        public void Print()
        {
            Console.WriteLine($"Название самолета:{Name_P}\nГод выпуска:{Age}\nТип самолета::{Type_P}\n");
        }
        public override string ToString()
        {
            return $"Название самолета:{Name_P}\nГод выпуска:{Age}\nТип самолета:{Type_P}\n";
        }*/


        //3
        static int Count_Line;
        static int Count_Column ;
        int[,] mass = new int[Count_Line, Count_Column];

        public Employee() { }

        public Employee(int CL, int CC)
        {
            Count_Column = CC;
            Count_Line = CL;
        }

        static Employee()
        {
            Console.Write("Введите кол-во строк в матрице:");
            Count_Line = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите кол-во столбцов в матрице:");
            Count_Column = Convert.ToInt32(Console.ReadLine());
        }
        
        public void Mass()
        {
            int Max = mass[0,0];
            int Min = mass[0,0];
            int j = 0;
            int i = 0;
            Random R = new Random();
            for (i = 0; i<Count_Line; i++)
            {
                for ( j = 0; j<Count_Column; j++)
                {
                    mass[i, j] = R.Next(1,30);
                    Console.Write("{0}\t", mass[i, j]);
                    if (mass[i, j] > Max)
                    {
                        Max = mass[i, j];
                    }
                    if (mass[i, j] < Min)
                    {
                        Min = mass[i, j];
                    }
                }
                
                Console.WriteLine();
            }
            Console.WriteLine("Максимальный элимент = " + Max);
            Console.WriteLine("Минимальный элимент = " + Min);

        }

        

        


    }
}
        
    


    































        
