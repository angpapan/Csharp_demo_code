namespace Generics;

internal class Person<T>
{
    private T _id;
    public T Id => _id;
    public string Name { get; set; }
    public string Title { get; set; }

    public Person(T id)
    {
        _id = id;
    }

    public Person(T id, string name, string title) : this(id)
    {
        Name = name;
        Title = title;
    }

    public override string ToString()
    {
        return $"Id: {_id}, Title: {Title}, Name: {Name}";
    }
}
