using System;
using System.Collections;
using System.Collections.Generic;

namespace ParanthesisCheckerUsingStack
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, char> dictionary = new Dictionary<char, char> { { '{', '}' }, { '[', ']' }, { '(', ')' }, };
            bool IsValid(string s)
            {
                Stack stack = new Stack();
                foreach (var par in s.ToCharArray())
                {
                    if (par == '(' || par == '{' || par == '[')
                    {
                        stack.Push(par);
                    }
                    else if (stack.Count > 0)
                    {
                        var ele = stack.Pop();
                        if (par != dictionary[ele.ToString()[0]])
                        {
                            return false;
                        }
                    }
                    else
                    {
                        return false;
                    }
                }
                if (stack.Count == 0)
                    return true;
                return false;
            }
            Console.WriteLine(IsValid("{()}[]"));
        }
    }
}
