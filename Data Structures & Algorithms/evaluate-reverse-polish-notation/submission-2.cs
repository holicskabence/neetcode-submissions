public class Solution {
    public int EvalRPN(string[] tokens) {
        var stack = new Stack<int>();
        int currentResult = 0;

        for(int i = 0; i < tokens.Length; i++)
        {
            string current = tokens[i];

            if(!current.Contains("+") && !current.Contains("-") && !current.Contains("*") && !current.Contains("/"))
            {
                stack.Push(int.Parse(current));
            }
            else
            {
                 while(stack.Count > 0){
                    int top = stack.Pop();
                    currentResult = stack.Pop(); 
                    switch(current){
                        case "+":
                            currentResult += top;
                        break;
                        case "-":
                            currentResult -= top;
                        break;
                        case "*":
                            currentResult *= top;
                        break;
                        case "/":
                            if(top == 0)
                            {
                                currentResult = 0;
                            }else
                            {
                                currentResult /= top;
                            }
                        break;
                    }
                }

                stack.Push(currentResult);
            }
        }

        return stack.Pop();
    }
}
