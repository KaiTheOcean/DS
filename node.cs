namespace MyApp;

public class Node {
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(int data) {
        this.Data = data;
    }

    public void Insert(int value) {
        if (value < Data) {
            // Insert to the left
            if (Left is null)
                Left = new Node(value);
            else
                Left.Insert(value);
        }
        else if (value == Data)
        {
        }
        else {
            // Insert to the right
            if (Right is null)
                Right = new Node(value);
            else
                Right.Insert(value);
        }
    }

    public bool Contains(int value)
    {        
        if (value == Data)
            return true;

        if (value > Data)
        {
            if (Right is null)
            {
                return false;
            }
            return Right.Contains(value);
        }
            
        else
        {
            if (Left is null)
            {
                return false;
            }
            return Left.Contains(value);
        }
    }
}