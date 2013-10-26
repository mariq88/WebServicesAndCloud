using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleEndedQueue
{
    public interface IDeque<T>
    {
        int Count();

        void PushFirst(T element);

        void PushLast(T element);

        T PopFirst();

        T PopLast();

        T PeekFirst();

        T PeekLast();

        void Clear();

        bool Contains(T element);




    }
}
