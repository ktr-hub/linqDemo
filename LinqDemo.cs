using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KT_Revision
{
    class LinqDemo
    {
        List<int> listNumbers = new List<int>();
        public LinqDemo()
        {
            listNumbers.Add(2);
            listNumbers.Add(4);
            listNumbers.Add(6);
            listNumbers.Add(3);
            linqExpression();
        }
        public void linqExpression()
        {
            // Query Syntax
            var list = from item in listNumbers
                       where item < 5 
                       select item;
            foreach(var item in list)
            {
                Console.WriteLine(item);
            }

            //Lambda Syntax
            var list2 = listNumbers.Where(item => item < 5);
            foreach (var item in list2)
            {
                Console.WriteLine(item);
            }


        }
    }
}
