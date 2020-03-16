using System;
using System.Collections.Generic;
using System.Text;

namespace RundenRollen
{
    public static class Randomizer
    {
        static Random Random = new Random();

        /// <summary>
        /// Gibt eine Zufallszahl zwischen 0 und 20 zurück.
        /// </summary>
        /// <returns></returns>
        public static int GetWZwanzig()
        {
            byte[] bytes = new byte[1];
            Random.NextBytes(bytes);
            return ((bytes[0] * 19 / 255) + 1);
        }

        /// <summary>
        /// Gibt eine Zufallszahl zwischen 0  und 2 zurück.
        /// </summary>
        /// <returns></returns>
        public static int GetWZwei()
        {
            byte[] bytes = new byte[1];
            Random.NextBytes(bytes);
            return ((bytes[0] * 2 / 255));
        }

        /// <summary>
        /// Gibt eine Zufallszahl zwischen 0 und x zurück.
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static int GetWX(int x)
        {
            byte[] bytes = new byte[1];
            Random.NextBytes(bytes);
            return ((bytes[0] * x / 255) + 1);
        }

    }
}
