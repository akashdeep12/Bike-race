using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomLabelMove
{
    public partial class game : Form
    {
        Racer[] Obj_racer = new Racer[3];
        Main[] Obj_race = new Main[4];
        Random random = new Random();
        Betting OBJ_betting = new Betting();
      
        public game()
        {
            InitializeComponent();
            Obj_racer[0] = new Racer() { Name = "Sofia", money = 50, btn_rb = SofiaradioButton, Lb = sofialabel };
            Obj_racer[1] = new Racer() { Name = "Jack", money = 50, btn_rb = JackradioButton, Lb = jacklabel };
            Obj_racer[2] = new Racer() { Name = "Dante", money = 50, btn_rb = DanteradioButton, Lb =dantelabel };

            Uplabel();
            Obj_racer[0].moneyput(0,0);
            Obj_racer[1].moneyput(0,0);
            Obj_racer[2].moneyput(0,0);

            betmin.Text = "Minimun bet: "+anmountincredecrese.Value.ToString()+" bucks";
          
        }
        private void amountwinner(int firstbike)
        {
            for (int k = 0; k < 3; k++)
            {
                Obj_racer[k].Firstrace(firstbike);
            }
        }

        private void Betting_Click(object sender, EventArgs e)
        {
            if (SofiaradioButton.Checked)
            {
                if (Obj_racer[0].moneyput((int)anmountincredecrese.Value, (int)RacerSelect.Value))
                {
                    sofialabel = Obj_racer[0].Lb;
                }
                else
                {
                    MessageBox.Show("not enough money to bet");
                    Obj_racer[0].moneyput(0, 0);
                }
            }
            else if (JackradioButton.Checked)
            {
                if (Obj_racer[1].moneyput((int)anmountincredecrese.Value, (int)RacerSelect.Value))
                {
                    sofialabel = Obj_racer[1].Lb;
                }
                else
                {
                    MessageBox.Show("not enough money to bet");
                    Obj_racer[1].moneyput(0, 0);
                }
            }
            else if (DanteradioButton.Checked)
            {
                if (Obj_racer[2].moneyput((int)anmountincredecrese.Value, (int)RacerSelect.Value))
                {
                    sofialabel = Obj_racer[2].Lb;
                }
                else
                {
                    MessageBox.Show("not enough money to bet");
                    Obj_racer[2].moneyput(0, 0);
                }
            }
        }

        private void Sofiarb_CheckedChanged(object sender, EventArgs e)
        {
            labelBetterName.Text = Obj_racer[0].Name;
        }

        private void jackrb_CheckedChanged(object sender, EventArgs e)
        {
            labelBetterName.Text = Obj_racer[1].Name;
        }

        private void danteRB_CheckedChanged(object sender, EventArgs e)
        {
            labelBetterName.Text = Obj_racer[2].Name;
        }


        private void Racer_Click(object sender, EventArgs e)
        {
            Bet1.Enabled = false;
            timer1.Start();
            Obj_race[0] = new Main();
            Obj_race[0].race = random;
            Obj_race[0].PBox = bike1;
            Obj_race[0].Posstart = bike1.Left;


            Obj_race[1] = new Main();
            Obj_race[1].race = random;
            Obj_race[1].PBox = bike2;
            Obj_race[1].Posstart = bike1.Left;

            Obj_race[2] = new Main();
            Obj_race[2].race = random;
            Obj_race[2].PBox = bike3;
            Obj_race[2].Posstart = bike1.Left;

            Obj_race[3] = new Main();
            Obj_race[3].race = random;
            Obj_race[3].PBox = bike4;
            Obj_race[3].Posstart = bike1.Left;
        }

        private void timer_Tick(object sender, EventArgs e) 
        {
            int first;
            for(int k=0; k<4; k++)
            {
                if(Obj_race[k] != null)
                {
                    Obj_race[k].racebike();
                    if(Obj_race[k].racebike())
                    {
                        timer1.Stop();
                        
                        first = k+1;
                        MessageBox.Show("the winner bike is " + first);
                        amountwinner(first);
                        Bet1.Enabled = true;
                        for (int m=0; m<4; m++)
                        {
                            Obj_race[m].racestr();
                        }
                    }
                    
                }
            }
        }
        

        private void Uplabel()
        {
            for (int i = 0; i < 3; i++)
            {
                Obj_racer[i].UpdateLabels();
            }
        }

        private void bike4_Click(object sender, EventArgs e)
        {

        }

        private void labelbt_Click(object sender, EventArgs e)
        {

        }

        private void jacklabel_Click(object sender, EventArgs e)
        {

        }
    }
}
