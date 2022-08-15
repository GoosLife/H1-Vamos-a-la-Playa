using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_Vamos_a_la_Playa
{
    internal class Beach
    {
        private DeckChair[,] chairs;

        public DeckChair[,] Chairs
        {
            get { return chairs; }
            private set { chairs = value; }
        }

        private int rows;
        public int Rows
        {
            get { return rows; }
            private set { rows = value; }
        }

        private int columns;
        public int Columns
        {
            get { return columns; }
            private set { columns = value; }
        }


        // Instantiate beach using deckchairs
        public Beach(DeckChair[,] chairs)
        {
            Rows = chairs.GetLength(0);
            Columns = chairs.GetLength(1);

            Chairs = chairs;
        }

        // Instantiate beach with 2D int array
        public Beach(int[,] chairs)
        {
            Rows = chairs.GetLength(0);
            Columns = chairs.GetLength(1);

            Chairs = new DeckChair[chairs.GetLength(0), chairs.GetLength(1)];

            for (int i = 0; i < chairs.GetLength(0); i++)
            {
                for (int j = 0; j < chairs.GetLength(1); j++)
                {
                    if (chairs[i,j] == 1)
                    {
                        Chairs[i, j] = new DeckChair(State.Taken);
                    }
                    else
                    {
                        Chairs[i, j] = new DeckChair(State.Empty);
                    }
                }
            }
        }
        public override string ToString()
        {
            string output = "";

            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    switch (Chairs[i, j].State)
                    {
                        case State.Empty:
                            output += "0 ";
                            break;
                        case State.Taken:
                            output += "1 ";
                            break;
                        case State.Reserved:
                            output += "2 ";
                            break;
                    }
                }

                output += '\n';
            }

            return output;
        }
    }
}
