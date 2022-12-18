using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace connect4.graphics.trial
{
    public partial class Form1 : Form
    {
        public static int[] ColumnDimension = { 242, 288, 334, 380, 426, 472, 518 };
        public static int[] RowDimension = { 104, 150, 196, 242, 288, 334 };
        public static int[] FillColumn = { -1, -1, -1, -1, -1, -1, -1 };
        public static int[] FillRow = { 6, 6, 6, 6, 6, 6, 6 };
        public static int StartGame = 0;
        public static int rows = 6;
        public static int columns = 7;
        public static int[,] Board = new int[rows, columns];
        public static int Turn = 2;
        public static int buttonOne = 0;
        public static int buttonTwo = 0;
        public static int buttonThree = 0;
        public static int buttonFour = 0;
        public static int buttonFive = 0;
        public static int buttonSix = 0;
        public static int buttonSeven = 0;
        void Loop()
        {
            while (StartGame != -1)
            {
                one_Click();
                if (Turn == 1)
                {
                    Turn++;
                }
                else if (Turn == 2)
                {
                    Turn--;
                }
            }


        }

        public void one_Click()
        {
            throw new NotImplementedException();
        }

        public Form1()
        {
            InitializeComponent();
            this.BackColor = System.Drawing.Color.DarkBlue;
        }

        public void Start_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            System.Drawing.SolidBrush circleBrush = new System.Drawing.SolidBrush(System.Drawing.Color.White);
            System.Drawing.Graphics graphics;
            graphics = this.CreateGraphics();
            for (int i = 242; i <= 518; i = i + 46)
            {
                for (int x = 334; x >= 103; x = x - 46)
                {
                    graphics.FillEllipse(circleBrush, new Rectangle(i, x, 40, 40));
                }
            }
        }

        public void one_Click(object sender, EventArgs e)
        {
            if (Turn == 1)
            {
                Turn++;
            }
            else if (Turn == 2)
            {
                Turn--;
            }
            buttonOne++;
            Graphics g = this.CreateGraphics();
            System.Drawing.SolidBrush redbrush = new System.Drawing.SolidBrush(System.Drawing.Color.Red);
            System.Drawing.SolidBrush yellowbrush = new System.Drawing.SolidBrush(System.Drawing.Color.Yellow);
            System.Drawing.Graphics graphics;
            graphics = this.CreateGraphics();
            FillColumn[0]++;
            FillRow[0]--;
            Program ToAddBoard = new Program();
            for (int i = 0; i <= FillColumn[0]; i++)
            {
                if (Turn == 1)
                {
                    Board[5, i] = 1;
                    int x = FillRow[0];
                    do
                    {
                        graphics.FillEllipse(redbrush, new Rectangle(ColumnDimension[0], RowDimension[x], 40, 40));
                    }
                    while (x > RowDimension.Length + 1);



                }
                else if (Turn == 2)
                {
                    Board[5, i] = 2;
                    int x = FillRow[0];
                    do
                    {
                        graphics.FillEllipse(yellowbrush, new Rectangle(ColumnDimension[0], RowDimension[x], 40, 40));
                    }
                    while (x > RowDimension.Length + 1);

                }
            }
            if(buttonOne == rows)
            {
                one.Visible = false;
            }

        }

        public void two_Click(object sender, EventArgs e)
        {
            if (Turn == 1)
            {
                Turn++;
            }
            else if (Turn == 2)
            {
                Turn--;
            }
            buttonTwo++;
            Graphics g = this.CreateGraphics();
            System.Drawing.SolidBrush redbrush = new System.Drawing.SolidBrush(System.Drawing.Color.Red);
            System.Drawing.SolidBrush yellowbrush = new System.Drawing.SolidBrush(System.Drawing.Color.Yellow);
            System.Drawing.Graphics graphics;
            graphics = this.CreateGraphics();
            FillColumn[1]++;
            FillRow[1]--;
            Program ToAddBoard = new Program();
            for (int i = 0; i <= FillColumn[1]; i++)
            {
                if (Turn == 1)
                {
                    Board[5, i] = 1;
                    int x = FillRow[1];
                    do
                    {
                        graphics.FillEllipse(redbrush, new Rectangle(ColumnDimension[1], RowDimension[x], 40, 40));
                    }
                    while (x > RowDimension.Length + 1);



                }
                else if (Turn == 2)
                {
                    Board[5, i] = 2;
                    int x = FillRow[1];
                    do
                    {
                        graphics.FillEllipse(yellowbrush, new Rectangle(ColumnDimension[1], RowDimension[x], 40, 40));
                    }
                    while (x > RowDimension.Length + 1);

                }
            }
            if (buttonTwo == rows)
            {
                two.Visible = false;
            }
        }

        public void three_Click(object sender, EventArgs e)
        {
            if (Turn == 1)
            {
                Turn++;
            }
            else if (Turn == 2)
            {
                Turn--;
            }
            buttonThree++;
            Graphics g = this.CreateGraphics();
            System.Drawing.SolidBrush redbrush = new System.Drawing.SolidBrush(System.Drawing.Color.Red);
            System.Drawing.SolidBrush yellowbrush = new System.Drawing.SolidBrush(System.Drawing.Color.Yellow);
            System.Drawing.Graphics graphics;
            graphics = this.CreateGraphics();
            FillColumn[2]++;
            FillRow[2]--;
            Program ToAddBoard = new Program();
            for (int i = 0; i <= FillColumn[2]; i++)
            {
                if (Turn == 1)
                {
                    Board[5, i] = 1;
                    int x = FillRow[2];
                    do
                    {
                        graphics.FillEllipse(redbrush, new Rectangle(ColumnDimension[2], RowDimension[x], 40, 40));
                    }
                    while (x > RowDimension.Length + 1);



                }
                else if (Turn == 2)
                {
                    Board[5, i] = 2;
                    int x = FillRow[2];
                    do
                    {
                        graphics.FillEllipse(yellowbrush, new Rectangle(ColumnDimension[2], RowDimension[x], 40, 40));
                    }
                    while (x > RowDimension.Length + 1);

                }
            }
            if (buttonThree == rows)
            {
                three.Visible = false;
            }
        }

        public void four_Click(object sender, EventArgs e)
        {
            if (Turn == 1)
            {
                Turn++;
            }
            else if (Turn == 2)
            {
                Turn--;
            }
            buttonFour++;
            Graphics g = this.CreateGraphics();
            System.Drawing.SolidBrush redbrush = new System.Drawing.SolidBrush(System.Drawing.Color.Red);
            System.Drawing.SolidBrush yellowbrush = new System.Drawing.SolidBrush(System.Drawing.Color.Yellow);
            System.Drawing.Graphics graphics;
            graphics = this.CreateGraphics();
            FillColumn[3]++;
            FillRow[3]--;
            Program ToAddBoard = new Program();
            for (int i = 0; i <= FillColumn[3]; i++)
            {
                if (Turn == 1)
                {
                    Board[5, i] = 1;
                    int x = FillRow[3];
                    do
                    {
                        graphics.FillEllipse(redbrush, new Rectangle(ColumnDimension[3], RowDimension[x], 40, 40));
                    }
                    while (x > RowDimension.Length + 1);



                }
                else if (Turn == 2)
                {
                    Board[5, i] = 2;
                    int x = FillRow[3];
                    do
                    {
                        graphics.FillEllipse(yellowbrush, new Rectangle(ColumnDimension[3], RowDimension[x], 40, 40));
                    }
                    while (x > RowDimension.Length + 1);

                }
            }
            if (buttonFour == rows)
            {
                four.Visible = false;
            }
        }

        public void five_Click(object sender, EventArgs e)
        {
            if (Turn == 1)
            {
                Turn++;
            }
            else if (Turn == 2)
            {
                Turn--;
            }
            buttonFive++;
            Graphics g = this.CreateGraphics();
            System.Drawing.SolidBrush redbrush = new System.Drawing.SolidBrush(System.Drawing.Color.Red);
            System.Drawing.SolidBrush yellowbrush = new System.Drawing.SolidBrush(System.Drawing.Color.Yellow);
            System.Drawing.Graphics graphics;
            graphics = this.CreateGraphics();
            FillColumn[4]++;
            FillRow[4]--;
            Program ToAddBoard = new Program();
            for (int i = 0; i <= FillColumn[4]; i++)
            {
                if (Turn == 1)
                {
                    Board[5, i] = 1;
                    int x = FillRow[4];
                    do
                    {
                        graphics.FillEllipse(redbrush, new Rectangle(ColumnDimension[4], RowDimension[x], 40, 40));
                    }
                    while (x > RowDimension.Length + 1);



                }
                else if (Turn == 2)
                {
                    Board[5, i] = 2;
                    int x = FillRow[4];
                    do
                    {
                        graphics.FillEllipse(yellowbrush, new Rectangle(ColumnDimension[4], RowDimension[x], 40, 40));
                    }
                    while (x > RowDimension.Length + 1);

                }
            }
            if (buttonFive == rows)
            {
                five.Visible = false;
            }
        }

        private void six_Click(object sender, EventArgs e)
        {
            if (Turn == 1)
            {
                Turn++;
            }
            else if (Turn == 2)
            {
                Turn--;
            }
            buttonSix++;
            Graphics g = this.CreateGraphics();
            System.Drawing.SolidBrush redbrush = new System.Drawing.SolidBrush(System.Drawing.Color.Red);
            System.Drawing.SolidBrush yellowbrush = new System.Drawing.SolidBrush(System.Drawing.Color.Yellow);
            System.Drawing.Graphics graphics;
            graphics = this.CreateGraphics();
            FillColumn[5]++;
            FillRow[5]--;
            Program ToAddBoard = new Program();
            for (int i = 0; i <= FillColumn[5]; i++)
            {
                if (Turn == 1)
                {
                    Board[5, i] = 1;
                    int x = FillRow[5];
                    do
                    {
                        graphics.FillEllipse(redbrush, new Rectangle(ColumnDimension[5], RowDimension[x], 40, 40));
                    }
                    while (x > RowDimension.Length + 1);



                }
                else if (Turn == 2)
                {
                    Board[5, i] = 2;
                    int x = FillRow[5];
                    do
                    {
                        graphics.FillEllipse(yellowbrush, new Rectangle(ColumnDimension[5], RowDimension[x], 40, 40));
                    }
                    while (x > RowDimension.Length + 1);

                }
            }
            if (buttonSix == rows)
            {
                six.Visible = false;
            }
        }

        private void seven_Click(object sender, EventArgs e)
        {
            if (Turn == 1)
            {
                Turn++;
            }
            else if (Turn == 2)
            {
                Turn--;
            }
            buttonSeven++;
            Graphics g = this.CreateGraphics();
            System.Drawing.SolidBrush redbrush = new System.Drawing.SolidBrush(System.Drawing.Color.Red);
            System.Drawing.SolidBrush yellowbrush = new System.Drawing.SolidBrush(System.Drawing.Color.Yellow);
            System.Drawing.Graphics graphics;
            graphics = this.CreateGraphics();
            FillColumn[6]++;
            FillRow[6]--;
            Program ToAddBoard = new Program();
            for (int i = 0; i <= FillColumn[6]; i++)
            {
                if (Turn == 1)
                {
                    Board[5, i] = 1;
                    int x = FillRow[6];
                    do
                    {
                        graphics.FillEllipse(redbrush, new Rectangle(ColumnDimension[6], RowDimension[x], 40, 40));
                    }
                    while (x > RowDimension.Length + 1);



                }
                else if (Turn == 2)
                {
                    Board[5, i] = 2;
                    int x = FillRow[6];
                    do
                    {
                        graphics.FillEllipse(yellowbrush, new Rectangle(ColumnDimension[6], RowDimension[x], 40, 40));
                    }
                    while (x > RowDimension.Length + 1);

                }
            }
            if (buttonSeven == rows)
            {
                seven.Visible = false;
            }
        }
    }


}

