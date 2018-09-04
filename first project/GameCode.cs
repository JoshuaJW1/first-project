using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_project
{
    public class GameCode
    {
        public int winCount = 0;
        public int lossCount = 0;
        public int checkCount = 0;
        public int count = 0;
        public int rnd = 0;
        public int RNDGenerator()
        {
            Random rndNumber = new Random();
            return rndNumber.Next(1, 7);
        }
        
    }
}
