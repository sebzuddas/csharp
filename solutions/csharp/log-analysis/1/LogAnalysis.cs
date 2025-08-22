public static class LogAnalysis 
{
    public static string SubstringAfter(this string substring, string split)
    {
        return substring.Split(split)[1];
    }

    public static string SubstringBetween(this string str, string startSubString, string endSubString)
    {
        int pFrom = str.IndexOf(startSubString) + startSubString.Length;
        int pTo = str.IndexOf(endSubString);
        return str.Substring(pFrom , pTo-pFrom);
    }
    
    public static string Message(this string str)
    {
        return str.SubstringAfter(": ");
    }

    public static string LogLevel(this string str)
    {
        return str.SubstringBetween("[", "]");
    }

}
