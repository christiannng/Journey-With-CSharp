using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nguyen_VanHa_Assignment1
{
    sealed class NonIntelligentMethod : Method
    {
        public NonIntelligentMethod(int[] startPosition)
        {
            //Update the knight start position in parent (Method.cs)
            TheKnightStartPosition = startPosition;
            HistoryMoves.Add(startPosition);
        }

        public override void Run()
        {
            int[] position = TheKnightStartPosition;
            while (true)
            {
                //Get all possible moves
                ArrayList posibilities = FindPossibleMoves(position);

                //Move randomly and update the knight position if there are any possible moves
                //If not position is updated as empty
                position = MoveKnightRandomly(posibilities);

                if (IsThereNoMovesAvailable(position)) return;
            }//Stop if there is no more move available
        }

    }
}
