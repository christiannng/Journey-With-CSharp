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
    public partial class ResultForm : Form
    {
        private int touchedSquare;
        private int trialNo;
        public ResultForm(int touchedSquare, string methodName, int trialNo)
        {
            InitializeComponent();
            this.Text = methodName + " Method: History Moves!";
            this.touchedSquare = touchedSquare;
            this.trialNo = trialNo;
        }

        public int[,] HistoryMoves { private get; set; }

        private void ResultForm_Load(object sender, EventArgs e)
        {
            //Set up form
            SetTemplateForGridView();
            labelInfo.Text = "The Knight was able to successfully touched " + touchedSquare + " squares";
            labelTrial.Text = "Trial " + trialNo + ": ";

            //Populate the sequence of moves that the knight made into grid view.
            for (int row = 0; row < 8; row++)
            {
                for (int col = 0; col < 8; col++)
                {
                    int currentMove = HistoryMoves[row, col];

                    if(currentMove != 0)
                    {
                        dgvDisplay.Rows[row].Cells[col].Value = currentMove;

                        //Change the first move and the last move to green 
                        //So that user could see easily.
                        if (currentMove == touchedSquare || currentMove == 1)
                            dgvDisplay.Rows[row].Cells[col].Style.BackColor = Color.Green;
                    }
                }
            }
        }

        private void SetTemplateForGridView()
        {
            //Change styles of column headers
            dgvDisplay.EnableHeadersVisualStyles = false;
            dgvDisplay.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvDisplay.ColumnHeadersDefaultCellStyle.BackColor = Color.Yellow;
            dgvDisplay.ColumnHeadersHeight = 35;

            //Change styles of rows header and row
            dgvDisplay.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDisplay.DefaultCellStyle.SelectionBackColor = dgvDisplay.DefaultCellStyle.BackColor;
            dgvDisplay.DefaultCellStyle.SelectionForeColor = dgvDisplay.DefaultCellStyle.ForeColor;

            for (int index = 0; index < 7; index++) dgvDisplay.Rows.Add();//Add rows

            //Change styles of each rows and columns 
            for (int index = 0; index < 8; index++)
            {
                dgvDisplay.Columns[index].Width = 35;
                dgvDisplay.Columns[index].Resizable = DataGridViewTriState.False;
                
                dgvDisplay.Rows[index].Height = 35;
                dgvDisplay.Rows[index].Resizable = DataGridViewTriState.False;
                dgvDisplay.Rows[index].HeaderCell.Value = String.Format("{0}", index + 1);
                dgvDisplay.Rows[index].HeaderCell.Style.BackColor = Color.Yellow;
            }
        }

        //Close the current form and go back to the first form.
        private void btnTryAgain_Click(object sender, EventArgs e)
        {
            IndexForm.ActiveForm.Visible = true;
            this.Close();
        }
    }
}
