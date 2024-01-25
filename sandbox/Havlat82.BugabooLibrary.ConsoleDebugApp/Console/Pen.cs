namespace Havlat82.BugabooLibrary.ConsoleDebugApp.Console
{

    //todo Write(textAligment, text)
    //todo Write(textAligment, rgbColorCombination, text)
    //todo Write(col, row, rgbColorCombination, text)
    //todo Write(textAligment, consoleColorCombination, text)
    //todo Write(col, row, consoleColorCombination, text)

    /// <summary>
    /// Contains various overloads of Write and WriteLine methods
    /// </summary>
    public static class Pen
    {
        /// <summary>
        /// Prints a string to the console
        /// </summary>
        /// <param name="text">the character string to print</param>
        public static void Write(string text)
        {
            System.Console.Write(text);
        }

        /// <summary>
        /// Prints a string to the console
        /// </summary>
        /// <param name="column">the column to place the cursor on. measured from left</param>
        /// <param name="row">the row to place the cursor on. measured from top</param>
        /// <param name="text">the character string to print</param>
        public static void Write(int column, int row, string text)
        {
            System.Console.SetCursorPosition(column, row);
            Write(text);
        }

        public static void Write(Alignment alignment, string text)
        {
            switch (alignment)
            {
                case Alignment.ToCenter:
                    CenterText(text);
                    break;
                case Alignment.ToLeft:
                    LeftText(text);
                    break;
                case Alignment.ToRight:
                    RightText(text);
                    break;
            }

            System.Console.Write(text);
        }

        private static void RightText(string text)
        {
            var tl = text.Length;
            var ww = System.Console.WindowWidth;
            var columnRightText = ww - tl;
            System.Console.SetCursorPosition(columnRightText, System.Console.CursorTop + 1);
        }

        private static void LeftText(string text)
        {
            System.Console.SetCursorPosition(1, System.Console.CursorTop + 1);
        }

        private static void CenterText(string text)
        {
            var tl = text.Length;
            var ww = System.Console.WindowWidth;
            var columnCenteredText = (ww + tl) / 2;
            System.Console.SetCursorPosition(columnCenteredText, System.Console.CursorTop + 1);
        }

    }
}
