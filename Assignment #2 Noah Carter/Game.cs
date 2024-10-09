// Include code libraries you need below (use the namespace).
using System;
using System.Numerics;
using System.Threading;

// The namespace your code is in.
namespace Game10003
{
    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    public class Game
    {
        // Place your variables here:


        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetSize(800, 600);
            DrawDots();
            DrawSun();
            
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            DrawSun();

        }
        // Functions
        void DrawDots()
        {
            Vector2[] dots = new Vector2[2000];

            for (int i = 0;i<2000; i++)
            {
                dots[i] = Random.Vector2(1400, 1200);
                Draw.FillColor =Color.White;
                Draw.Circle(dots[i], 1);

            }
        }
        void DrawSun()
        {



            if (Input.IsKeyboardKeyDown(KeyboardInput.Space))
            {

                Draw.FillColor = Color.Red;
            }
            else if (Input.IsKeyboardKeyDown(KeyboardInput.LeftShift))
            {
                Draw.FillColor = Color.White;
            }

            else
            {
                
                Draw.FillColor = Color.Yellow;
            }
            //Draw.FillColor = Color.White;
            Draw.LineColor = Color.White;
            Draw.Circle(400,300,25);
        }
        void WindowMovement()
        {

        }
    }
}
