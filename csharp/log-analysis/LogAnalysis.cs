using System;

public static class LogAnalysis 
{
    public static string SubstringAfter(this string message, string separator)
    {
        int index  = message.IndexOf(separator) + separator.Length;
        return message[index..];
    }

    public static string SubstringBetween(this string message, string start, string end)
    {
        message = message.SubstringAfter(start);
        return message[..message.IndexOf(end)];
    }

    public static string Message (this string message) => message.SubstringAfter("]: ");
    public static string LogLevel(this string message) => message.SubstringBetween("[", "]: ");
}
