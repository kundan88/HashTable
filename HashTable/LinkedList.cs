using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{
    class LinkedList<K, V> where K : IComparable
    {
        //Linked list Node created with key-value pair
        public MyMapNode<K, V> head;
        public MyMapNode<K, V> tail;

        public LinkedList()
        {
            head = null;
            tail = null;
        }
        public MyMapNode<K, V> Search(K key)
        {
            //Head will assign as temp
            MyMapNode<K, V> temp = head;
            while (temp != null)
            {
                if (temp.key.Equals(key))
                    return temp;
                temp = temp.next;
            }
            return null;
        }
        public void Append(MyMapNode<K, V> node)
        {
            //Check node is present or not
            if (head == null && tail == null)
            {
                head = node;
                tail = node;
            }
            else
            {
                //If present then node added from the End
                tail.next = node;
                tail = node;
            }
        }
    }
}
