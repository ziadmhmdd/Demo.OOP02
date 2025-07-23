using OOP02.inheritance;

namespace OOP02
{
    internal class Program
    {
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
        }
    }
}
