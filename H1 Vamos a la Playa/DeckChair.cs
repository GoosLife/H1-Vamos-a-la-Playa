using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_Vamos_a_la_Playa
{
    /// <summary>
    /// Denotes whether a deck chair is empty (has no current user), taken (has a current user), or reserved (is empty, but has already been reserved)
    /// </summary>
    public enum State
    {
        Empty,
        Taken,
        Reserved
    }
    internal class DeckChair
    {

        private State state;
        // Private setter, because isTaken is only really supposed to be set to false initially. Use reserve to fill an empty chair.
        public State State
        {
            get { return state; }
            private set { state = value; }
        }
        public DeckChair(State setChairTaken)
        {
            State = setChairTaken;
        }

        public DeckChair(int setChairTaken)
        {
            State = (State)setChairTaken;
        }

        /// <summary>
        /// Reserve the chair, making it taken
        /// </summary>
        public void Reserve()
        {
            if (State == State.Empty)
            {
                state = State.Reserved;
            }
            else
            {
                throw new Exception("Tried to reserve taken chair");
            }
        }
    }
}
