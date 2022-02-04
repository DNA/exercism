using System;

static class LogLine
{
    private static readonly char[] CHARS_TO_TRIM = {'\n', '\r', '\t', ' '};

    private static string[] Parse(string logLine)
    {
        string[] parsed = logLine.Split("]:");
        parsed[0] = parsed[0].Trim('[').ToLower();
        parsed[1] = parsed[1].Trim(CHARS_TO_TRIM);

        return parsed;
    }

    public static string Message(string logLine) => Parse(logLine)[1];

    public static string LogLevel(string logLine) => Parse(logLine)[0];

    public static string Reformat(string logLine)
    {
        string[] logData = Parse(logLine);
        return $"{logData[1]} ({logData[0]})";
    }
}
