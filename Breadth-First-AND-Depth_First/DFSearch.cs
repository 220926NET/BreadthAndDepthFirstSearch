namespace TreeDS;

public class dfs{


    public static void DFSearch(Tree tree){

        Stack<Node> s = new Stack<Node>();

        Node node = tree.root;

        s.Push(node);

        while(s.Count > 0){

            node = s.Pop();
            Console.Write(node.value + " ");
            
            if(node.right != null){
                s.Push(node.right);
            }
            if(node.left != null){
                s.Push(node.left);
            }

        }

    }
}