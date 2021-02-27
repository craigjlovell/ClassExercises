using Raylib_cs;
using System;
using System.Collections.Generic;
using System.Text;

namespace AIE_Asteroids
{
    class Assets
    {

        public static Texture2D shipTexture;
        public static Texture2D rock;

        public static void LoadAssets()
        {
            shipTexture = Raylib.LoadTexture("./assets/ss.png");
            rock = Raylib.LoadTexture("./assets/rock_large.png");
        }

    }
}
