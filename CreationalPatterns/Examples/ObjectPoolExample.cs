using CreationalPatterns.ObjectPoolPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.Examples
{
    public class ObjectPoolExample
    {
        public void Run()
        {
            ReusablePool pool = new ReusablePool();

            Reusable a = pool.AcquireReusable();

            pool.Size = 10;

            Reusable b = pool.AcquireReusable();

            b.Name = "B";

            if (a != null)
            {
                a.Name = "A";
                Console.WriteLine(a.Name);
            }

            Console.WriteLine(b.Name);


            pool.ReleasReusable(b);



            Reusable c = pool.AcquireReusable();
            Reusable d = pool.AcquireReusable();

            d.Name = "D";

            Console.WriteLine(c.Name);
            Console.WriteLine(d.Name);
        }
    }
}
