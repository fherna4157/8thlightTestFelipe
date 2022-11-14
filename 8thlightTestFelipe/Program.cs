using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;

namespace _8thlightTestFelipe
{
    class Program
    {
        static void Main(string[] args)
        {
            eigthlight obj = new eigthlight();
            string strGetnum = obj.getnum(".2265a");
            Console.WriteLine(strGetnum);
            Console.ReadLine();

           
            //List<string> MyList = new List<String>(new string[] { "a", "b", "c", "a", "b", "d" });

            //List<string> nodups = obj.removerepeats(MyList);


            List<int> MyList = new List<int>(new int[] { 4, 4, 3, 2, 3, 1 });

            List<int> nodups = obj.removerepeats(MyList);

            // Same for either case 
            for (int i = 0; i < nodups.Count; i++)
            {
                Console.WriteLine(nodups[i]);
            }

            Console.ReadLine();



        }
    }



    public  class eigthlight{

        public string getnum(string str) {

            //string regex = new Regex("[0-9]");

            MatchCollection mc = Regex.Matches(str, "[0-9]");

            string stroutput = "";
            foreach (Match m in mc)
            {
                Console.WriteLine(m);
                stroutput = stroutput + m;

            }

   


            return stroutput;
            
        }

        public List<string> removerepeats(List<string> s) {
        

            var noDupes = s.Distinct().ToList();

        
            return noDupes;



        }

        public List<int> removerepeats(List<int> s)
        {


            var noDupes = s.Distinct().ToList();


            return noDupes;



        }



    }


}
