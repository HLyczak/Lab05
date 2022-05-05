using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05
{
    public class ObservableList1<T>
    {
        public List<T> list1 = new List<T>();

        public int Length
        {
            get
            {
                return list1.Count();
            }
        }

        public void Add(T t)
        {
            list1.Add(t);
        }

        public T Get(int index)
        {
            return list1[index];
        }

        public void Set(int index, T t)
        {
            list1[index] = t;
        }

        public void RemoveAt(int index)
        {
            list1.RemoveAt(index);
        }

        public T this[int index]
        {
            get
            {
                return this.Get(index);
            }
            set
            {
                this.Set(index, value);
            }
        }
    }
}