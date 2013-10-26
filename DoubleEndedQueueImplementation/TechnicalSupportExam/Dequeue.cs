namespace DoubleEndedQueue
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A double-ended queue. Provides fast insertion and removal from the head or tail end, 
    /// and fast indexed access.
    /// </summary>
    /// <typeparam name="T">The type of item to store in the deque.</typeparam>
    public class Dequeue<T> : IDeque<T>
    {
        /// <summary>
        /// Fields.
        /// </summary>
        private readonly LinkedList<T> data;

        /// <summary>
        ///  Creates a new dequeue.
        /// </summary>
        public Dequeue()
        {
            this.data = new LinkedList<T>();
        }

        /// <summary>
        /// Creates a new dequeue.
        /// </summary>
        /// <param name="collection">The initial capacity to give the dequeue.</param>
        public Dequeue(IEnumerable<T> collection)
        {
            this.data = new LinkedList<T>(collection);
        }

        /// <summary>
        ///  Gets the number of items in the dequeue.
        /// </summary>
        public int Count()
        {
            return this.data.Count(); 
        }

        /// <summary>
        ///  Adds an item to the head of the dequeue.
        /// </summary>
        /// <param name="item">The item to be added.</param>
        public void PushFirst(T item)
        {
            this.data.AddFirst(item);
        }

        /// <summary>
        /// Adds an item to the tail of the dequeue.
        /// </summary>
        /// <param name="item">The item to be added.</param>
        public void PushLast(T item)
        {
            this.data.AddLast(item);
        }

        /// <summary>
        ///  Removes an item from the head of the dequeue.
        /// </summary>
        /// <returns>An item of type T.</returns>
        public T PopFirst()
        {
            var firstItem = this.data.First;
            this.data.RemoveFirst();
            return firstItem.Value;
        }

        /// <summary>
        /// Removes an item from the tail of the dequeue.
        /// </summary>
        /// <returns>An item of type T.</returns>
        public T PopLast()
        {
            var lastItem = this.data.Last;
            this.data.RemoveLast();
            return lastItem.Value;
        }

        /// <summary>
        /// Gets the item at the head of the dequeue.
        /// </summary>
        /// <returns>An item of type T.</returns>
        public T PeekFirst()
        {
            return this.data.First.Value;
        }

        /// <summary>
        /// Gets the item at the tail of the dequeue.
        /// </summary>
        /// <returns>An item of type T.</returns>
        public T PeekLast()
        {
            return this.data.Last.Value;
        }

        /// <summary>
        /// Clears all items from the dequeue.
        /// </summary>
        public void Clear()
        {
            this.data.Clear();
        }

        /// <summary>
        /// Returns a value indicating whether the specified T item occurs within this dequeue.
        /// </summary>
        /// <param name="item">The item that is checked.</param>
        /// <returns>A bool value.</returns>
        public bool Contains(T item)
        {
            if (this.data.Find(item).Value.Equals(true))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}