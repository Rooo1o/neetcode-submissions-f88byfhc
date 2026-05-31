public class MinStack {
    Stack<int> stack;
    Stack<int> minStack;
    public MinStack() {
        this.stack = new Stack<int>();
        this.minStack = new Stack<int>();
    }
    
    public void Push(int val) {
        if(stack.Count == 0) {
            stack.Push(val);
            minStack.Push(val);
        } else {
            if (val <= minStack.Peek()) {
                minStack.Push(val);
            }
            stack.Push(val);
        }
    }
    
    public void Pop() {
        if(stack.Peek() == minStack.Peek()) {
            minStack.Pop();
        }
        stack.Pop();
    }
    
    public int Top() {
        return stack.Peek();
    }
    
    public int GetMin() {
        return minStack.Peek();
    }
}
