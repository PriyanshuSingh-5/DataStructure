using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using DataStructure;

namespace MSTestDataStructure
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]

        [DataRow(30, true)]
        [DataRow(45, false)]
        public void Search_PassANodeValue_ReturnTrueOrFalse(int data, bool flag) //search a node
        {
            LinkedList list = new LinkedList();
            list.InsertFront(56);
            list.InsertFront(30);
            list.InsertFront(70);
            bool flagReturned = list.Search(data);
            Assert.AreEqual(flag, flagReturned);
        }

        [TestMethod]
        [DataRow(40, 30, true)]
        [DataRow(45, 55, false)]
        public void InsertAfter_ReturnTrueOrFalse(int data, int previousNode, bool flag) //insert in between
        {
            LinkedList list = new LinkedList();
            list.InsertFront(56);
            list.InsertFront(30);
            list.InsertFront(70);
            bool flagReturned = list.InsertAfter(data, previousNode);
            Assert.AreEqual(flag, flagReturned);
        }

        [TestMethod]
        [DataRow(40, true)]
        [DataRow(45, false)]
        public void DeleteAny_PassAValueToBeDeleted_ReturnTrueOrFalse(int data, bool flag) //delete any value
        {
            LinkedList list = new LinkedList();
            list.InsertFront(56);
            list.InsertFront(30);
            list.InsertFront(40);
            list.InsertFront(70);
            bool flagReturned = list.DeleteAny(data);
            Assert.AreEqual(flag, flagReturned);
        }
    }
}

