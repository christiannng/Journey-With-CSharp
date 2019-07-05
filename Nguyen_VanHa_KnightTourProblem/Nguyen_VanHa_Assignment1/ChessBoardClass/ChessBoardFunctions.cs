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
        /// <summary>
        /// Add move to a specific location in the chessboard.
        /// Ex: Add move number 3 to location (2,2) of the chessboard.
        /// </summary>
        /// <param name="position">position the knight moved to</param>
        protected void AddMoveToHistoryChart(int[] position)
        {
            int x = position[0];
            int y = position[1];
            moveIndex++;

            chartMovesHistory[x, y] = moveIndex;
        }

        /// <summary>
        /// Filter to get the possible moves with the lowest accessibility number.
        /// </summary>
        /// <param name="posibilities">All possible moves</param>
        /// <returns>The possible moves with the lowest accessibility number</returns>
        protected ArrayList FindTheHardestAccessibleSquares(ArrayList posibilities)
        {
            ArrayList theHardestSquaresToAccess = new ArrayList();
            ArrayList accessibilitiesOfSquares = new ArrayList();
            int theLeastAccessibilityNo = 8;

            for (int index = 0; index < posibilities.Count; index++)
            {
                int[] currentSquare = (int[])posibilities[index];
                accessibilitiesOfSquares.Add(GetAccessibilityNo(currentSquare));

                if ((int)accessibilitiesOfSquares[index] < theLeastAccessibilityNo)
                    theLeastAccessibilityNo = (int)accessibilitiesOfSquares[index];
            }

            for (int index = 0; index < posibilities.Count; index++)
            {
                if ((int)accessibilitiesOfSquares[index] == theLeastAccessibilityNo)
                    theHardestSquaresToAccess.Add(posibilities[index]);
            }

            return theHardestSquaresToAccess;
        }

        /// <summary>
        /// Get accessibility number of a given position
        /// </summary>
        /// <param name="position"></param>
        /// <returns>The accessibility number of the given position</returns>
        private int GetAccessibilityNo(int[] position)
        {
            int x = position[0], y = position[1];
            return accessibilityChart[x, y];
        }
        
        protected ArrayList FindPossibleMoves(int[] position)
        {
            int x = position[0], y = position[1];
            ArrayList posibilities = new ArrayList();

            if (IsPositionSatified(x + 1, y + 2)) posibilities.Add(new int[] { x + 1, y + 2 });
            if (IsPositionSatified(x + 1, y - 2)) posibilities.Add(new int[] { x + 1, y - 2 });
            if (IsPositionSatified(x - 1, y + 2)) posibilities.Add(new int[] { x - 1, y + 2 });
            if (IsPositionSatified(x - 1, y - 2)) posibilities.Add(new int[] { x - 1, y - 2 });
            if (IsPositionSatified(x + 2, y + 1)) posibilities.Add(new int[] { x + 2, y + 1 });
            if (IsPositionSatified(x + 2, y - 1)) posibilities.Add(new int[] { x + 2, y - 1 });
            if (IsPositionSatified(x - 2, y + 1)) posibilities.Add(new int[] { x - 2, y + 1 });
            if (IsPositionSatified(x - 2, y - 1)) posibilities.Add(new int[] { x - 2, y - 1 });

            return posibilities;
        }

        /// <summary>
        /// Whether the knight has ever moved to the given position or not and
        /// whether the given position is on the chessboard
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        private bool IsPositionSatified(int x, int y)
        {
            bool isInChessBoard = (x >= 0 && x <= 7 && y >= 0 && y <= 7);
            if (!isInChessBoard) return false;
            else
            {
                foreach(int[] oldMove in HistoryMoves)
                    if (oldMove[0] == x && oldMove[1] == y) return false;

                return true;
            }
        }
    }
}
