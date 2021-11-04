using System;

static class LogLine
{
    public static string Message(string logLine)
    {
        return logLine.Remove(0, logLine.IndexOf(":") + 1).Trim();
    }

    public static string LogLevel(string logLine)
    {
        return logLine.Remove(logLine.IndexOf("]")).ToLower().Replace('[', ' ').Trim();
    }

    public static string Reformat(string logLine)
    {
        return Message(logLine) + " " + '(' + LogLevel(logLine) + ')';
    }
}
//Nu am sa mint, la acest challenge chiar am stat o ora jumatate :