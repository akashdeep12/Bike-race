using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomLabelMove
{
    class Betting
    {
        public Racer Beter;
        public int Amount;
        public int racer;
        
        public int Amount_win(int First)
        {
            if (racer == First)
            {
                return Amount;
            }
            else
            {
                return -Amount;
            }
        }
        public string uplabels()
        {
            
            if (Amount > 0)
            {
                return Beter.Name + " Bet " + Amount + " on " + "racer #" + racer;
            }
            
           
            else
            {

                return Beter.Name + " yet to placed a bet";
            }

        }
        
       
    }
}
