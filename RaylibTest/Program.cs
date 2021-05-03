using System;
using System.Diagnostics;
using Raylib_cs;

namespace RaylibTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Raylib.SetConfigFlags(ConfigFlag.FLAG_VSYNC_HINT);
            Raylib.SetConfigFlags(ConfigFlag.FLAG_MSAA_4X_HINT);
            Raylib.SetConfigFlags(ConfigFlag.FLAG_WINDOW_RESIZABLE);
            Raylib.InitWindow(800, 640, "Hello World");

            int width = 0;
            int height = 0;

            Camera2D camera;
            camera = new Camera2D();
            camera.target = new System.Numerics.Vector2(800, 480);
            camera.offset = new System.Numerics.Vector2(0, 0);
            camera.rotation = 0.0f;
            camera.zoom = 1.0f;

            RenderTexture2D target = Raylib.LoadRenderTexture(800, 480);
            NPatchInfo nPatchInfo = new NPatchInfo();

            while (!Raylib.WindowShouldClose())
            {
                width = Raylib.GetScreenWidth();
                height = Raylib.GetScreenHeight();                

                nPatchInfo.top = 0;
                nPatchInfo.bottom = target.texture.height;
                nPatchInfo.left = 0;
                nPatchInfo.right = target.texture.width;

                Raylib.BeginDrawing();

                Raylib.BeginTextureMode(target);
                Raylib.ClearBackground(Color.WHITE);
                Raylib.DrawFPS(0, 0);
                Raylib.DrawText("Hello, world!", 650, 12, 20, Color.BLACK);
                Raylib.EndTextureMode();

                Raylib.ClearBackground(Color.WHITE);
                //Raylib.BeginMode2D(camera);
                //Raylib.DrawTexture(target.texture, 0, 0, Color.WHITE);
                //Raylib.EndMode2D();

                //Raylib.DrawTexture(target.texture, 0, 0, Color.WHITE);
                Raylib.DrawTexturePro(target.texture, new Rectangle(0, 0, 800, -480), new Rectangle(0, 0, width, height), new System.Numerics.Vector2(0, 0), 0.0f, Color.WHITE);

                Raylib.EndDrawing();
            }

            Raylib.CloseWindow();
        }
    }
}
