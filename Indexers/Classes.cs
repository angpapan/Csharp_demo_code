namespace Indexers;

internal class Classes
{
    private string[] _classes;

    public string this[int index]
    {
        get
        {
            return _classes[index];
        }

        set
        {
            _classes[index] = value;
        }
    }

    public int NumberOfActiveClasses => _classes.Where(c => !String.IsNullOrEmpty(c)).Count();
    public int NumberOfAvailableClasses => _classes.Where(c => String.IsNullOrEmpty(c)).Count();
    public int FirstAvailableClass => Array.IndexOf(_classes, null);
    public int NumberOfPossibleClasses => _classes.Length;

    public Classes(int size)
    {
        _classes = new string[size];
    }
}
