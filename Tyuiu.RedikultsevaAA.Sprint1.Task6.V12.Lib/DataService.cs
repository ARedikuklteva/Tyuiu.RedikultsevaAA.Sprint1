using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.RedikultsevaAA.Sprint1.Task6.V12.Lib
{
    public class DataService : ISprint1Task6V12
    {
        public bool CheckLastWordRepetiton(string value)
        {
            int x = value.LastIndexOf(' ');
            string stroka = value.Substring(x);
            int y = value.IndexOf(stroka);

            Boolean Tr = true;
            Boolean Fal = false;
            if (x != y)
            {
                return Tr;
            }
            else
            {
                return Fal;
            }
        }
    }
}