using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace DongHoBamGio
{
    public partial class Form1 : Form
    {
        private int hours, minutes, seconds, tick;
        private Thread t;
        private void runTime()
        {
            tick++;
            if (tick < 10)
            {
                labelTick.Text = "0" + tick;
            }
            else
            {
                labelTick.Text = tick+"";
            }
            if (tick == 100)
            {
                tick = 0;
                seconds++;
                if (seconds >= 60)
                {
                    seconds = 0;
                    minutes++;
                    if (minutes >= 60)
                    {
                        hours++;
                        minutes = 0;
                    }
                }
            }
            labelShowTime.Text = this.showTime();
        }

        private string showTime()
        {
            string res = "";
            if (hours < 10)
                res += "0";
            res += hours + ":";
            if (minutes < 10)
                res += "0";
            res += minutes + ":";
            if (seconds < 10)
                res += "0";
            res += seconds;
            return res;
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            if (btnRestart.Text == "Đặt lại")
            {
                hours = minutes = seconds = tick = 0;
                labelShowTime.Text = showTime();
                labelTick.Text = "00";
            }
        }

        public Form1()
        {
            hours = minutes = seconds = tick = 0;
            t = new Thread(() =>
            {
                while (true)
                {
                    //Tuy 1s =100 tick => Sleep 10ms nhưng để trừ hao do tính toán nên dùng 6ms
                    Thread.Sleep(6);
                    runTime();
                }
            });
            t.IsBackground = true;
            InitializeComponent();
        }

        private void btnStartPause_Click(object sender, EventArgs e)
        {
            if (btnStartPause.Text == "Start")
            {
                t.Start();
                btnStartPause.Text = "Pause";
                btnStartPause.BackColor = Color.Red;
                btnRestart.Text = "Bấm";
            }
            else if (btnStartPause.Text == "Pause")
            {
                //Tạm dừng thread
                t.Suspend();
                btnStartPause.Text = "Continue";
                btnStartPause.BackColor = Color.Purple;
                this.btnRestart.Text = "Đặt lại";
            }
            else if (btnStartPause.Text == "Continue")
            {
                //Cho thread chạy lại
                t.Resume();
                btnStartPause.Text = "Pause";
                btnStartPause.BackColor = Color.Red;
                this.btnRestart.Text = "Bấm";
            }
        }
    }
}
