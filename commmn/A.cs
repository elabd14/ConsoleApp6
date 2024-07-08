using System;

namespace commmn
{
    public class A
    {
        private int x;  //ACCSESSIBLE within its scope only 
        internal int y;  //ACCSESSIBLE within its scope and on the project  
        public int z;  //ACCSESSIBLE within its scope , the project and external project 

        void print()
        {
            Console.WriteLine(x);
            Console.WriteLine(y);   
            Console.WriteLine(z);



        }


    }
}
