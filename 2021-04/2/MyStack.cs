using System;
using System.Collections.Generic;

class MyStack<T>
{
    const int maxSize = 10; //const는 java의 final과 같은 상수 선언이다.
    private T[] arr = new T[maxSize];
    private int top;

    public MyStack()
    {
        top = 0;
    }
    public void Push(T val)
    {
        if (top<maxSize)
        {
            arr[top] = val;
            Console.WriteLine("스택 메모리 [" + top + "]가 생성되었습니다.");
            ++top;
        }
        else
        {
            Console.WriteLine("스택이 가득 찼습니다!");
            return;
        }
    }
    public T Pop()
    {
        if (top>0)
        {
            Console.WriteLine("스택 메모리[" + top + "]가 제거되었습니다.");
            --top;
            return arr[top];
        }
        else
        {
            Console.WriteLine("스택이 비었습니다!");
            return default;
        }
    }
        static void Main(string[] args)
        {
            MyStack<int> myStack = new MyStack<int>();
            for (int i = 0; i < maxSize; i++)
            {
                myStack.Push(i);
            }
            Console.WriteLine();

            for (int i = 0; i < maxSize; i++)
            {
                myStack.Pop();
            }
        }
    }
