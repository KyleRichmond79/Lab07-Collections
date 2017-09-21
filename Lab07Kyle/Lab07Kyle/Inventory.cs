using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Lab07Kyle
{
    class Inventory<P> : IEnumerable<P> //must remember IEnumerable goes on top!!!!
    {
        P[] items = new P[10];
        public int count = 0;

        public void Add(P item)
        {
            if(count == items.Length)
            {
                int index = count * 2;
                P[] extension = new P[index];
                Array.Copy(items, extension, index);
                items = extension;
            }

            items[count] = item;
            count++;
        }

        public void Remove(P item)
        {
            int removeAt = Array.IndexOf(items, item);
            bool remove = false;
            P[] newArray = new P[items.Length];

            for(int i = 0; i < count; i++)
            {
                if (remove)
                {
                    newArray[i - 1] = items[i];
                }

                if(i != removeAt && !remove)
                {
                    newArray[i] = items[i];
                }

                else
                {
                    remove = true;
                }
            }
            items = newArray;
            count--;
        }

        public IEnumerator<P> GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return items[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        
        }
    }
}
