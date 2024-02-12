using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericQueue
{
    public class GQueue<T>
    {
        T[] queue;
        int front = -1, rear = -1;

        public GQueue() 
        {
            queue = new T[10];
        }

        public void Enqueue(T item)
        {
            if (isFull())
                throw new InvalidOperationException("Queue is full!");
            rear++;
            queue[rear] = item;
        }

        public T Dequeue()
        {
            if (isEmpty())
            {
                throw new InvalidOperationException("Queue is empty!");
            }
            T val = queue[front];
            front++;
            return val;
        }

        public bool isEmpty()
        {
            if(front == -1 && rear == -1)
                return true;
            return false;
        }

        public bool isFull()
        {
            if(rear == queue.Length - 1)
                return true;
            return false;
        }
    }
}
