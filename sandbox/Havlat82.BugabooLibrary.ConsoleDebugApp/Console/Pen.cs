namespace Havlat82.BugabooLibrary.ConsoleDebugApp.Console
{
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
    }
}
