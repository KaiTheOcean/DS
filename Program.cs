using System;
using System.Collections;
using System.Collections.Generic;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
        // THIS IS FOR QUEUE!!!
        Console.WriteLine("This is for queue: ");
        Console.WriteLine();

        // Create a queue
        // Using Queue class
        Queue hotLine = new Queue();
  
        // Adding a new waiting spot in queue
        // Using Enqueue() method
        hotLine.Enqueue("John");
        hotLine.Enqueue("Kai");
        hotLine.Enqueue("Lily");
        hotLine.Enqueue("Grace");
        hotLine.Enqueue("Mike");

        // After picks up the first call removing the last person in the queue
        hotLine.Dequeue();
  
        // Checking if John is
        // present in the Queue or not
        if (hotLine.Contains("John") == true) {
            Console.WriteLine("John is in the queue!!");
        }
        else {
            Console.WriteLine("John is not in the queue!!");
        }


        // Check the size of the queue
        Console.WriteLine($"There are {hotLine.Count} people in the queue");



        // THIS IS FOR LINKED_LIST!!!
        Console.WriteLine();
        Console.WriteLine("This is for Linked lis");
        Console.WriteLine();
        // Create a linked list
        string [] names = {"C1", "C2"};
        LinkedList <string> customers = new LinkedList <string>(names);

        // Add C3, C4, C5 in the linked list
        // C1, C2, C3, C4, C5
        customers.AddLast("C3");
        customers.AddLast("C4");
        customers.AddLast("C5");
        Console.WriteLine("After added C3, C4, C5 in the linked list: ");
        foreach(string i in customers)
        {
            Console.WriteLine(i);
        }

        // C7 has a golden pass so she gets paid first
        // C7, C1, C2, C3, C5
        customers.AddFirst("C7");
        Console.WriteLine();
        Console.WriteLine("After added C7 in the linked list: ");
        foreach(string i in customers)
        {
            Console.WriteLine(i);
        }

        // C5 is leaving the linked list, because he forgot something
        // C7, C1, C2, C3, C4
        customers.RemoveLast();
        Console.WriteLine();
        Console.WriteLine("After Remove C5 in the linked list: ");
        foreach(string i in customers)
        {
            Console.WriteLine(i);
        }

        // A mananger wants to see how many poeple are in teh line
        // 5
        Console.WriteLine();
        int number = customers.Count();
        Console.WriteLine($"The total count of the linked list: {number}");
        }

        // // This is for TREE
        // public class Node {
        // public int key;
        // public Node left, right;

        // public Node(int key)
        // {
        //     this.key = key;
        //     left = null;
        //     right = null;
        // }
        // }

        // static Node root;
        // static void insertTree(Node temp, int key)
        // {
        //     if (temp == null) {
        //     root = new Node(key);
        //     return;
        //     }
        // Queue<Node> q = new Queue<Node>();
        // q.Enqueue(temp);

        // while (q.Count != 0) {
        //     temp = q.Peek();
        //     q.Dequeue();

        //     if (temp.left == null) {
        //         temp.left = new Node(key);
        //         break;
        //     }
        //     else
        //         q.Enqueue(temp.left);

        //     if (temp.right == null) {
        //         temp.right = new Node(key);
        //         break;
        //     }
        //     else
        //         q.Enqueue(temp.right);
        //     }
        // }
        // static void deleteDeepest(Node root, Node delNode)
        // {
        //     Queue<Node> q = new Queue<Node>();
        //     q.Enqueue(root);

        //     Node temp = null;

        //     while (q.Count != 0) {
        //         temp = q.Peek();
        //         q.Dequeue();

        //         if (temp == delNode) {
        //             temp = null;
        //             return;
        //         }
        //         if (temp.right != null) {
        //             if (temp.right == delNode) {
        //                 temp.right = null;
        //                 return;
        //             }

        //             else
        //                 q.Enqueue(temp.right);
        //         }

        //         if (temp.left != null) {
        //             if (temp.left == delNode) {
        //                 temp.left = null;
        //                 return;
        //             }
        //             else
        //                 q.Enqueue(temp.left);
        //         }
        //     }
        // }

        // // This function allows us to delete any value in the tree
        // static void deleteTree(Node root, int key)
        // {       
        //     if (root == null)
        //         return;

        //     if (root.left == null && root.right == null) {
        //         if (root.key == key) {
        //             root = null;
        //             return;
        //         }
        //         else
        //             return;
        //     }

        //     Queue<Node> q = new Queue<Node>();
        //     q.Enqueue(root);
        //     Node temp = null, keyNode = null;

        //     while (q.Count != 0) {
        //         temp = q.Peek();
        //         q.Dequeue();

        //         if (temp.key == key)
        //             keyNode = temp;

        //         if (temp.left != null)
        //             q.Enqueue(temp.left);

        //         if (temp.right != null)
        //             q.Enqueue(temp.right);
        //     }

        //     if (keyNode != null) {
        //         int x = temp.key;
        //         deleteDeepest(root, temp);
        //         keyNode.key = x;
        //     }
        // }
        // root = new Node(2);
        // root.left = new Node(1);
        // root.left.left = new Node(6);
        // root.right = new Node(9);
        // root.right.left = new Node(12);
        // root.right.right = new Node(8);

        // int key = 11;
        // insert(root, key);

        // Console.Write("Inorder traversal after insertion:");
        // inorder(root); // 1 6 2 9 8 11 12  
    }
}