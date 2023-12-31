﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hash_Table_Challenge
{
    public class HashTable
    {
        Bucket[] hashTable = new Bucket[1024];
        public void Set(string key, string value)
        {
            int index = Hash(key);
            Bucket bucket = new Bucket(key, value);

            if (hashTable[index] == null)
            {
                hashTable[index] = bucket;
            }
            else
            {
                Bucket current = hashTable[index];
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = bucket;
            }
        }
        public string Get(string key)
        {
            int index = Hash(key);
            Bucket current = hashTable[index];
            while (current != null)
            {
                if (current.key == key)
                {
                    return current.value;
                }
                current = current.Next;
            }
            return null;
        }

        public bool Has(string key)
        {
            int index = Hash(key);
            Bucket current = hashTable[index];
            while (current != null)
            {
                if (current.key == key)
                {
                    return true;
                }
                current = current.Next;
            }
            return false;
        }

        public List<string> Keys()
        {
            List<string> keys = new List<string>();
            for (int i = 0; i < hashTable.Length; i++)
            {
                Bucket current = hashTable[i];
                while (current != null)
                {
                    keys.Add(current.key);
                    current = current.Next;
                }
            }
            return keys;
        }
        public int Hash(string key)
        {
            int hash = 483;
            for (int i = 0; i < key.Length; i++)
            {
                hash += key[i];
            }
            return hash % 1024;
        }

        public static string RepeatedWord(string input)
        {
            HashTable hash = new HashTable();
            input = input.Replace(",", string.Empty);
            string[] words = input.ToLower().Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                if (hash.Has(words[i]))
                {
                    return hash.Get(words[i]);
                }
                hash.Set(words[i], words[i]);
            }

            return "nothing repeated";
        }

    }
}
