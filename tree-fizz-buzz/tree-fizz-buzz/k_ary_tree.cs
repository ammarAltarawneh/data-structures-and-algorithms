using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

namespace tree_fizz_buzz
{
    public class k_ary_tree
    {
        public K_ary_Tree_Node root { get; set; }

        public k_ary_tree()
        {

        }
        public k_ary_tree(string value)
        {
            this.root.Value = value;
        }
    }
}
