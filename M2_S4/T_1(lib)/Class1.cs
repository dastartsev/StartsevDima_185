using System;

namespace T_1_lib_
{
    public class A
        {
            public virtual void get_A ()
            {
                Console.Write("A ");
            }

        }

    public class B:A
    {
        public override void get_A()
        {
            Console.Write("B ");
        }
    }
}
