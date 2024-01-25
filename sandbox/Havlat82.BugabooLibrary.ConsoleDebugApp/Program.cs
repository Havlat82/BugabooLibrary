using Havlat82.BugabooLibrary.ConsoleDebugApp.Console;

namespace Havlat82.BugabooLibrary.ConsoleDebugApp
{
    internal static class Program
    {

        //? informace o třídě System.Console na webu:
        // https://learn.microsoft.com/en-us/dotnet/api/system.console?view=net-7.0
        // https://www.geeksforgeeks.org/console-class-in-c-sharp/
        // https://dotnettutorials.net/lesson/console-class-methods-properties-csharp/
        // https://code-maze.com/csharp-console/
        // https://github.com/microsoft/referencesource/blob/master/mscorlib/system/console.cs

        private static void Main()
        {
            var i = 0;
            //System.Console.SetCursorPosition(10, 5);
            //System.Console.ForegroundColor = ConsoleColor.Yellow;
            //System.Console.Write(FiggleFonts.Avatar.Render("Super!"));
            //System.Console.WriteLine("Ahoj".Pastel(Color.GreenYellow));
            //var x = typeof(Color).GetProperties().ToList();
            ////foreach (var prop in x)
            ////{
            ////    var a = prop.GetValue()
            ////}
            //var y = x[10];
            //var z = (Color)y.GetValue(y.Name);
            //var a = z.Name;
            //var b = z.ToArgb();
            //var c = z.A;

            //var e = z.R;
            //var f = z.G;
            //var d = z.B;
            //var g = z.GetHue();
            //var h = z.GetSaturation();
            //var i = z.GetBrightness();
            //var j = Color.FromArgb(10, z);

            //Pen.Write("s");
            //SeznamPropertiesConsole();

            Pen.Write($"{Position.GetMemorySize()}");
            Position positionA = new Position();
            Position positionB = new Position(15, 16);
            var x = positionA == positionB;
            var y = positionA.Equals(i);

        }

        private static void SeznamMetodConsole()
        {
            //? Metody System.Console
            //todo Metody pro barvy konzole
            //System.Console.ResetColor();

            //todo Metody pro kurzor konzole
            //var position = System.Console.GetCursorPosition();
            //System.Console.SetCursorPosition();

            //todo Metody pro výpis z konzole
            //System.Console.WriteLine(); // 18 overloadů
            //System.Console.Write(""); // 17 overloadů

            //todo Metody pro čtení do konzole
            //var intCh = System.Console.Read();
            //var consoleKeyInfo = System.Console.ReadKey(); // 2 overloady
            //var line = System.Console.ReadLine();

            //todo Metody pro chybový stream konzole
            //System.Console.SetError();
            //var errStr = System.Console.OpenStandardError(); // 2 overloady

            //todo Metody pro vstupní stream konzole
            //System.Console.SetIn();
            //var inputStr = System.Console.OpenStandardInput(); // 2 overloady

            //todo Metody pro výstupní stream konzole
            //System.Console.SetOut();
            //var outputStr = System.Console.OpenStandardOutput(); // 2 overloady

            //todo Metody pro buffer konzole
            //System.Console.SetBufferSize();
            //System.Console.MoveBufferArea(); // 2 overloady

            //todo Metody pro okno konzole
            //System.Console.Clear();
            //System.Console.SetWindowPosition();
            //System.Console.SetWindowSize();

            //todo Metody pro zvuk konzole
            //System.Console.Beep(); // 2 overloady
        }

        private static void SeznamPropertiesConsole()
        {
            //? Properties System.Console
            //todo barvy konzole
            var fc = System.Console.ForegroundColor;
            var bc = System.Console.BackgroundColor;

            //todo kurzor konzole
            var l = System.Console.CursorLeft;
            var t = System.Console.CursorTop;
            var s = System.Console.CursorSize;
            //! var v = System.Console.CursorVisible; // podporuje pouze platforma Windows

            //todo vstupní stream konzole
            var i = System.Console.In;
            var ie = System.Console.InputEncoding;
            var ir = System.Console.IsInputRedirected;

            //todo výstupní stream konzole
            var o = System.Console.Out;
            var oe = System.Console.OutputEncoding;
            var or = System.Console.IsOutputRedirected;

            //todo chybový stream konzole
            var e = System.Console.Error;
            var er = System.Console.IsErrorRedirected;

            //todo vlastnosti konzole pro vstup z klávesnice
            var ka = System.Console.KeyAvailable;
            var treatCtrlC = System.Console.TreatControlCAsInput;
            //! var cl = System.Console.CapsLock; // podporuje pouze platforma Windows
            //! var nl = System.Console.NumberLock; // podporuje pouze platforma Windows

            //todo buffer konzole
            var bw = System.Console.BufferWidth;
            var bh = System.Console.BufferHeight;

            //todo okno konzole
            var wl = System.Console.WindowLeft;
            var wt = System.Console.WindowTop;
            var ww = System.Console.WindowWidth;
            var wh = System.Console.WindowHeight;
            var lww = System.Console.LargestWindowWidth;
            var lwh = System.Console.LargestWindowHeight;
            //! var tt = System.Console.Title; // podporuje pouze platforma Windows
        }

