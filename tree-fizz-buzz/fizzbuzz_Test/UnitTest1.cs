using tree_fizz_buzz;
using Program = tree_fizz_buzz.Program;

namespace fizzbuzz_Test
{
    public class UnitTest1
    {
        [Fact]
        public void CreatetreefizzbuzzTest()
        {
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

            k_ary_tree k_ary = Program.callFizzBuzzTree(k_Ary_Tree);

            Console.Write(k_ary.root.Value + " ");
            string result = "";

            foreach (K_ary_Tree_Node item in k_ary.root.Children)
            {
                result += item.Value + " ";
            }

            Assert.Equal("Buzz fizzBuzz fizz Buzz fizzBuzz 16 fizz 49 ", result);
        }

        [Fact]
        public void CreateEmptytreefizzbuzzTest()
        {

            k_ary_tree k_aryTree = new k_ary_tree();



            k_ary_tree k_ary = Program.callFizzBuzzTree(k_aryTree);




            Assert.Null(k_ary);

        }

    }
}   