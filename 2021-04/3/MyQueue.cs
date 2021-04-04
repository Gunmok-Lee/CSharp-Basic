using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QueueFibonacci
{
    interface MyQueue
    {
        bool isEmpty();
        // 빈공간이 있는지
        bool isFull();
        // 가득 차있는지
        Object getFrontElement();
        //처음 포인트
        Object getRearElement();
        //원하는 포인트
        void put(Object theObject);    
    }
    class ArrayQueue : MyQueue
    {
        public int MAXQueue = 100;
        public Object[] myQueue;
        public int front = 0;
        public int rear = -1;

        public bool isEmpty()
        {
            return front > rear;
        }
        public bool isFull()
        {
            return rear == MAXQueue - 1;
        }
        public void Enqueue(Object theObject)
        {
            if (isFull())
            {
                Console.WriteLine("Queue 메모리가 가득 찼습니다!");
                return;
            }
            myQueue[++rear] = theObject;
        }
        public Object Dequeue()
        {
            if (isEmpty())
            {
                Console.WriteLine("Queue 메모리가 비었습니다!");
                return null;
            }
            Object item = myQueue[front];
            front++;
            return item;
        }
        public Object getFrontElement()
        {
            return myQueue[front];
        }
        public Object getRearElement()
        {
            return myQueue[rear];
        }
        public void Print()
        {
            Console.WriteLine("Front:{0}, Rear:{1}",front, rear);
            //처음부터 rear까지 출력
        }

        public void put(object theObject)
        {
            throw new NotImplementedException();
        }
    }
    public class Fibonacci
    {
        static Object fibonacci(int j)
        {
            int[] fib = new int[j];
            object a,b;
            ArrayQueue q = new ArrayQueue();
            //Queue는 포인터를 사용하기 때문에 새로운 배열을 만들어 복사한다.
            q.myQueue = new object[100];
            fib[0] = fib[1] = 1;
            q.Enqueue(1);
            q.Enqueue(1);

            for (int i = 2; i < j; i++)
            {
                a = q.getFrontElement();
                b = q.getRearElement();
                fib[i] = Convert.ToInt32(a) + Convert.ToInt32(b);
                q.Dequeue();
                q.Enqueue(fib[i]);
            }

            for (int i = 0; i < fib.Length; i++)
            {
                Console.WriteLine(fib[i] + " ");
            }
            return 0;
        }

        public class MainApp
        {
            public static void Main(String[] args)
            {
                int j = 0;
                Console.Write("숫자를 입력하세요.");
                j = Convert.ToInt32(Console.ReadLine());
                fibonacci(j);
                Console.ReadLine();
            }
        }
    }
}