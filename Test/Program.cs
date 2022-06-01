using System.Collections;


SeedGarage();



static void SeedGarage()
{
    var garage = new Garage<Vehicle>(5) { new Vehicle("stoc"), new Vehicle("mog") };
    garage.Add(new Vehicle("roro"));
    garage.Add(new Vehicle("roro"));
    garage.Add(new Vehicle("roro"));
    garage.Add(new Vehicle("roro"));
    garage.Add(new Vehicle("roro"));
    garage.Add(new Vehicle("roro"));
    garage.Add(new Vehicle("roro"));
    garage.Add(new Vehicle("roro"));
    garage.Add(new Vehicle("roro"));

    foreach (var g in garage)
    {
        if (g != null) Console.WriteLine(g.Name);
    }
}

class Vehicle
{
    public string Name;
    public Vehicle(string name)
    {
        Name = name;
    }
}

class Garage<T> : IEnumerable<T>
{
    private readonly T[] _garage;
    private readonly int _size;

    public Garage(int size)
    {
        _size = size;
        _garage = new T[_size];
    }

    public bool Add(T v)
    {
        for (int i = 0; i < _size; i++)
        {
            if (_garage[i] == null) { _garage[i] = v; return true; }
        }
        return false;
    }

    public IEnumerator<T> GetEnumerator() => ((IEnumerable<T>)_garage).GetEnumerator();

    IEnumerator IEnumerable.GetEnumerator() => _garage.GetEnumerator();
}
