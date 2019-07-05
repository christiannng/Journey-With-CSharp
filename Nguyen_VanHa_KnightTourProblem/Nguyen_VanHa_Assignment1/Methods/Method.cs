using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nguyen_VanHa_Assignment1
{
    abstract class Method: ChessBoard
    {
        private Random random = new Random();
        public int[] TheKnightStartPosition { get; set; }

        //Overriden by children classes (HeuristicsMethod.cs and NonIntelligent.cs)
        public abstract void Run();
        
        protected int[] MoveKnightRandomly(ArrayList posibilities)
        {
            int[] empty = new int[0];

            if (posibilities.Count == 0) return empty;

            int index = random.Next(0, posibilities.Count);
            int[] nextPosition = (int[])posibilities[index];

            HistoryMoves.Add(nextPosition);

            return nextPosition;
        }
        
        /// <summary>
        /// Check whether the given position is empty or not
        /// </summary>
        /// <param name="position"></param>
        /// <returns></returns>
        protected bool IsThereNoMovesAvailable(int[] position)
        {
            return position.Length == 0;
        }

        /// <summary>
        /// Save history moves to history chart (both in ChessBoardProperties.cs)
        /// ONLY USED for the last simulation.
        /// </summary>
        public void SaveHistoryMoves()
        {
            foreach (int[] position in HistoryMoves)
                AddMoveToHistoryChart(position);
        }

        /// <summary>
        /// Restart the chessboard for the next simulation
        /// </summary>
        public void Restart()
        {
            HistoryMoves.Clear();
            HistoryMoves.Add(TheKnightStartPosition);
        }
    }
}
