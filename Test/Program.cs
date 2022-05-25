using System.Collections;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var limitedList = new LimitedList<int>(2) { 1, 2, 3, 4, 5 };

            ////foreach (var item in limitedList) { Console.WriteLine(item); };

            //foreach (var item in limitedList) { Console.WriteLine(item); };

            var value = new Program().ReturnValue();

            var value2 = new Program().ReturnValue2();

            Console.WriteLine(value);
            Console.WriteLine(value2);
        }

        public int ReturnValue()
        {
            int x = new int();
            x = 3;
            int y = new int();
            y = x;
            y = 4;
            return x;
        }

        public int ReturnValue2()
        {
            MyInt x = new MyInt();
            x.MyValue = 3;
            MyInt y = new MyInt();
            y = x;
            y.MyValue = 4;
            return x.MyValue;
        }


    }

    internal class MyInt
    {
        public int MyValue { get; set; }
    }

    public class LimitedList<T> : IEnumerable<T>
    {
        private int capacity;
        private List<T> list;

        public bool IsFull => capacity <= list.Count;

        public LimitedList(int capacity)
        {
            //if (capacity < 2) this.capacity = 2;
            //else this.capacity = capacity;

            //this.capacity = capacity > 2 ? capacity : 2;

            this.capacity = Math.Max(capacity, 2);

            list = new List<T>(this.capacity);
        }

        public bool Add(T item)
        {
            ArgumentNullException.ThrowIfNull(item, "item");

            if (IsFull) return false;

            list.Add(item);
            return true;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return list.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator() => null;
    }
}
