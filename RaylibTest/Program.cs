﻿using System;
using Raylib_cs;

namespace RaylibTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Raylib.InitWindow(800, 480, "Hello World");

            while (!Raylib.WindowShouldClose())
            {
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.WHITE);

                Raylib.DrawText("Hello, world!", 12, 12, 20, Color.BLACK);
                Raylib.EndDrawing();
            }

            Raylib.CloseWindow();
        }
    }
}
