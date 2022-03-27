using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Simulation7
{
    public partial class Form1 : Form
    {
        private const decimal N = 50;

        private readonly Random rand = new Random();

        /// <summary>
        ///     Сезонность
        /// </summary>
        private readonly List<decimal> SEZ = new List<decimal>
        {
            1.5M,
            0.6M,
            2M,
            0.75M
        };

        /// <summary>
        ///     Поток клиентов.
        /// </summary>
        private decimal CF;

        /// <summary>
        ///     Выделенные на развитие средства.
        /// </summary>
        private decimal DFF;

        /// <summary>
        ///     Поток денег.
        /// </summary>
        private decimal FF;

        /// <summary>
        ///     Бюджет.
        /// </summary>
        private decimal FOC;

        /// <summary>
        ///     Прибыль.
        /// </summary>
        private decimal INC;

        /// <summary>
        ///     Количество клиентов.
        /// </summary>
        private decimal NOC;

        private int Weeks = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private decimal RandomPOP => 1 + (decimal) (rand.Next(0, 11) - 5) / 100;

        private void RunButton_Click(object sender, EventArgs e)
        {
            if (!MainTimer.Enabled)
            {
                CF = ClientsNumeric.Value;
                FF = MoneyNumeric.Value;
                InitValues();
                MainTimer.Start();
            }
            else
            {
                MainTimer.Stop();
                MoneyChart.Series["Money"].Points.Clear();
                MoneyChart.Series["Clients"].Points.Clear();
            }
        }

        private void MainTimer_Tick(object sender, EventArgs e)
        {
            InitValues();
            MoneyChart.Series["Money"].Points.AddXY(Weeks, FOC);
            ClientsChart.Series["Clients"].Points.AddXY(Weeks, NOC);

            Weeks++;
        }

        private void InitValues()
        {
            CF *= Weeks % 12 == 1
                ? RandomPOP * SEZ[Weeks / 12 % 4]
                : RandomPOP;

            NOC = CF;
            INC = NOC * N;

            FF += INC;
            FOC = FF;
            DFF = FOC * 0.8M;
            FF = DFF;
        }
    }
}