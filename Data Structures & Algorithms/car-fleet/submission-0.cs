public class Solution {
    public int CarFleet(int target, int[] position, int[] speed) {
        var cars = position
            .Zip(speed, (p , s) => (position : p, speed : s))
            .OrderByDescending(x => x.position)
            .ToList();

        var stack = new Stack<double>();
        for(int i = 0; i < cars.Count; i++)
        {
            stack.Push((target - cars[i].position) / cars[i].speed);

            if(stack.Count >= 2)
            {
                double peek = stack.Peek();
                double last = stack.ElementAt(1);

                if(last >= peek){
                    stack.Pop();
                }
            }
        }

        return stack.Count();
    }
}
