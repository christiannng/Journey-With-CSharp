using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nguyen_VanHa_Assignment1
{
    partial class ChessBoard
    {
        private int moveIndex = 0;//Increase when the knight move

        private int[,] accessibilityChart = new int[,]
        { { 2,3,4,4,4,4,3,2 },
          { 3,4,6,6,6,6,4,3 },
          { 4,6,8,8,8,8,6,4 },
          { 4,6,8,8,8,8,6,4 },
          { 4,6,8,8,8,8,6,4 },
          { 4,6,8,8,8,8,6,4 },
          { 3,4,6,6,6,6,4,3 },
          { 2,3,4,4,4,4,3,2 }};

        //Only use for the last simulation or when user runs 1 simulation
        private int[,] chartMovesHistory = new int[,]
        { { 0,0,0,0,0,0,0,0 },
          { 0,0,0,0,0,0,0,0 },
          { 0,0,0,0,0,0,0,0 },
          { 0,0,0,0,0,0,0,0 },
          { 0,0,0,0,0,0,0,0 },
          { 0,0,0,0,0,0,0,0 },
          { 0,0,0,0,0,0,0,0 },
          { 0,0,0,0,0,0,0,0 }};

    
        public int[,] ChartMovesHistory
        {
            get { return chartMovesHistory; }
        }

        private ArrayList historyMoves = new ArrayList();
        //Keep all moves the knight made.
        public ArrayList HistoryMoves
        {
            get { return historyMoves; }
            set
            {
                historyMoves.Add(value);
            }
        }
    }
}
