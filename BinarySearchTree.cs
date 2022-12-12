using System.Collections;

namespace MyApp;

public class BinarySearchTree{
    private Node? _root;

    public void Insert(int value) {
        // Create new node
        Node newNode = new Node(value);
        // If the list is empty, then point both head and tail to the new node.
        if (_root is null)
            _root = newNode;
        // If the list is not empty, then only head will be affected.
        else
            _root.Insert(value);
    }

    public bool Contains(int value) {
        return _root != null && _root.Contains(value);
    }

    public override string ToString() {
        return "<Bst>{" + string.Join(", ", this) + "}";
    }
}