using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{
    //Creating Key Value pair Hash table
    public class MyMapNode<K, V>
    {
        public K key;
        public V value;
        public MyMapNode<K, V> next;

        public MyMapNode(K key, V value)
        {
            this.key = key;
            this.value = value;
            next = null;
        }
    }
}
