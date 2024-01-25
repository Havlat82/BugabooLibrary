namespace Havlat82.BugabooLibrary.ConsoleDebugApp.Console
{
    public readonly struct ColorCombination : IEquatable<ColorCombination>
    {
        public ColorCombination(ConsoleColor foreColor, ConsoleColor backColor)
        {
            ForeColor = foreColor;
            BackColor = backColor;
        }

        public ColorCombination(string description)
        {
            var parsedDescription = ParseDescription(description);
            SetForeColor(parsedDescription["ForeColor"]);
            SetBackColor(parsedDescription["BackColor"]);
        }

        private void SetBackColor(ConsoleColor color)
        {
            throw new NotImplementedException();
        }

        private void SetForeColor(ConsoleColor color)
        {
            throw new NotImplementedException();
        }

        private Dictionary<string, ConsoleColor> ParseDescription(string description)
        {
            var d = new Dictionary<string, ConsoleColor>();
            var u = new string[2];
            u = description.Split("On");
            var consoleColors = new List<ConsoleColor>();
            for (byte i = (byte)ConsoleColor.Black; i < (byte)ConsoleColor.White; i++)
            {
                consoleColors.Add((ConsoleColor)i);
            }

            var foreColorDescription = u[0];
            var backColorDescription = u[1];


            var dc = consoleColors.Where(x => x.ToString() == foreColorDescription).FirstOrDefault();
            d.Add("ForeColor", dc);

            foreach (var item in consoleColors)
            {
                if (item.ToString() == backColorDescription)
                {
                    d.Add("BackColor", item);
                    continue;
                }
            }


            return d;
        }

        public ConsoleColor ForeColor { get; }
        public ConsoleColor BackColor { get; }

        public bool Equals(ColorCombination other)
        {
            throw new NotImplementedException();
        }
    }
}
