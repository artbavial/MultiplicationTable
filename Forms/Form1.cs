using MultiplicationTable.LogicProgram;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiplicationTable
{
    public partial class MainForm : Form
    {
        TreanerMultiplicationTable obj = new TreanerMultiplicationTable();
        DateTime date;

        public MainForm()
        {
            InitializeComponent();

            Start();   
        }

        void Start()
        {
            TimerSecond();
            obj.GeneratingRandomNumbers(2, 10, label_X, label_Y);
        }

        public void TimerSecond()
        {
            date = DateTime.Now;

            Timer timer = new Timer();
            timer.Interval = 10;
            timer.Tick += new EventHandler(timerSecondomer_Tick);
            timer.Start();

        }
        public void timerSecondomer_Tick(object sender, EventArgs e)
        {
            long tick = DateTime.Now.Ticks - date.Ticks;
            DateTime stopWatch = new DateTime();
            stopWatch = stopWatch.AddTicks(tick);
            label_timer.Text = String.Format("{0:HH:mm:ss}", stopWatch);

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            obj.GeneratingRandomNumbers(2, 10, label_X, label_Y);
        }
    }
}