        private static void SeznamEventuConsole()
        {
            //? Eventy System.Console
            System.Console.CancelKeyPress += Console_CancelKeyPress;
        }

        private static void Console_CancelKeyPress(object sender, ConsoleCancelEventArgs e)
        {
            System.Console.WriteLine($"ruší se process: {e.Cancel}, stisklá kombinace kláves: {e.SpecialKey}");
        }

        private static void SeznamWriteLineMetod()
        {
            //System.Console.WriteLine(); // 18 overloadů
            //System.Console.WriteLine(boolValue);
            //System.Console.WriteLine(unicodeChar);
            //System.Console.WriteLine(unicodeCharArray);
            //System.Console.WriteLine(decimalValue);
            //System.Console.WriteLine(doubleValue);
            //System.Console.WriteLine(floatValue);
            //System.Console.WriteLine(intValue);
            //System.Console.WriteLine(longValue);
            //System.Console.WriteLine(objectValue);
            //System.Console.WriteLine(stringValue);
            //System.Console.WriteLine(uintValue);
            //System.Console.WriteLine(ulongValue);
            //System.Console.WriteLine(stringFormat, objectValue);
            //System.Console.WriteLine(stringFormat, objectArray);
            //System.Console.WriteLine(charArray, intIndex, intCount);
            //System.Console.WriteLine(stringFormat, firstObjectValue, secondObjectValue);
            //System.Console.WriteLine(stringFormat, firstObject, secondObject, thirdObject);

            //? pro System.Console.Write jsou overloady stejný jako pro System.Console.WriteLine
            //? jen chybí System.Console.Write();
        }

        private static void SeznamOstatnichPretizenychMetod()
        {
            //var consoleKeyInfo = System.Console.ReadKey(); // 2 overloady
            //var cki = System.Console.ReadKey(boolIntercept);

            //var errStr = System.Console.OpenStandardError(); // 2 overloady
            //var es = System.Console.OpenStandardError(intBufferSize);

            //var inputStr = System.Console.OpenStandardInput(); // 2 overloady
            //var ie = System.Console.OpenStandardInput(intBufferSize);

            //var outputStr = System.Console.OpenStandardOutput(); // 2 overloady
            //var os = System.Console.OpenStandardOutput(intBufferSize);

            //System.Console.MoveBufferArea(intSourceLeft, intSourceTop, intSourceWidth, intSourceHeight, intTargetLeft, intTargetTop); // 2 overloady
            //System.Console.MoveBufferArea(intSourceLeft, intSourceTop, intSourceWidth, intSourceHeight, intTargetLeft, intTargetTop, charSourceChar, sourceForeColor, sourceBackColor);

            //System.Console.Beep(); // 2 overloady
            //System.Console.Beep(intFrequency, intDuration);
        }

        private static void SeznamVnorenychProperties()
        {
            //! TextReader - má pouze public metody
            var tr = System.Console.In;
            tr.Close();
            tr.Peek();
            tr.Dispose();
            tr.ReadLine();
            tr.Read(); // 3 overloady
            //tr.Read(buffer);
            //tr.Read(buffer, index, count);

            //? tr.ReadAsync(buffer); // 2 overloady
            //? tr.ReadAsync(buffer, index, count);

            //? tr.ReadBlock(buffer); // 2 overloady
            //? tr.ReadBlock(buffer, index, count);

            //? tr.ReadBlockAsync(buffer); // 2 overloady
            //? tr.ReadBlockAsync(buffer, index, count);

            tr.ReadLine();
            tr.ReadLineAsync();
            //tr.ReadLineAsync(cancellationToken);

            tr.ReadToEnd();
            tr.ReadToEndAsync();
            //tr.ReadToEndAsync(cancellationToken);

            //! TextWriter - public metody
            var tw = System.Console.Out;
            tw.Close();
            tw.Dispose();
            tw.DisposeAsync();
            //? extension metoda tw.ConfigureAwait(continueOnCapturedContext);
            tw.Flush();
            tw.FlushAsync();
            //? tw.Write(stringBuilderValue); // +18 overloadů, který jsou stejný jako u metody Write
            //? tw.WriteAsync(stringBuilderValue); // +5 overloadů, který jsou stejný jako u metody Write
            tw.WriteLine(); // +19 overloadů, který jsou stejný jako u metody Write
            tw.WriteLineAsync(); // +6 overloadů, který jsou stejný jako u metody Write

            //! TextWriter - public properties
            var e = tw.Encoding;
            var x = tw.FormatProvider;
            var n = tw.NewLine;

            //! Encoding - properties
            var bn = e.BodyName;
            var cp = e.CodePage;
            var df = e.DecoderFallback;
            var ef = e.EncoderFallback;
            var en = e.EncodingName;
            var hn = e.HeaderName;
            var bd = e.IsBrowserDisplay;
            var bs = e.IsBrowserSave;
            var mnd = e.IsMailNewsDisplay;
            var mns = e.IsMailNewsSave;
            var ro = e.IsReadOnly;
            var sb = e.IsSingleByte;
            var p = e.Preamble;
            var wn = e.WebName;
            var wcp = e.WindowsCodePage;

            //! Encoding - public metods

        }
    }
}