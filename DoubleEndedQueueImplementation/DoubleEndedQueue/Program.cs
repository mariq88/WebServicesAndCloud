using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleEndedQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            var test = new Dequeue<string>();
            //Count
            var count = test.Count();
            Console.WriteLine("{0}",count);

            //PushFirst
            test.PushFirst("abc");

            //PushLast
            test.PushLast("def");
            test.PushLast("ghi");

            //PeekFirst
            var peekFirst = test.PeekFirst();
            Console.WriteLine("Testing Peek first, after push first: abc is: {0}", peekFirst);

            //PeekLast
            var peekLast = test.PeekLast();
            Console.WriteLine("Testing Peek last, after push last: ghi is: {0}", peekLast);

            //Pop First
            var popFirst =test.PopFirst();
            Console.WriteLine("Removing the first items: {0}", popFirst);

            //Pop First
            var popLast = test.PopLast();
            Console.WriteLine("Removing the last items: {0}", popLast);

            //Counting once again to check teh third element
            var secondCount = test.Count();
            Console.WriteLine("After second push result should be def: {0}", secondCount);

            //Clear
            test.Clear();
            var thirdCount = test.Count();
            Console.WriteLine("After clearing the deque is empty and has {0} elemnts.", thirdCount);
        }
    }
}
