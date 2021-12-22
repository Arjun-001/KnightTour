using ChessAssignmentWindows;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


/*
 Names of various types on the form tools and their usage
        rich -> rich text box
        numberOfTimes -> numeric up and down for selecting number of times
        intelligent -> radio button for selecting intelligent method
        simple -> radio button for selecting simple method
        posOn -> radio button for selecting whether the user wants to specify the position
        posOff -> radio button for selecting whether the user wants to randomize the position
        rows -> numeric up and down for selecting rows
        cols -> numeric up and down for selecting columns
        button1 -> Go! button on the form
*/

namespace ChessAssignmentWindows
{

    public partial class Form1 : Form
    {
        //initialize variables
        private Random ran = new Random();
        private int sum = 0;
        private double[] std;
        private int number = 0;
        private double avg = 0;
        public static string intelligents = "";
        public Form1()
        {
            InitializeComponent();
        }

        //Show the numeric up and down and labels for selection of rows and columns if the check radio is changed
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Lrows.Visible = true;
            Lcols.Visible = true;
            rows.Visible = true;
            columns.Visible = true;
        }

        //Show the numeric up and down and labels for selection of rows and columns if the check radio is changed
        private void posOff_CheckedChanged(object sender, EventArgs e)
        {
            Lrows.Visible = false;
            Lcols.Visible = false;
            rows.Visible = false;
            columns.Visible = false;
        }

        //When Go! button is clicked
        private void button1_Click(object sender, EventArgs e)
        {
            //get the number of tours selected
            number = Convert.ToInt32(numberOfTimes.Value);
            //specify the length of std based on the number of times selected
            std = new double[number];
            int row = 0;
            int col = 0;
            //if the user selected the simple method
            if (simple.Checked)
            {
                //clear the richtextbox
                rich.Clear();
                //if the user wants to specify position of the knight
                if (posOn.Checked)
                {
                    row = Convert.ToInt32(rows.Value);
                    col = Convert.ToInt32(columns.Value);
                    for (int i = 0; i < number; i++)
                    {
                        rich.AppendText("Number " + (i + 1) + " out of " + number + "\n");
                        //call the the simplemethod with user defined position
                        simplemethod(row - 1, col - 1, i);
                    }
                }
                //if the user wants to randomize the position of the knight
                else
                {
                    for (int i = 0; i < number; i++)
                    {
                        row = ran.Next(0, 8);
                        col = ran.Next(0, 8);
                        rich.AppendText("Number " + (i + 1) + " out of " + number + "\n");
                        //call to the simple method with random position
                        simplemethod(row, col, i);
                    }
                }
                // calculate the average and the standard deviation
                avg = Convert.ToDouble(sum) / number;
                double stddev = 0;
                for (int i = 0; i < number; i++)
                {
                    int temp = (int)std[i];
                    std[i] = Math.Pow(temp - avg, 2);
                    stddev = stddev + std[i];
                }
                double standard = Math.Sqrt(stddev / number);
                //display average and standard deviation
                rich.AppendText("The average is " + Math.Round(avg, 3) +
                    " and the standard deviation is " + Math.Round(standard, 3));

                MessageBox.Show("The average is " + Math.Round(avg, 3) +
                    " and the standard deviation is " + Math.Round(standard, 3));

                //sets the variables to 0
                standard = 0;
                sum = 0;
                avg = 0;
            }
            //if the user selected the intelligent method
            else
            {
                //clear the rich text box
                rich.Clear();
                //if the user wants to specify the position of the knight
                if (posOn.Checked)
                {
                    row = Convert.ToInt32(rows.Value);
                    col = Convert.ToInt32(columns.Value);
                    for (int i = 0; i < number; i++)
                    {
                        rich.AppendText("Number " + (i + 1) + " out of " + number + "\n");
                        intelligentmethod(row - 1, col - 1, i);
                    }
                }
                else
                {
                    for (int i = 0; i < number; i++)
                    {
                        row = ran.Next(0, 8);
                        col = ran.Next(0, 8);
                        rich.AppendText("Number " + (i + 1) + " out of " + number + "\n");
                        intelligentmethod(row, col, i);
                    }
                }
                avg = Convert.ToDouble(sum) / number;
                double stddev = 0;
                for (int i = 0; i < number; i++)
                {
                    int temp = (int)std[i];
                    std[i] = Math.Pow(temp - avg, 2);
                    stddev = stddev + std[i];
                }
                double standard = Math.Sqrt(stddev / number);
                rich.AppendText("The average number of steps is " + Math.Round(avg, 3) +
                    " and the standard deviation is " + Math.Round(standard, 3));

                MessageBox.Show("The average number of steps is " + Math.Round(avg, 3) +
                    " and the standard deviation is " + Math.Round(standard, 3));

                standard = 0;
                sum = 0;
                avg = 0;
            }
        }


