using TreeDS;

Tree tree = new Tree();
tree.Add(50);
tree.Add(30);
tree.Add(20);
tree.Add(40);
tree.Add(70);
tree.Add(60);
tree.Add(80);

/*
			50
		/	 \
		30	 70
		/ \ / \
	  20 40 60 80 
    
*/

//bfs.BFSearch(tree);
// []
// enqueue 50 
// [50]
// dequeue 50 AND enqueue 30 70
// [30 70]
// dequeue 30 AND enqueue 20 40
// [70 20 40]
// dequeue 70 AND enqueue 60 80
// [20 40 60 80]
// dequeue 20 40 60 80

dfs.DFSearch(tree);
