namespace TreeDS;
public class Node
{
    public int value;
    public Node? left;
    public Node? right;

    public Node(int value){

        this.value = value;
        left = null;
        right = null;
    }
}

public class Tree
{
    public Node root;

    public Tree(){
        root = null;
    }

    public Tree(int x){

        root = new Node(x);
    }

    public Node Add(int value){ return root = Add(root,value); }

    public Node Add(Node root, int x)
    {
        if(root == null){
            root = new Node(x);
            return root;
        }

        if(x < root.value){
            root.left = Add(root.left,x);
        }
        else if(x > root.value){
            root.right = Add(root.right,x);
        }

        return root;
    }

    
        
}