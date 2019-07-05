using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nguyen_VanHa_Assignment1
{
    public partial class IndexForm : Form
    {
        
        public IndexForm()
        {
            InitializeComponent();
            this.Text = "The Knight Tour Simulator";
        }

        private Record outputFile;//Global Variable
        
        private void btnRun_Click(object sender, EventArgs e)
        {
            //Collect information the user inputed.
            int startX = Convert.ToInt32(numericStartX.Value);
            int startY = Convert.ToInt32(numericStartY.Value);
            int noOfTrials = Convert.ToInt32(numericTrials.Value);
            int[] knightStartPosition = { startX, startY };
            string methodName = (rbNonIntelligent.Checked ? "NonIntelligent" : "Heuristics");

            //Create method class based on the chosen choice of user (methodName)
            Method method;
            if (rbNonIntelligent.Checked) method = new NonIntelligentMethod(knightStartPosition);
            else method = new HeuristicsMethod(knightStartPosition);

            //Create/append text file with user choices. Also, display in form.
            string startPositionStr = "The knight's started position is (x,y): (" + startX + ", " + startY + ")";
            string userChoiceStr = "You chose " + methodName + " method and want to run it " + noOfTrials + " time(s)";
            outputFile = new Record(methodName);
            DisplayNSave("******************************OUTPUT******************************");
            DisplayNSave("Simulation started at: " + DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm:ss"));
            DisplayNSave(startPositionStr);
            DisplayNSave(userChoiceStr);
            DisplayNSave("");

            //Create information message box about user choices.
            string message = startPositionStr + userChoiceStr;
            string title = "Your Choice!";
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            //Run simulations
            int totalMoves = 0;
            for (int index = 0; index < noOfTrials; index++)
            {
                method.Run();
                totalMoves += method.HistoryMoves.Count;

                DisplayNSave("Trial " + (index + 1) + ": The Knight was able to successfully" +
                    " touched " + method.HistoryMoves.Count + " squares");

                //Display the knight move sequence in ResultForm
                if (noOfTrials == 1 || index == noOfTrials - 1)
                {
                    method.SaveHistoryMoves();

                    ResultForm form2 = new ResultForm(method.HistoryMoves.Count, methodName, index + 1);
                    form2.HistoryMoves = method.ChartMovesHistory;
                    form2.Show();
                }

                method.Restart();//Reset the chessboard for the next simulation.
            }

            //Calculate, save and display the average move of total number of simulations.
            float averageMoves = totalMoves * 1.0f / noOfTrials;
            message = "The average moves touched by the knight after " +
                noOfTrials + " trial(s) is " + averageMoves + " squares";
            title = "Analytic Report";
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            DisplayNSave("");
            DisplayNSave(message);
        }

        //Display in form and also save to text file.
        private void DisplayNSave(string str)
        {
            outputFile.AddtoOutputFile(str);
            rtbDisplay.AppendText(str + "\n");
            rtbDisplay.ScrollToCaret();
        }
    }
}
