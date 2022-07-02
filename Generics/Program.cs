using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> sehirler = new List<string>();
            Console.WriteLine(sehirler.Count);
            //  sehirler.Add("Ankara");

            MyList<string> sehirler2 = new MyList<string>();
            sehirler2.Add("Ankara");
            sehirler2.Add("İstanbul");
            sehirler2.Add("İzmir");
            Console.WriteLine(sehirler2.Count);

        }
    }

    class MyList<T> //Generic Class
    {
        T[] _array;
        T[] _tempArray;
        public MyList()
        {
            _array = new T[0];
        }

        public void Add(T item) //istediğimiz tipiverebiliriz bu kullanımdan sonra.
        {
            _tempArray = _array;
            _array = new T[_array.Length + 1];

            for (int i = 0; i < _tempArray.Length; i++)
            {
                _array[i] = _tempArray[i];
            }
            //dizi 0 dan basladigi icin -1 dendi.
            _array[_array.Length - 1] = item; //Arrayin son kalan hücresine gönderilen eleman yüklenmiş olur.


        }

        //Count'un değerini döndürebilmek için getter eklendi
        private int _count;
        public int Count
        {
            get { return _array.Length; }

        }




    }





}
