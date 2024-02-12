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
        public GStack(int S) 
        {
            genStack = new T[S];
            top = -1;
        }

        public void Push(T val = default)
        {
            if(!typeof(T).IsValueType)
                throw new InvalidOperationException("Invalid type!");

            if (top == genStack.Length - 1)
                throw new InvalidOperationException("Stack is filled!");
            else
            {
                top++;
                genStack[top] = val;
            }
        }
        public T Pop()
        {
            T val = genStack[top];
            top--;
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
