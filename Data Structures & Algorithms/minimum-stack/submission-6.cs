public class MinStack {
    Stack<int> mainStack;
    Stack<int> minStack;
    public MinStack() {
        mainStack = new Stack<int>();
        minStack = new Stack<int>();
    }
    
    public void Push(int val) {
        if(mainStack.Count == 0){
            mainStack.Push(val);
            minStack.Push(val);
        } else {
            if(val <= minStack.Peek()) {
                minStack.Push(val);
            }
            mainStack.Push(val);
        }
    }
    
    public void Pop() {
        if(mainStack.Peek() == minStack.Peek()) {
            minStack.Pop();
        }
        mainStack.Pop();
    }
    
    public int Top() {
        return mainStack.Peek();
    }
    
    public int GetMin() {
        return minStack.Peek();
    }
}
