using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// ref link:https://www.youtube.com/watch?v=5B9oB2vMmvI&list=PLAIBPfq19p2EJ6JY0f5DyQfybwBGVglcR&index=70

namespace WhenToUseStaticConstructorWithAnInstance
{
    class MyClass
    {
        private static string[] _content;

        static MyClass()
        {
            _content = File.ReadAllLines("t.txt");
        }

        public MyClass(int arraySize)
        {
            string[] temp = new string[arraySize];
            Array.Copy(_content, temp, arraySize);
            _content = temp;
        }
    }
}
