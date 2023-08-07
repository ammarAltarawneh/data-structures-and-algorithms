namespace tree_fizz_buzz
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("tree fizz buzz brethQueue ");
            k_ary_tree k_Ary_Tree = new k_ary_tree();

            K_ary_Tree_Node rootNode = new K_ary_Tree_Node("50");
            K_ary_Tree_Node node1 = new K_ary_Tree_Node("30");
            K_ary_Tree_Node node2 = new K_ary_Tree_Node("27");
            K_ary_Tree_Node node3 = new K_ary_Tree_Node("115");
            K_ary_Tree_Node node4 = new K_ary_Tree_Node("45");
            K_ary_Tree_Node node5 = new K_ary_Tree_Node("16");
            K_ary_Tree_Node node6 = new K_ary_Tree_Node("12");
            K_ary_Tree_Node node7 = new K_ary_Tree_Node("49");


            rootNode.addChildren(node1);
            rootNode.addChildren(node2);
            node1.addChildren(node3);
            node1.addChildren(node4);
            node1.addChildren(node5);
            node2.addChildren(node6);
            node2.addChildren(node7);

            k_Ary_Tree.root = rootNode;



            k_ary_tree k_ary = callFizzBuzzTree(k_Ary_Tree);

           
            foreach (K_ary_Tree_Node item in k_ary.root.Children)
            {
                Console.WriteLine(item.Value + " ");
            }
        }

        public static string BuzzTreeCheck(K_ary_Tree_Node node)
        {
            string val;
            int nodeInt = Int32.Parse(node.Value);
            if (nodeInt % 5 == 0 && nodeInt % 3 == 0)
                val = "fizzBuzz";
            else if (nodeInt % 5 == 0)
                val = "Buzz";
            else if (nodeInt % 3 == 0)
                val = "fizz";
            else
                val = node.Value.ToString();

            return val;
        }
        public static void fizzBuzzTree(K_ary_Tree_Node root, K_ary_Tree_Node newtreeRoot)
        {


            Queue<K_ary_Tree_Node> brethQueue = new Queue<K_ary_Tree_Node>();

            brethQueue.Enqueue(root);
            while (brethQueue.Count() != 0)
            {
                K_ary_Tree_Node front = brethQueue.Dequeue();
                string val = BuzzTreeCheck(front);
                front.Value = val;


                newtreeRoot.addChildren(front);



                foreach (K_ary_Tree_Node node in front.Children)
                {
                    brethQueue.Enqueue(node);
                }

            }

        }
        public static k_ary_tree callFizzBuzzTree(k_ary_tree k_aryTree)
        {
            k_ary_tree newK_aryTree = new k_ary_tree();

            if (k_aryTree.root == null)
            {
                return null;
            }

            string val = BuzzTreeCheck(k_aryTree.root);
            K_ary_Tree_Node root = new K_ary_Tree_Node(val);
            newK_aryTree.root = root;


            fizzBuzzTree(k_aryTree.root, newK_aryTree.root);

            return newK_aryTree;
        }
    }
}