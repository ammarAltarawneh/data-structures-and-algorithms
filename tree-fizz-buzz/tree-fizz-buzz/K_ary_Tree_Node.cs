using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tree_fizz_buzz
{
    public class K_ary_Tree_Node
    {
        public string Value { get; set; }


        public List<K_ary_Tree_Node> Children = new List<K_ary_Tree_Node>();

        public K_ary_Tree_Node()
        {

        }
        public K_ary_Tree_Node(string value)
        {
            Value = value;
        }

        public void addChildren(K_ary_Tree_Node child)
        {

            Children.Add(child);
        }
    }
}
