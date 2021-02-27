using System;
using System.Collections.Generic;
using System.IO;

namespace AIE_33_HighScores
{

    class ScoreEntry
    {
        public string name;
        public int score;


        public ScoreEntry(string name, int score)
        {
            this.name = name;
            this.score = score;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<ScoreEntry> scores = new List<ScoreEntry>()
            {
                new ScoreEntry("bob", 12),
                new ScoreEntry("fred", 20),
                new ScoreEntry("ted", 6),
                new ScoreEntry("tom", 42),
                new ScoreEntry("harry", 9),
            };

            // save the scores
            SerialiseScores("highscores.txt", scores);

            // clear the scores
            scores = new List<ScoreEntry>();

            // read the scores
            DeSerialiseScoreos("highscores.txt", scores);

            // print scores
            foreach (var entry in scores)
            {
                Console.Write($"{entry.name}:{entry.score}");
            }

        }

        static void SerialiseScores(string filename, List<ScoreEntry> scores)
        {
            // TODO: write code to write the scores to file
            FileInfo fileInfo = new FileInfo(filename);
            Directory.CreateDirectory(fileInfo.Directory.FullName);

            using (StreamWriter sw = File.CreateText(filename))
            {
                foreach (var entry in scores)
                {
                    sw.WriteLine($"{entry.name} {entry.score}");
                }
            }

        }

        static void DeSerialiseScoreos(string filename, List<ScoreEntry> scores)
        {

            // TODO: write code to read the scores from file
            using (StreamReader sr = File.OpenText(filename))
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
        }
    }

}