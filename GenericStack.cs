using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsStack
{
    class GStack<T>
    {
        T[] genStack;
        int top;
        public GStack() 
        {
            genStack = new T[20];
            top = -1;
        }

        public int Push(T val)
        {
            if (top == genStack.Length - 1)
            {
                return -1;
            }
            else
            {
                top++;
                genStack[top] = val;
            }
            return 0;
        }
        public T Pop()
        {
            T val = default;
            bool res = IsEmpty();
            if (top >= 0)
            {
                val = genStack[top];
                top--;
            }
            return val;
        }

        public T Peek()
        {
            return genStack[top];
        }

        public bool IsEmpty()
        {
            return top == -1;
        }
    }
}
