using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
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
        public int RectSize { get; set; }
        public Vector2 MazeCorner { get; set; }    
        public Grid(int[,] gridMap, Texture2D blackRect, Texture2D blueRect,int rectSize,Vector2 mazeCorner)
        {
            GridMap = gridMap;
            BlackRect = blackRect;
            BlueRect = blueRect;
            RectSize = rectSize;
            MazeCorner= mazeCorner;
        }

        public void DrawMap(SpriteBatch spriteBatch)
        {
            spriteBatch.Begin();
            for (int y = 0; y < GridMap.GetLength(1); y++)
            {
                for (int x = 0; x < GridMap.GetLength(0); x++)
                {                   
                        spriteBatch.Draw(
                      (GridMap[x, y] == Wall) ?BlackRect:BlueRect,
                      new Rectangle((int) (MazeCorner.X+ y * RectSize), (int) (MazeCorner.Y + x * RectSize), RectSize, RectSize),
                      Color.White);                    
                }
            }
            spriteBatch.End();
        }
    }
}
