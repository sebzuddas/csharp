static class LogLine
{
    /* we start with a string "[ERROR]: error desc \n"
     *
    */

    public static string Message(string logLine)
    {
        string[] substrings = logLine.Split(":");
        string neatMessage = substrings[1].Trim(); // removes all leading and trailing white space characters.
        return neatMessage;

    }

    public static string LogLevel(string logLine)
    {
        logLine = logLine.ToLower(); // changes all to lower case
        int closeBracketIndex = logLine.LastIndexOfAny([']']);
        logLine = logLine.Substring(1, closeBracketIndex - 1);
        return logLine = logLine.Trim();
        
    }

    public static string Reformat(string logLine)
    {
        string neatString = LogLine.Message(logLine);
        string logLevel = LogLine.LogLevel(logLine);
        return neatString + " (" + logLevel + ")"; 
    }
 }
