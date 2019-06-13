using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomLabelMove
{
    class Racer
    {
        public string Name;
        public RadioButton btn_rb;
        public Label Lb;
        public int check;
        public Betting Start;
        public int money;
      
      

        public void UpdateLabels()
        {
            btn_rb.Text = Name + " has " + money + " $";

            Lb.Text = Name+"  yet to placed a bet";
            if (check == 1)
            {
                Lb.Text = Name + "  yet to placed a bet";
            }
        }
        public void clearmoney()
        {
            Start.Amount = 0;
        }

        public void Firstrace(int Winracer)
        {
            money += Start.Amount_win(Winracer);
            clearmoney();
            UpdateLabels();
        }

        public bool moneyput(int amount, int firstracer)
        {
            Start = new Betting()
            {
                Amount = amount,
                racer = firstracer,
                Beter = this
            };
            Start.Amount = amount;
            if (amount > money)
            {
                MessageBox.Show($@"not enough money$");
                return false;
            }
            if (money >= 1)
            {
                Lb.Text = Start.uplabels();
                return true;
            }
            else
            {
                return false;
            }
        }

        
    }
}
