using UnityEngine;
using System.Collections.Generic;

namespace Assignment
{
    public class Lecture : MonoBehaviour
    {
        public void Start()
        {
            // LCT01_SyntaxList();
            // LCT02_SyntaxLinkedList();
            // LCT03_SyntaxHashTable();
             LCT04_SyntaxDictionary();
        }

        #region Lecture

        public void LCT01_SyntaxList()
        {
            throw new System.NotImplementedException();
        }

        public void LCT02_SyntaxLinkedList()
        {
            LinkedList<string> linkedList = new LinkedList<string>();
            linkedList.AddLast("Node 1");
            linkedList.AddLast("Node 2");
            linkedList.AddFirst("Node 0");
            PrintLinkList(linkedList);

            LinkedListNode<string> frisNode = linkedList.First;
            Debug.Log("first: " + frisNode.Value);
            LinkedListNode<string> lastNode = linkedList.Last;
            Debug.Log("last: " + lastNode.Value);
            LinkedListNode<string> node1 = linkedList.Find("Node 1");
            Debug.Log("node: " + node1.Value);
            Debug.Log(node1.Previous.Value);
            Debug.Log(node1.Next.Value);
            if (frisNode.Previous == null) { Debug.Log("firstNode.Previous is null"); }
            if (lastNode.Previous == null) { Debug.Log("lastNode.Next is null"); }

            linkedList.AddAfter(node1, "Node 1.5");
            linkedList.AddBefore(node1, "Node 0.5");
            PrintLinkList(linkedList);

            linkedList.RemoveFirst();
            PrintLinkList(linkedList);
            linkedList.Remove("Node 2");
            PrintLinkList(linkedList);
            linkedList.Clear();
            PrintLinkList(linkedList);
        }

        void PrintLinkList(LinkedList<string> linkedList)
        {
            Debug.Log("----- linkedList -----");
            foreach (string s in linkedList)
            {
                Debug.Log(s);
            }
        }

        public void LCT03_SyntaxHashTable()
        {
            throw new System.NotImplementedException();
        }

        public void LCT04_SyntaxDictionary()
        {
            Dictionary<int , string> dic = new Dictionary<int , string>();
            dic.Add(1, " Apple");
            dic.Add(2, " Banana");
            dic.Add(3, " Cherry");

            int keytocheck = 1;
            bool hasKey = dic.ContainsKey(keytocheck);
            Debug.Log($" has key {keytocheck} : {hasKey}");
            if ( hasKey )
            {
                Debug.Log(dic[keytocheck]);
            }

            foreach ( int key in dic.Keys )
            {
                Debug.Log(key);
            }
            foreach (string s  in dic.Values )
            {
                Debug.Log(s);
            }

            dic.Remove(1);
            foreach (string s in dic.Values)
            {
                Debug.Log(s);
            }

            dic.Clear();
            foreach (string s in dic.Values)
            {
                Debug.Log(s);
            }

        }

        #endregion
    }
}
