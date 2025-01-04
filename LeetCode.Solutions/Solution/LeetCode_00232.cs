// problem name: Implement Queue using Stacks
// problem url: https://leetcode.com/problems/implement-queue-using-stacks/description/

// Author: Mehedi Hasan Kajol
// Date: 04 Jan 2025
// Profile: https://leetcode.com/u/Mehedi/ 

namespace LeetCode.Solutions.Solution;

internal class LeetCode_00232
{
    internal class MyQueue
    {
        Stack<int> queue;
        Stack<int> stack;

        public MyQueue()
        {
            queue = [];
            stack = [];
        }

        public void Push(int x)
        {
            queue.Push(x);
        }

        public int Pop()
        {
            while (queue.Count > 0)
            {
                stack.Push(queue.Pop());
            }
            var data = stack.Pop();

            while (stack.Count > 0)
            {
                queue.Push(stack.Pop());
            }

            return data;
        }

        public int Peek()
        {
            while (queue.Count > 0)
            {
                stack.Push(queue.Pop());
            }
            var data = stack.Peek();

            while (stack.Count > 0)
            {
                queue.Push(stack.Pop());
            }

            return data;
        }

        public bool Empty()
        {
            return !queue.Any();
        }
    }
}
