using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace CSharpTraining
{
    public class Exercise13
    {
        public void MainMethod()
        {
            //created the list
            IEnumerable<int> list = new List<int>(){
            2,3,5,6,8,13,16,1
            };
            //to display list elements
            Console.WriteLine("List Elements : {0}",string.Join(", ",list));

            Console.WriteLine("Using CustomAll : "+list.CustomAll(e => e >= 1));
            Console.WriteLine("Using CustomAny : "+list.CustomAny(e => e >9));
            Console.WriteLine("Using CustomMax : "+list.CustomMax(e => e));
            Console.WriteLine("Using CustomMin : "+list.CustomMin(e => e));

            var listWhere = list.CustomWhere(e => e > 2);
            Console.WriteLine("Using CustomWhere : {0}",string.Join(", ",listWhere));

            var listSelect = list.CustomSelect(e=> e);
            Console.WriteLine("Using CustomSelect : {0}",string.Join(", ",listSelect));

        }
        

    }
}
