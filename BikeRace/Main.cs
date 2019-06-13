using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomLabelMove
{
    class Main
    {
        public PictureBox PBox;
        public Random race;
        public int Posstart;


        public bool racebike()
        {
            PBox.Left += race.Next(4);
            if(PBox.Left >= PBox.Parent.Width - PBox.Width)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void racestr()
        {
            PBox.Left = Posstart;
        }
    }
}
