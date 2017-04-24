using System;

namespace TestClient
{
    public class ConsoleWriter
    {
        public ConsoleColor SuccessColor { get; set; }
        public ConsoleColor ErrorColor { get; set; }
        public ConsoleColor WarningColor { get; set; }
        public string SuccessText { get; set; }
        public string ErrorText { get; set; }
        public string WarningText { get; set; }

        public ConsoleColor ForegroundColor
        {
            get { return Console.ForegroundColor; }
            set { Console.ForegroundColor = value; }
        }

        public ConsoleColor BackgroundColor
        {
            get { return Console.BackgroundColor; }
            set { Console.BackgroundColor = value; }
        }

        public ConsoleWriter()
        {
            SuccessColor = ConsoleColor.Green;
            ErrorColor = ConsoleColor.Red;
            WarningColor = ConsoleColor.Blue;

            SuccessText = "OK";
            ErrorText = "ERROR";
            WarningText = "WARNING";
        }

        public void Write(string value)
        {
            Console.Write(value);
        }

        public void Write(ConsoleColor color, string value)
        {
            ConsoleColor oldColor = Console.ForegroundColor;
            Console.ForegroundColor = color;
            Console.Write(value);
            Console.ForegroundColor = oldColor;
        }

        public void Write(string format, params object[] args)
        {
            Console.Write(format, args);
        }

        public void Write(ConsoleColor color, string format, params object[] args)
        {
            ConsoleColor oldColor = Console.ForegroundColor;
            Console.ForegroundColor = color;
            Console.Write(format, args);
            Console.ForegroundColor = oldColor;
        }

        public void WriteLine()
        {
            Console.WriteLine();
        }

        public void WriteLine(string value)
        {
            Console.WriteLine(value);
        }

        public void WriteLine(ConsoleColor color, string value)
        {
            ConsoleColor oldColor = Console.ForegroundColor;
            Console.ForegroundColor = color;
            Console.WriteLine(value);
            Console.ForegroundColor = oldColor;
        }

        public void WriteLine(string format, params object[] args)
        {
            Console.WriteLine(format, args);
        }

        public void WriteLine(ConsoleColor color, string format, params object[] args)
        {
            ConsoleColor oldColor = Console.ForegroundColor;
            Console.ForegroundColor = color;
            Console.WriteLine(format, args);
            Console.ForegroundColor = oldColor;
        }

        public void WriteSuccess()
        {
            Write(SuccessColor, SuccessText);
        }


        public void WriteSuccess(string value)
        {
            Write(SuccessColor, value);
        }

        public void WriteSuccess(string format, params object[] args)
        {
            Write(SuccessColor, string.Format(format, args));
        }

        public void WriteLineSuccess()
        {
            WriteLine(SuccessColor, SuccessText);
        }

        public void WriteLineSuccess(string value)
        {
            WriteLine(SuccessColor, value);
        }

        public void WriteLineSuccess(string format, params object[] args)
        {
            WriteLine(SuccessColor, string.Format(format, args));
        }

        public void WriteError()
        {
            Write(ErrorColor, ErrorText);
        }

        public void WriteError(string value)
        {
            Write(ErrorColor, value);
        }

        public void WriteError(string format, params object[] args)
        {
            Write(ErrorColor, string.Format(format, args));
        }

        public void WriteLineError()
        {
            WriteLine(ErrorColor, ErrorText);
        }

        public void WriteLineError(string value)
        {
            WriteLine(ErrorColor, value);
        }

        public void WriteLineError(string format, params object[] args)
        {
            WriteLine(ErrorColor, string.Format(format, args));
        }

        public void WriteWarning()
        {
            Write(WarningColor, WarningText);
        }

        public void WriteWarning(string value)
        {
            Write(WarningColor, value);
        }

        public void WriteWarning(string format, params object[] args)
        {
            Write(WarningColor, string.Format(format, args));
        }

        public void WriteLineWarning()
        {
            WriteLine(WarningColor, WarningText);
        }

        public void WriteLineWarning(string value)
        {
            WriteLine(WarningColor, value);
        }

        public void WriteLineWarning(string format, params object[] args)
        {
            WriteLine(WarningColor, string.Format(format, args));
        }
    }
}