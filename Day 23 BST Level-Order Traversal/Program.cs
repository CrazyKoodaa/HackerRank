using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Node
{
    public Node left, right;
    public int data;
    public Node(int data)
    {
        this.data = data;
        left = right = null;
    }
}
class Solution
{
    public static Queue<Node> qNode = new Queue<Node>();  
    public static List<string> lNodes = new List<string>();

    static void levelOrder(Node root)
    { 
        //Write your code here

        // Queue both Childs if available    
        if (root.left != null)
            qNode.Enqueue(root.left);
        if (root.right != null) 
            qNode.Enqueue(root.right);
        
        // Add the Nodes data into a list for further coding
        lNodes.Add(root.data.ToString());

        // if the Queue is not yet empty, then take the first element out of the queue
        // if the Queue is empty, then write all the strings together with a space in between
        if (qNode.Count > 0)
            levelOrder(qNode.Dequeue());
        else
            Console.WriteLine(lNodes.Aggregate((a, b) => a + ' ' + b).TrimEnd());

        


    }

    static Node insert(Node root, int data)
    {
        if (root == null)
        {
            return new Node(data);
        }
        else
        {
            Node cur;
            if (data <= root.data)
            {
                cur = insert(root.left, data);
                root.left = cur;
            }
            else
            {
                cur = insert(root.right, data);
                root.right = cur;
            }
            return root;
        }
    }
    static void Main(String[] args)
    {
        Node root = null;
        int T = Int32.Parse(Console.ReadLine());
        while (T-- > 0)
        {
            int data = Int32.Parse(Console.ReadLine());
            root = insert(root, data);
        }
        levelOrder(root);

    }
}