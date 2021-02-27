using System;
using Raylib_cs;
using System.IO;
using System.Collections.Generic;

namespace AIE_GameStates_01
{
    class Program
    {

        int windowW = 800;
        int windowH = 450;
        string windowT = "GameStateManagement";

        GameState currentGameState;

        public string scoresFileName = "./scoresav.txt";
        public List<ScoreEntry> scores = new List<ScoreEntry>();


        static void Main(string[] args)
        {
            Program p = new Program();
            p.RunGame();

        }
        public void SerialiseScores()
        {
            // TODO
            var fileinfo = new FileInfo(scoresFileName);
            Directory.CreateDirectory(fileinfo.Directory.FullName);            

            using (StreamWriter sw = File.CreateText(scoresFileName))
            {
                foreach (var entry in scores)
                {
                    sw.WriteLine($"{entry.name} {entry.score}");
                }
            }
        }

        public void DeSerialiseScoreos()
        {

            if(!File.Exists(scoresFileName))
            {
                return;
            }

            // TODO get the scores from file
            // for now, lets populate with dummy data

            using (StreamReader sr = File.OpenText(scoresFileName))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    var lineItems = line.Split(" ");
                    string name = lineItems[0];
                    int.TryParse(lineItems[1], out int score);
                    var entry = new ScoreEntry(name, score);
                    scores.Add(entry);
                }
            }

           // scores.Add(new ScoreEntry("bob", 12));
            //scores.Add(new ScoreEntry("ted", 12));
            //scores.Add(new ScoreEntry("sam", 12));
        }

        void RunGame()
        {
            Raylib.InitWindow(windowW, windowH, windowT);
            Raylib.SetTargetFPS(100);

            LoadGame();

            while(!Raylib.WindowShouldClose())
            {
                Update();
                Draw();
            }

            Raylib.CloseWindow();
        }

        void LoadGame()
        {

            // Load Scores from file
            DeSerialiseScoreos();

            currentGameState = new SplashScreen(this);

        }

        void Update()
        {
            if (currentGameState != null)
                currentGameState.Update();
        }

        void Draw()
        {
            Raylib.BeginDrawing();
            Raylib.ClearBackground(Color.WHITE);

            if (currentGameState != null)
                currentGameState.Draw();

            Raylib.DrawFPS(10, windowH - 20);

            Raylib.EndDrawing();
        }

        public void ChangeGameState( GameState newGameState)
        {
            currentGameState = newGameState;
        }
    }
}
