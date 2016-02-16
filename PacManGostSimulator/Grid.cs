using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;

namespace PacManGostSimulator
{
    public class Grid
    {
        public static int Wall = 1;  //later add consder teh corners and the straight line walls 
        public static int Space = 0;

        public int[,] GridMap { get; set; }
        public Texture2D BlackRect { get; set; }
        public Texture2D BlueRect { get; set; } 
        public Grid(int[,] gridMap,Texture2D blackRect,Texture2D blueRect)
        {
            GridMap = gridMap;
            BlackRect = blackRect;
            BlueRect = blueRect;
        }
         
        public void DrawMap(SpriteBatch spriteBatch)    
        {
            spriteBatch.Begin();

            spriteBatch.End();            
        }
    }
}
