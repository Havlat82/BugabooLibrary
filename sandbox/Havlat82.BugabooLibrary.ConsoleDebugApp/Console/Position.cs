using System.Runtime.InteropServices;
using static System.Console;

namespace Havlat82.BugabooLibrary.ConsoleDebugApp.Console
{
    //todo popřemejšlet ještě o metodách, rozhraních pro implementaci, structlayoutu, lokalizaci
    //todo udělat z toho template pro structy (přidat info + best practices do regionů)
    public struct Position : IEquatable<Position>
    {
        public int Column;
        public int Row;

        public Position()
        {
            Column = Cursor.Column;
            Row = Cursor.Row;
        }

        public Position(int column, int row)
        {
            Column = column;
            Row = row;
        }

        public static int GetMemorySize()
        {
            return Marshal.SizeOf(typeof(Position));
        }

        #region Defaultní hodnoty

        public static Position Cursor = new Position(CursorLeft, CursorTop);
        public static Position StartOfCurrentLine = new Position(0, CursorTop);
        public static Position EndOfCurrentLine = new Position(WindowWidth, CursorTop);
        public static Position StartOfWindow = new Position(0, 0);
        public static Position EndOfWindow = new Position(WindowWidth, WindowHeight);

        public static bool IsStartOfCurrentLine(Position position)
        {
            return position == StartOfCurrentLine;
        }

        public bool IsEndOfCurrentLine(Position position)
        {
            return position == EndOfCurrentLine;
        }

        public bool IsStartOfWindow(Position position)
        {
            return position == StartOfWindow;
        }

        public bool IsEndOfWindow(Position position)
        {
            return position == EndOfWindow;
        }

        #endregion Defaultní hodnoty

        #region Parsery

        //todo implementovat parsování 
        public static bool TryParse(string positionAsString, out Position position)
        {
            position = Cursor;
            return true;
        }

        #endregion Parsery


        #region Operátory

        public static bool operator ==(Position left, Position right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(Position left, Position right)
        {
            return !(left == right);
        }

        #endregion Operátory

        #region Implementace rozhraní IEquatable<Position>

        public bool Equals(Position other)
        {
            return (Column, Row) == (other.Column, other.Row);
        }

        #endregion Implementace rozhraní IEquatable<Position>

        #region Override metody

        public override bool Equals(object other)
        {
            return other is Position p && Equals(p);
        }

        //todo zjistit nejlepší implementaci
        public override int GetHashCode()
        {
            return (Column, Row).GetHashCode();
        }

        public override string ToString()
        {
            return $"Pozice kurzoru [Sloupec: {Column}, Řádek: {Row}]";
        }

        #endregion Override metody
    }
}
