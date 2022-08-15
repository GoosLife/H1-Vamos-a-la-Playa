using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_Vamos_a_la_Playa
{
    internal class BeachManager
    {
        private Beach beach;

        public Beach Beach
        {
            get { return beach; }
            private set { beach = value; }
        }

        // Use a pre-constructed beach
        public BeachManager(Beach beach)
        {
            Beach = beach;
        }

        // Construct a random beach
        public BeachManager()
        {
            Beach = ConstructBeach(6, 9);
        }

        public Beach ConstructBeach(int rows, int cols)
        {
            // Array to store deck chairs used to construct beach
            DeckChair[,] chairs = new DeckChair[rows, cols];

            // Generate a random number to decide whether a chair is taken or not
            Random r = new Random();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    // Generate a random chair that may or may not be taken
                    DeckChair c = new DeckChair(r.Next(0, 2));
                    chairs[i, j] = c;
                }
            }

            // Create the beach and return
            Beach b = new Beach(chairs);
            return b;
        }

        public int AvailableChairs()
        {
            // Number of available chairs
            int availableChairs = 0;

            for (int i = 0; i < Beach.Chairs.GetLength(0); i++)
            {
                // Check the first chair in a row - if the chair next to it is empty, it can be reserved
                if (Beach.Chairs[i, 0].State == State.Empty && Beach.Chairs[i, 1].State == State.Empty)
                {
                    Beach.Chairs[i, 0].Reserve();
                    availableChairs++;
                }

                //  Checks whether all chairs, except for the very edges of each row, can be available based on whether the chair to the immediate right & left are empty.
                for (int j = 1; j < Beach.Chairs.GetLength(1) - 1; j++)
                {

                    if (Beach.Chairs[i,j].State == State.Empty &&
                        Beach.Chairs[i,j - 1].State == State.Empty &&
                        Beach.Chairs[i,j + 1].State == State.Empty)
                    {
                        Beach.Chairs[i, j].Reserve(); // Reserve the chair, effectively marking it as taken, to make sure we don't over-book
                        availableChairs++;
                    }
                }

                // Check the last chair in a row - similarly to the first chair, only the immediate partner on a side must be empty for it to be reservable.
                if (Beach.Chairs[i, Beach.Rows - 1].State == State.Empty && Beach.Chairs[i, Beach.Rows - 2].State == State.Empty)
                {
                    Beach.Chairs[i, Beach.Rows - 1].Reserve();
                    availableChairs++;
                }
            }

            return availableChairs;
        }
    }
}