        void simplemethod(int row, int col, int forStdDev)
        {
            int[,] board = new int[8, 8]
           {
            {0,0,0,0,0,0,0,0 },
            {0,0,0,0,0,0,0,0 },
            {0,0,0,0,0,0,0,0 },
            {0,0,0,0,0,0,0,0 },
            {0,0,0,0,0,0,0,0 },
            {0,0,0,0,0,0,0,0 },
            {0,0,0,0,0,0,0,0 },
            {0,0,0,0,0,0,0,0 }

           };
            rich.AppendText("Simple method, row :" + (row + 1) + "\t and col:" + (col + 1) + "\n");
            int stepnumber = 1;
            board[row, col] = stepnumber;
            stepnumber++;
            Boolean bol = true;
            while (bol)
            {
                string choicesaval = Check.ToCheck.check(row, col, board);
                char[] charSeparators = new char[] { ' ' };
                string[] values = choicesaval.Split(charSeparators, StringSplitOptions.RemoveEmptyEntries);
                int arrleng = values.Length;
                int index = ran.Next(arrleng);
                string chosen = "";
                try
                {
                    chosen = values[index];
                }
                catch (Exception e)
                {
                    chosen = "set bol to false";
                }

                if (chosen.Equals("upleft"))
                {
                    row = row - 2;
                    col = col - 1;
                    board[row, col] = stepnumber;
                    stepnumber++;
                }
                else if (chosen.Equals("upright"))
                {
                    row = row - 2;
                    col = col + 1;
                    board[row, col] = stepnumber;
                    stepnumber++;
                }
                else if (chosen.Equals("downleft"))
                {
                    row = row + 2;
                    col = col - 1;
                    board[row, col] = stepnumber;
                    stepnumber++;
                }
                else if (chosen.Equals("downright"))
                {
                    row = row + 2;
                    col = col + 1;
                    board[row, col] = stepnumber;
                    stepnumber++;
                }
                else if (chosen.Equals("leftup"))
                {
                    row = row - 1;
                    col = col - 2;
                    board[row, col] = stepnumber;
                    stepnumber++;
                }
                else if (chosen.Equals("leftdown"))
                {
                    row = row + 1;
                    col = col - 2;
                    board[row, col] = stepnumber;
                    stepnumber++;
                }
                else if (chosen.Equals("rightup"))
                {
                    row = row - 1;
                    col = col + 2;
                    board[row, col] = stepnumber;
                    stepnumber++;
                }
                else if (chosen.Equals("rightdown"))
                {
                    row = row + 1;
                    col = col + 2;
                    board[row, col] = stepnumber;
                    stepnumber++;
                }
                else
                {
                    bol = false;
                }
            }
            printmtd(board);
            rich.AppendText("Touched :" + (stepnumber - 1) + "\n");
            std[forStdDev] = stepnumber - 1;
            sum = sum + (stepnumber - 1);
            rich.AppendText("\n");
            using (StreamWriter writer = new StreamWriter("simple.txt"))
            {
                writer.WriteLine(rich.Text);
            }
            intelligents = "";
        }

        void intelligentmethod(int row, int col, int forStdDev)
        {
            int[,] board = new int[8, 8]
               {
            {0,0,0,0,0,0,0,0 },
            {0,0,0,0,0,0,0,0 },
            {0,0,0,0,0,0,0,0 },
            {0,0,0,0,0,0,0,0 },
            {0,0,0,0,0,0,0,0 },
            {0,0,0,0,0,0,0,0 },
            {0,0,0,0,0,0,0,0 },
            {0,0,0,0,0,0,0,0 }

               };
            rich.AppendText("Intelligent method, row :" + (row + 1) + "\t and col:" + (col + 1) + "\n");
            int stepnumber = 1;
            board[row, col] = stepnumber;
            stepnumber++;
            Boolean bol = true;
            while (bol)
            {
                string choicesaval = Check.ToCheck.check(row, col, board);
                char[] charSeparators = new char[] { ' ' };
                string[] values = choicesaval.Split(charSeparators, StringSplitOptions.RemoveEmptyEntries);
                string[] strategyvalue = intelligents.Split(charSeparators, StringSplitOptions.RemoveEmptyEntries);
                int arrleng = values.Length;
                string chosen = "";
                int choosens = 10;
                for (int u = 0; u < arrleng; u++)
                {
                    int tempn = Convert.ToInt32(strategyvalue[u]);
                    string temps = values[u];
                    if (choosens > tempn)
                    {
                        chosen = temps;
                        choosens = tempn;
                    }
                    int torand = ran.Next(0, 100);
                    if (torand % 2 == 0 && choosens == tempn)
                    {
                        chosen = temps;
                        choosens = tempn;
                    }
                }
                if (chosen.Equals("upleft"))
                {
                    row = row - 2;
                    col = col - 1;
                    board[row, col] = stepnumber;
                    stepnumber++;
                }
                else if (chosen.Equals("upright"))
                {
                    row = row - 2;
                    col = col + 1;
                    board[row, col] = stepnumber;
                    stepnumber++;
                }
                else if (chosen.Equals("downleft"))
                {
                    row = row + 2;
                    col = col - 1;
                    board[row, col] = stepnumber;
                    stepnumber++;
                }
                else if (chosen.Equals("downright"))
                {
                    row = row + 2;
                    col = col + 1;
                    board[row, col] = stepnumber;
                    stepnumber++;
                }
                else if (chosen.Equals("leftup"))
                {
                    row = row - 1;
                    col = col - 2;
                    board[row, col] = stepnumber;
                    stepnumber++;
                }
                else if (chosen.Equals("leftdown"))
                {
                    row = row + 1;
                    col = col - 2;
                    board[row, col] = stepnumber;
                    stepnumber++;
                }
                else if (chosen.Equals("rightup"))
                {
                    row = row - 1;
                    col = col + 2;
                    board[row, col] = stepnumber;
                    stepnumber++;
                }
                else if (chosen.Equals("rightdown"))
                {
                    row = row + 1;
                    col = col + 2;
                    board[row, col] = stepnumber;
                    stepnumber++;
                }
                else
                {
                    bol = false;
                }
            }
            rich.AppendText("Touched :" + (stepnumber - 1) + "\n");
            std[forStdDev] = stepnumber - 1;
            sum = sum + (stepnumber - 1);
            int rowLengt = board.GetLength(0);
            int colLengt = board.GetLength(1);
            printmtd(board);
            rich.AppendText("\n");
            using (StreamWriter writer = new StreamWriter("intelligent.txt"))
            {
                writer.WriteLine(rich.Text);
            }
        }

