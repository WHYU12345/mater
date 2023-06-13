namespace Progrom
{
    public class Program
    {
        private static void Main(string[] args)
        {
            
            Student student = new Student(12);
            student.Say();
        }

        public abstract class Person
        {
            private int age;

            public int Age { get { return age-12; } set { age = value + 12; } }

            public Person()
            {
                Console.WriteLine("我是一个无参数构造函数");
            }
            public Person(string s)
            {
                Console.WriteLine("我是一个父类参数构造函数");
            }
            public abstract void Say();
        }
        class Student:Person
        {
             private bool sex;   
             private int age;    
            public Student()
            {
                Console.WriteLine("我是学生类的无参数构造函数");
            }
            public Student(int age) : base(age.ToString())    // base是为了实现父类的有参数的构造函数
            {
                Console.WriteLine("我是学生类的无参数构造函数"+age);
            }

            public override void Say()
            {
                Console.WriteLine("我是一个抽象方法");
            }
        }
        //抽象类abstract 不能被实例化 可以包含抽象方法  
        //抽象方法没有方法体  纯粹的虚方法，可以在子类中被实现 （继承）
        //不需要实例化的可以使用抽象方法
        
        //多态  vob   virtual 虚函数  override  重写  base保留父类的方法
    }

}
