using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewQuestions
{
    // Interview question: Perform a deep copy of a doubly linked list where the next or previous pointers
    // may point to other nodes in the list. 

    public class DoubleLinkNode
    {
        public DoubleLinkNode PreviousNode { get; set; }
        public DoubleLinkNode NextNode { get; set; }
        public string Title { get; set; }

        public DoubleLinkNode(string title) : this()
        {
            Title = title;
        }

        public DoubleLinkNode()
        {
            this.PreviousNode = null;
            this.NextNode = null;
        }

        public override string ToString()
        {
            return Title;
        }

        public DoubleLinkNode CopyNode()
        {
            return new DoubleLinkNode()
            {
                Title = this.Title
            };
        }
    }

    public class DoubleLinkedList
    {
        private DoubleLinkNode m_Frist;
        
        public bool IsEmpty
        {
            get
            {
                return m_Frist == null;
            }
        }

        public DoubleLinkNode Insert(string title)
        {
            return this.Insert(new DoubleLinkNode(title));
        }

        public DoubleLinkNode Insert(DoubleLinkNode newNode)
        {
            return this.InsertLast(newNode);
        }

        public void InsertFirst(DoubleLinkNode newNode)
        {
            if (this.m_Frist == null)
            {
                // This is the first node now
                this.m_Frist = newNode;
            }
            else
            {
                newNode.NextNode = this.m_Frist;
                this.m_Frist.PreviousNode = newNode;
            }
        }

        public void InsertAfter(DoubleLinkNode node, DoubleLinkNode newNode)
        {
            newNode.NextNode = node.NextNode;
            node.NextNode = newNode;
            newNode.PreviousNode = node;
            newNode.NextNode.PreviousNode = newNode;
        }

         public void InsertBefore(DoubleLinkNode node, DoubleLinkNode newNode)
        {
            var previousNode = node.PreviousNode;

            newNode.PreviousNode = previousNode;
            newNode.NextNode = node;

            previousNode.NextNode = newNode;
            node.PreviousNode = newNode;
        }

        public DoubleLinkNode InsertLast(DoubleLinkNode newNode)
        {
            // Starting at the head to find the last node in the list
            DoubleLinkNode currentNode = this.m_Frist;
            var previousNode = this.m_Frist;
            while(currentNode != null)
            {
                previousNode = currentNode;
                currentNode = currentNode.NextNode;
            }

            if (previousNode == null)
            {
                this.InsertFirst(newNode);
            }
            else
            {
                // Current node is now pointing to the last node in the list
                previousNode.NextNode = newNode;
                newNode.PreviousNode = previousNode;
                newNode.NextNode = null;
            }

            return newNode;
        }

        public DoubleLinkNode GetLastNode()
        {
            DoubleLinkNode currentNode = this.m_Frist;
            DoubleLinkNode previousNode = this.m_Frist;

            while(currentNode != null)
            {
                previousNode = currentNode;
                currentNode = currentNode.NextNode;
            }

            return previousNode;
        }

        public DoubleLinkedList DeepCopy()
        {
            var newList = new DoubleLinkedList();
            DoubleLinkNode currentNode = this.m_Frist;

            var newNode = currentNode.CopyNode();
            newList.Insert(newNode);
            
            currentNode = currentNode.NextNode;

            while(currentNode != null)
            {
                newNode = currentNode.CopyNode();
                newList.Insert(newNode);
                currentNode = currentNode.NextNode;
            }

            currentNode = this.GetLastNode();

            return newList;
        }
    }
}
