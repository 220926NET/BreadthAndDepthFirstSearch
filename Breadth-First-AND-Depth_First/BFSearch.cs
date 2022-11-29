namespace TreeDS;

public class bfs{

    public static void BFSearch(Tree tree){
        
        //start from root
        Node node = tree.root;

        Queue<Node> q = new Queue<Node>();

        // enqueue root
        q.Enqueue(node);

        // while we have node at  queue
        while(q.Count > 0){

            // dequeue our node and print out
            node = q.Dequeue();
            Console.Write(node.value + " ");

            // checking current node if have left node
            // if yes, add left node to queue
            if(node.left != null){
                q.Enqueue(node.left);
            }
            
            // checking current node if have right node
            // if yes, add right node to queue
            if(node.right != null){
                q.Enqueue(node.right);
            }
        }
    }
}


