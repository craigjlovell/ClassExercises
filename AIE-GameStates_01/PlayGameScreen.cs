using System;
using System.Collections.Generic;
using System.Text;
using Raylib_cs;

namespace AIE_GameStates_01
{
    class PlayGameScreen : GameState
    {
        public int mouseClickCount = 0;
        float clickReset = 15.0f;
        float res = 15.0f;

        public PlayGameScreen(Program program) : base(program)
        {

        }

        public override void Update()
        {
            clickReset -= Raylib.GetFrameTime();
            res -= Raylib.GetFrameTime();

            if (Raylib.IsMouseButtonPressed(MouseButton.MOUSE_LEFT_BUTTON))
            {
                if (res <= 11 && res > 0)
                {
                    mouseClickCount += 1;
                }
                
            }
            if (clickReset <= -2)
            {

                program.scores.Add(new ScoreEntry("MouseClick", mouseClickCount));

                clickReset = 20.0f;
                program.ChangeGameState(new GameOverScreen(program));
            }
        }

        public override void Draw()
        {
            Raylib.DrawText("Play Game Screen", 10, 10, 20, Color.GRAY);
            Raylib.DrawText($"Click Count: {mouseClickCount}", 10, 30, 20, Color.GRAY);
            Raylib.DrawText($"Time Limit: {clickReset}", 10, 100, 20, Color.RED);
            Raylib.DrawText($"Start Clicking when timer gets to 10 secs", 10, 120, 20, Color.RED);
        }

    }
}
