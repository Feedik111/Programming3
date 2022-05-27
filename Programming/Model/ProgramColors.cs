using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Programming.Model
{
    internal class ProgramColors
    {
        /// <summary>
        /// Цвет для корректного значения.
        /// </summary>
        public static Color CorrectColor = Color.FromArgb(255, 255, 255);

        /// <summary>
        /// Цвет для некоректного значения.
        /// </summary>
        public static Color ErrorColor = Color.FromArgb(255, 182, 193);

        /// <summary>
        /// Цвет для, пересекающихся фигур.
        /// </summary>
        public static Color IsCollision = Color.FromArgb(127, 255, 127, 127);

        /// <summary>
        /// Цвет для, не пересекающихся фигур.
        /// </summary>
        public static Color IsNotCollision = Color.FromArgb(127, 127, 255, 127);

        /// <summary>
        /// Цвет для весны.
        /// </summary>
        public static Color SpringColor = ColorTranslator.FromHtml("#559c45");

        /// <summary>
        /// Цвет для осени.
        /// </summary>
        public static Color AutumnColor = ColorTranslator.FromHtml("#e29c45");
    }
}
