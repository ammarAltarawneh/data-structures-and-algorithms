using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hash_Table_Challenge
{
    public class Bucket
    {
        public string key;
        public string value;
        public Bucket Next;
        public Bucket(string key, string value)
        {
            this.key = key;
            this.value = value;
        }
    }
}
