namespace Extensions;

internal static class StringExtensions
{
    public static int CountOccuranciesOfChar(this string data, char character)
    {
        return data.Count(d => d == character);
    }
}
