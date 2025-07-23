using OOP02.Binding;
using OOP02.inheritance;
using OOP02.overriding;

namespace OOP02
{
    internal class Program
    {
        //static void EmployeeProcess(FullTimeEmployee employee)
        //{
        //    if (employee is not null)
        //    {
        //        employee.Fun01();
        //        employee.Fun02();
        //    }

        //}

        //static void EmployeeProcess(PartTimeEmployee employee)
        //{
        //    if (employee is not null)
        //    {
        //        employee.Fun01();
        //        employee.Fun02();
        //    }
        //}

        //static void EmployeeProcess(PartTimeEmployee employee)
        //{
        //    if (employee is not null)
        //    {
        //        employee.Fun01();
        //        employee.Fun02();
        //    }

        //static void EmployeeProcess(Employee employee)
        //{
        //    if (employee is not null)
        //    {
        //        employee.Fun01();
        //        employee.Fun02();
        //    }


        static int Sum(int X, int Y, int Z)
        { 
            return X + Y + Z;       
        }

        static int Sum(int X, int Y)
        {
            return X + Y;
        }


        static double Sum(double X, double Y)
        {
            return X + Y;
        }

        static double Sum(int X, double Y)
        {
            return X + Y;
        }

        static double Sum(double X, int Y)
        {
            return X + Y;
        }


        static void Main()
        {
            #region Class Vs Struct 
            // Class Vs Struct 

            #endregion

            #region Inheritance
            // 2 Inheritance :
            // X --> Y 
            // DRY 

            //Parent parent = new Parent(1, 2);

            ////Console.WriteLine(parent);
            //parent.Fun01();
            //parent.Fun02();

            Child child = new Child(1, 2, 3);

            child.Fun01();
            child.Fun02();

            #endregion

            #region Polymorphism Overview
            // 3. Polymorphism
            // 3.1. Polymorphism Methods (Functions) Overloading
            // 3.2. Polymorphism Methods (Functions) Overriding 

            // Console.WhriteLine(); 
            #endregion

            #region 3.1. Polymorphism Methods (Functions) Overloading
            // 3.1. Polymorphism Methods (Functions) Overloading
            // There are More than One Function (in the same scope [class - struct])
            // These have the same Name but With Different Signature
            // (count - type - order) Parameters

            //Sum(1, 2);
            //Sum(1.3, 2.4);

            //Sum(1.3,2.4);
            //Sum() 
            #endregion

            #region 3.2. Polymorphism Methods (Functions) Overriding
            // 3.2. Polymorphism Methods (Functions) Overriding 
            // There are more than one functions [in the different class] these have the same Name and
            // the same signature but with behaviour

            //TypeB typeB = new TypeB() { A = 12, B = 13 };

            ////typeB.A = 12;
            ////typeB.B = 13;

            //Console.WriteLine(typeB.A);
            //Console.WriteLine(typeB.B);

            //typeB.Fun01();
            //typeB.Fun02();

            #endregion

            #region What is Binding ?
            //// Binding 
            //// What is Binding ?

            //// ReferenceFromParent ---> ObjectChild

            //TypeA Ref;

            //Ref = new TypeA();
            //// Ref = new TypeB();

            //// Child is a Parent 

            //// TypeB is a TypeA

            //Ref = new TypeB();

            //Ref.A = 12;
            ////Ref.B = 12;

            //Ref.Fun01(); // Static Binded Methods  
            //Ref.Fun02(); 
            #endregion

            #region Not Binding

            // Binding 
            // RefParent ---> ObjChild

            //TypeA Ref = new TypeA();

            //Ref = new TypeB(); // Binding

            //TypeB Ref = new TypeB();

            //Ref = new TypeA();

            //Child is a Parent

            // Animal --> Dog : Dog is a Animal 
            // Dog -> (Dog) Animal : Animal is a Dog


            //TypeA Ref = new TypeA();
            ////Ref = new TypeB();


            //TypeB typeB = (TypeB)Ref;

            #endregion

            #region When U Need Binding ??

            // When U Need Binding ??

            // FullTimeEmployee : Id, Name, Address< Email, Salary

            //FullTimeEmployee fullTimeEmployee = new FullTimeEmployee()
            //{
            //    Id = 1,
            //    Name = "Ahmed",
            //    Email = "ahmed@g.c",
            //    Address = "Cairo",
            //    Salary = 12000

            //};

            //// PartTimeEmployee : Id, Name, Address, Email, NumberOfHours, HourRate 

            //PartTimeEmployee partTimeEmployee = new PartTimeEmployee()
            //{
            //    Id = 2,
            //    Name = "Ziad",
            //    Email = "Ziad@g.C",
            //    Address = "Cairo",
            //    Hourrate = 300,
            //    NumberOfHour = 200
            //};

            ////EmployeeProcess(partTimeEmployee);
            ////// NullReferenceException 

            #endregion














        }
    }
}
