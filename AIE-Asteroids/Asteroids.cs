﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;
using Raylib_cs;


namespace AIE_Asteroids
{
    class Asteroid : GameObject
    {


        public float radius = 50;


        public Asteroid(Program program, Vector2 pos, Vector2 dir) : base(program ,pos, dir)
        {
            
            this.dir = dir;

        }

        public override void Update()
        {

            pos += dir;

            if (pos.Y > program.windowH) pos.Y = 0;
            if (pos.Y < 0) pos.Y = program.windowH;
            if (pos.X > program.windowW) pos.X = 0;
            if (pos.X < 0) pos.X = program.windowW;

        }


        public override void Draw()
        {
            // goes in class Asteroid
            //Color color;

            //static Color[] colours = new Color[6] { Color.RED, Color.ORANGE, Color.YELLOW, Color.GREEN, Color.BLUE, Color.PURPLE };
            //static int nextColor = 0;

            // goes in public Asteroid()
            //color = colours[nextColor];
            //nextColor += 1;
            //if (nextColor >= colours.Length)
            //    nextColor = 0;

            // change Color.COLOR to color
            var image = Assets.rock;
            Raylib.DrawTexturePro(
                image,
                new Rectangle(0, 0, image.width, image.height),
                new Rectangle(pos.X, pos.Y, radius, radius),
                new Vector2(radius, radius),
                GetRotation(),
                Color.GRAY);
           // Raylib.DrawCircleLines((int)pos.X, (int)pos.Y, radius, Color.WHITE);
        }

    }
}
