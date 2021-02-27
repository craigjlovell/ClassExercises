using System;
using System.Collections.Generic;
using System.Text;

namespace AIE_GameStates_01
{
    class GameState
    {

        protected Program program;

        public GameState(Program program)
        {
            this.program = program;
        }

        public virtual void Update()
        {
            //left blank
        }

        public virtual void Draw()
        {
            //left blank
        }

    }
}
