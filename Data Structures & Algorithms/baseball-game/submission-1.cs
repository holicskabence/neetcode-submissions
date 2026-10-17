public class Solution {
    public int CalPoints(string[] operations) {
        var stack = new Stack<int>();
        int result = 0;

        for(int i = 0; i < operations.Length; i++)
        {
            if(operations[i] == "+")
            {
                 int left = stack.Pop();
                 int right = stack.Pop();
                 int sum = left + right;
                 stack.Push(left);
                 stack.Push(right);
                 stack.Push(sum);
            }
            else if(operations[i] == "D")
            {
                int last = stack.Pop();
                int doubled = last * 2;
                stack.Push(last);
                stack.Push(doubled);
            }
            else if(operations[i] == "C")
            {
                stack.Pop();
            }
            else
            {
                Console.WriteLine(operations[i]);
                stack.Push(int.Parse(operations[i]));
            }
        }

        while(stack.Count > 0)
        {
            result += stack.Pop();
        }

        return result;
    }
}