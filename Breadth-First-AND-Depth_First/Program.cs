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
// dequeue 20 
// [40 60 80]
// dequeue 40
// [60 80]
// dequeue 60
// [80]
// dequeue 80
// []

dfs.DFSearch(tree);
// []
// push 50
// [50]
// pop 50 AND push 70 30
// [30 70]
// pop 30 AND push 40 20
// [20 40 70]
// pop 20
// [40 70]
// pop 40
// [70]
// pop 70 AND push 80 60
// [60 80]
// pop 60
// [80]
// pop 80
// []


