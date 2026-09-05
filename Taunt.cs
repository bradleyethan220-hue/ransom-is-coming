using System;
using System.Drawing;

namespace CursedPopupGame
{
    public static class Taunt
    {
        private static readonly Random rnd = new Random();

        private static readonly string[] insults =
        {
            "YOU ARE AN IDIOT HAHA",
            "CAN'T EVEN CLICK FAST",
            "ERROR: SKILL NOT FOUND",
            "YOU ARE A BUG IN THE SYSTEM",
            "YOU ARE A FAILURE MODULE",
            "YOU ARE A CORRUPTED USER",
            "SYSTEM WARNING: YOU SUCK",
            "YOU ARE NOT EVEN TRYING",
            "PATH NOT FOUND: YOUR BRAIN",
            "YOU ARE A GLITCH IN REALITY"
        };

        public static string GetRandomInsult()
        {
            return insults[rnd.Next(insults.Length)];
        }

        public static Bitmap GetFaceBitmap()
        {
            return new Icon("Icons/main.ico").ToBitmap();
        }
    }
}