        void printmtd(int[,] board)
        {
            int rowLengt = board.GetLength(0);
            int colLengt = board.GetLength(1);

            for (int r = 0; r < rowLengt; r++)
            {
                for (int j = 0; j < colLengt; j++)
                {
                    rich.AppendText(board[r, j] + "\t");
                }
                rich.AppendText("\n\n");
            }
        }
    }


}
namespace Check
{
    class ToCheck
    {
        public static string check(int row, int col, int[,] board)
        {
            Form1.intelligents = "";
            int[,] boardintelligent = new int[8, 8]
        {
            {2,3,4,4,4,4,3,2 },
            {3,4,6,6,6,6,4,3 },
            {4,6,8,8,8,8,6,4 },
            {4,6,8,8,8,8,6,4 },
            {4,6,8,8,8,8,6,4 },
            {4,6,8,8,8,8,6,4 },
            {3,4,6,6,6,6,4,3 },
            {2,3,4,4,4,4,3,2 }
        };
            string toknow = "";
            if (row - 2 >= 0 && col - 1 >= 0 && board[row - 2, col - 1] == 0)
            {
                toknow = toknow + "upleft ";
                Form1.intelligents = Form1.intelligents + boardintelligent[row - 2, col - 1] + " ";
            }
            if (row - 2 >= 0 && col + 1 < 8 && board[row - 2, col + 1] == 0)
            {
                toknow = toknow + "upright ";
                Form1.intelligents = Form1.intelligents + boardintelligent[row - 2, col + 1] + " ";
            }
            if (row + 2 < 8 && col - 1 >= 0 && board[row + 2, col - 1] == 0)
            {
                toknow = toknow + "downleft ";
                Form1.intelligents = Form1.intelligents + boardintelligent[row + 2, col - 1] + " ";
            }
            if (row + 2 < 8 && col + 1 < 8 && board[row + 2, col + 1] == 0)
            {
                toknow = toknow + "downright ";
                Form1.intelligents = Form1.intelligents + boardintelligent[row + 2, col + 1] + " ";
            }
            if (col - 2 >= 0 && row - 1 >= 0 && board[row - 1, col - 2] == 0)
            {
                toknow = toknow + "leftup ";
                Form1.intelligents = Form1.intelligents + boardintelligent[row - 1, col - 2] + " ";
            }
            if (col - 2 >= 0 && row + 1 < 8 && board[row + 1, col - 2] == 0)
            {
                toknow = toknow + "leftdown ";
                Form1.intelligents = Form1.intelligents + boardintelligent[row + 1, col - 2] + " ";
            }
            if (col + 2 < 8 && row - 1 >= 0 && board[row - 1, col + 2] == 0)
            {
                toknow = toknow + "rightup ";
                Form1.intelligents = Form1.intelligents + boardintelligent[row - 1, col + 2] + " ";
            }
            if (col + 2 < 8 && row + 1 < 8 && board[row + 1, col + 2] == 0)
            {
                toknow = toknow + "rightdown";
                Form1.intelligents = Form1.intelligents + boardintelligent[row + 1, col + 2] + " ";
            }

            return toknow;
        }
    }
}
