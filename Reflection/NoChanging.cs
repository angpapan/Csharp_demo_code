namespace Reflection;

internal class NoChanging
{
    private string _shouldNotChange;
    public string ShouldNotChange => _shouldNotChange;

    public NoChanging(string shouldNotChange)
    {
        _shouldNotChange = shouldNotChange;
    }
}
