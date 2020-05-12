using System;

namespace learning_сentre
{
    class Program
    {
        static void Main()
        {
            Student a = new Student();
            Professor b = new Professor();
            Admin c = new Admin();
            Manager d = new Manager();
            a.Show();
            b.Show();
            c.Show();
            d.Show();
        }
    }
}