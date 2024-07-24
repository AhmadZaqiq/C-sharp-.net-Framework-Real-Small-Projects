using Stadium_Reservation_System.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stadium_Reservation_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timerDate_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString();
        }

        private void setStadiumPictures()
        {
            pb1Stadium.BackgroundImage = Resources.Stadium_;
            pb2Stadium.BackgroundImage = Resources.Stadium_;
            pb3Stadium.BackgroundImage = Resources.Stadium_;
            pb4Stadium.BackgroundImage = Resources.Stadium_;
        }

        private void DisableButtons()
        {
            btn1Start.Enabled = false;
            btn2Start.Enabled = false;
            btn3Start.Enabled = false;
            btn4Start.Enabled = false;

            btn1Pause.Enabled = false;
            btn2Pause.Enabled = false;
            btn3Pause.Enabled = false;
            btn4Pause.Enabled = false;

            btn1End.Enabled = false;
            btn2End.Enabled = false;
            btn3End.Enabled = false;
            btn4End.Enabled = false;

            btn1Add.Enabled = false;
            btn2Add.Enabled = false;
            btn3Add.Enabled = false;
            btn4Add.Enabled = false;

        }

        private void HideClearButtons()
        {
            btn1Clear.Visible = false;
            btn2Clear.Visible = false;
            btn3Clear.Visible = false;
            btn4Clear.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timerDate.Enabled = true;

            setStadiumPictures();

            DisableButtons();

            HideClearButtons();
        }

        private void setDarkColors()
        {
            BackColor = Color.Black;

            chkDarkMode.ForeColor = Color.White;

            label1.ForeColor = Color.White;
            label22.ForeColor = Color.White;
            label10.ForeColor = Color.White;
            label16.ForeColor = Color.White;

            label2.ForeColor = Color.White;
            label21.ForeColor = Color.White;
            label9.ForeColor = Color.White;
            label15.ForeColor = Color.White;

            label3.ForeColor = Color.White;
            label19.ForeColor = Color.White;
            label13.ForeColor = Color.White;
            label7.ForeColor = Color.White;

            label4.ForeColor = Color.White;
            label17.ForeColor = Color.White;
            label5.ForeColor = Color.White;
            label11.ForeColor = Color.White;

            groupBox5.ForeColor = Color.White;

            lblDate.ForeColor = Color.White;
            lbl1Timer.ForeColor = Color.White;
            lbl2Timer.ForeColor = Color.White;
            lbl3Timer.ForeColor = Color.White;
            lbl4Timer.ForeColor = Color.White;
        }

        private void setLightColors()
        {
            BackColor = Color.White;

            chkDarkMode.ForeColor = Color.Black;

            label1.ForeColor = Color.Black;
            label22.ForeColor = Color.Black;
            label10.ForeColor = Color.Black;
            label16.ForeColor = Color.Black;

            label2.ForeColor = Color.Black;
            label21.ForeColor = Color.Black;
            label9.ForeColor = Color.Black;
            label15.ForeColor = Color.Black;

            label3.ForeColor = Color.Black;
            label19.ForeColor = Color.Black;
            label13.ForeColor = Color.Black;
            label7.ForeColor = Color.Black;

            label4.ForeColor = Color.Black;
            label17.ForeColor = Color.Black;
            label5.ForeColor = Color.Black;
            label11.ForeColor = Color.Black;

            groupBox5.ForeColor = Color.Black;

            lblDate.ForeColor = Color.Black;
            lbl1Timer.ForeColor = Color.Black;
            lbl2Timer.ForeColor = Color.Black;
            lbl3Timer.ForeColor = Color.Black;
            lbl4Timer.ForeColor = Color.Black;
        }

        private void chkDarkMode_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDarkMode.Checked)
            {
                setDarkColors();
            }

            else
            {
                setLightColors();
            }
        }

        private void AddTeam(object sender, EventArgs e)
        {
            TextBox[] txtName = { txt1Name, txt2Name, txt3Name, txt4Name };
            Label[] lblName = { lbl1Name, lbl2Name, lbl3Name, lbl4Name };
            Button[] btnAdd = { btn1Add, btn2Add, btn3Add, btn4Add };

            for (byte i = 0; i < txtName.Length; i++)
            {
                if (txtName[i].Text.Length != 0 && lblName[i].Text.Length == 0)
                {
                    btnAdd[i].Enabled = true;
                }

                else
                {
                    btnAdd[i].Enabled = false;
                }
            }
        }

        private void SetTeam(Label lblName, TextBox txtName, Button btnStart, Button btnClear)
        {
            lblName.Text = txtName.Text;
            txtName.Clear();
            btnStart.Enabled = true;
            btnClear.Visible = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            TextBox[] txtName = { txt1Name, txt2Name, txt3Name, txt4Name };
            Label[] lblName = { lbl1Name, lbl2Name, lbl3Name, lbl4Name };
            Button[] btnAdd = { btn1Add, btn2Add, btn3Add, btn4Add };
            Button[] btnStart = { btn1Start, btn2Start, btn3Start, btn4Start };
            Button[] btnClear = { btn1Clear, btn2Clear, btn3Clear, btn4Clear };

            for (byte i = 0; i < btnAdd.Length; i++)
            {
                if ((Button)sender == btnAdd[i])
                {
                    SetTeam(lblName[i], txtName[i], btnStart[i], btnClear[i]);
                    break;
                }
            }

        }

        private void StartPeriod(Button btnPause, Button btnEnd, Timer timer, PictureBox pbStadium, Button btnClear)
        {
            btnPause.Enabled = true;
            btnEnd.Enabled = true;
            timer.Enabled = true;
            pbStadium.BackColor = Color.Lime;
            btnClear.Visible = false;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Button[] btnStart = { btn1Start, btn2Start, btn3Start, btn4Start };
            Button[] btnPause = { btn1Pause, btn2Pause, btn3Pause, btn4Pause };
            Button[] btnEnd = { btn1End, btn2End, btn3End, btn4End };
            Timer[] timer = { timer1, timer2, timer3, timer4 };
            PictureBox[] pbStadium = { pb1Stadium, pb2Stadium, pb3Stadium, pb4Stadium };
            Button[] btnClear = { btn1Clear, btn2Clear, btn3Clear, btn4Clear };

            for (byte i = 0; i < btnStart.Length; i++)
            {
                if ((Button)sender == btnStart[i])
                {
                    btnStart[i].Enabled = false;
                    StartPeriod(btnPause[i], btnEnd[i], timer[i], pbStadium[i], btnClear[i]);
                    break;
                }
            }
        }

        private string[] Counter = { "00:00:00", "00:00:00", "00:00:00", "00:00:00" };

        private void UpdateTimer(byte i, Label lblTimer)
        {
            string[] timeParts = Counter[i].Split(':');
            int hours = int.Parse(timeParts[0]);
            int minutes = int.Parse(timeParts[1]);
            int seconds = int.Parse(timeParts[2]);

            seconds++;

            if (seconds >= 60)
            {
                seconds = 0;
                minutes++;
            }

            if (minutes >= 60)
            {
                minutes = 0;
                hours++;
            }

            Counter[i] = $"{hours:D2}:{minutes:D2}:{seconds:D2}";

            lblTimer.Text = Counter[i];
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            UpdateTimer(0, lbl1Timer);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            UpdateTimer(1, lbl2Timer);
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            UpdateTimer(2, lbl3Timer);
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            UpdateTimer(3, lbl4Timer);
        }

        private void PausePeriod(Timer timer, Button btnPause, PictureBox pbStadium)
        {
            timer.Enabled = false;
            btnPause.Text = "Resume";
            pbStadium.BackColor = Color.Yellow;
        }

        private void ResumePeriod(Timer timer, Button btnPause, PictureBox pbStadium)
        {
            timer.Enabled = true;
            btnPause.Text = "Pause";
            pbStadium.BackColor = Color.Lime;
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            Button[] btnPause = { btn1Pause, btn2Pause, btn3Pause, btn4Pause };
            Timer[] timer = { timer1, timer2, timer3, timer4 };
            PictureBox[] pbStadium = { pb1Stadium, pb2Stadium, pb3Stadium, pb4Stadium };

            for (byte i = 0; i < btnPause.Length; i++)
            {
                if ((Button)sender == btnPause[i])
                {
                    if (btnPause[i].Text != "Resume")
                    {
                        PausePeriod(timer[i], btnPause[i], pbStadium[i]);
                        break;
                    }

                    else
                    {
                        ResumePeriod(timer[i], btnPause[i], pbStadium[i]);
                        break;
                    }

                }
            }
        }

        private void Clear(Button btnClear, Button btnAdd, Button btnStart, Label lblName)
        {
            btnClear.Visible = false;
            btnAdd.Enabled = false;
            btnStart.Enabled = false;
            lblName.Text = string.Empty;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Label[] lblName = { lbl1Name, lbl2Name, lbl3Name, lbl4Name };
            Button[] btnAdd = { btn1Add, btn2Add, btn3Add, btn4Add };
            Button[] btnStart = { btn1Start, btn2Start, btn3Start, btn4Start };
            Button[] btnClear = { btn1Clear, btn2Clear, btn3Clear, btn4Clear };

            for (byte i = 0; i < btnClear.Length; i++)
            {
                if ((Button)sender == btnClear[i])
                {
                    Clear(btnClear[i], btnAdd[i], btnStart[i], lblName[i]);
                    break;
                }
            }

        }

        private void EndPeriod(Label lblName, Button btnEnd, Button btnPause, PictureBox pbStadium, Timer timer)
        {
            lblName.Text = string.Empty;
            btnEnd.Enabled = false;
            btnPause.Enabled = false;
            pbStadium.BackColor = Color.Transparent;
            timer.Enabled = false;
        }

        private int CalculatePeriodPrice(string lblTimer)
        {
            int TotalPrice = 0;

            string[] timeParts = lblTimer.Split(':');
            int hours = int.Parse(timeParts[0]);
            int minutes = int.Parse(timeParts[1]);
            int seconds = int.Parse(timeParts[2]);

            if (hours > 0)
            {
                TotalPrice += (hours * 60);
            }

            if (minutes > 0)
            {
                TotalPrice += (minutes);
            }

            // Seconds is Free ;)

            return (int)(TotalPrice * numericUpDown1.Value);
        }

        private void ShowPeriodPrice(string lblName, string lblTimer)
        {
            MessageBox.Show("Team Name:" + lblName + '\n' + "Total Time:" + lblTimer + '\n' + "Price:" +
                (CalculatePeriodPrice(lblTimer).ToString() + "₪"), "End",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ResetTimerLabel(byte i, Label lblTimer)
        {
            Counter[i] = "00:00:00";
            lblTimer.Text = Counter[i];
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure You Want To End This Period", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                Button[] btnPause = { btn1Pause, btn2Pause, btn3Pause, btn4Pause };
                Timer[] timer = { timer1, timer2, timer3, timer4 };
                PictureBox[] pbStadium = { pb1Stadium, pb2Stadium, pb3Stadium, pb4Stadium };
                Button[] btnEnd = { btn1End, btn2End, btn3End, btn4End };
                Label[] lblName = { lbl1Name, lbl2Name, lbl3Name, lbl4Name };
                Label[] lblTimer = { lbl1Timer, lbl2Timer, lbl3Timer, lbl4Timer };

                for (byte i = 0; i < btnEnd.Length; i++)
                {
                    if ((Button)sender == btnEnd[i])
                    {
                        ShowPeriodPrice(lblName[i].Text, lblTimer[i].Text);

                        EndPeriod(lblName[i], btnEnd[i], btnPause[i], pbStadium[i], timer[i]);

                        ResetTimerLabel(i, lblTimer[i]);

                        break;
                    }
                }
            }
        }


    }
}
