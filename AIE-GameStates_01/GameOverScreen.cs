using System;
using System.Collections.Generic;
using System.Text;
using Raylib_cs;

namespace AIE_GameStates_01
{
    class GameOverScreen : GameState
    {


        public GameOverScreen(Program program) : base(program)
        {

        }

        public override void Update()
        {
            if( Raylib.IsKeyPressed(KeyboardKey.KEY_SPACE))
            {
                program.SerialiseScores();
                program.ChangeGameState(new MenuScreen(program));
            }
        }

        public override void Draw()
        {


            // TODO: loop through each of the scores
            // and display each score underneight the other
            for (int i = 0; i < program.scores.Count; i++)
            {
                Raylib.DrawText($"{program.scores[i].name} - {program.scores[i].score}", 100, i * 30 + 100, 20, Color.GRAY);
                int Av = program.scores[i].score + program.scores[i].score / program.scores.Count;
                Raylib.DrawText(Av.ToString(), 30, i * 30 + 100, 20, Color.DARKBLUE);
            }



            Raylib.DrawText($"GameOverScreen", 10, 10, 20, Color.RED);
            Raylib.DrawText($"Press Space to go to menu", 10, 30, 20, Color.RED);
        }
        

    }
}
