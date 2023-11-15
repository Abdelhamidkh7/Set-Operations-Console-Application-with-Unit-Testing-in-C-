using System;
using System.Collections.Generic;
using System.Linq;
using hwoop;




namespace TestProject1
{
    [TestClass]
    public class SetTests
    {
        [TestMethod]
        public void InsertTest()
        {
            Set set = new Set();
            set.Addit(3);
            set.Addit(100);
            set.Addit(0);
            set.Addit(-2);
            set.Addit(10);
            Assert.AreEqual("3 100 0 -2 10", set.ToString());
        }
    




        
        [TestMethod]
        public void RemoveTest()
        {
            Set set = new Set();
            set.Addit(12);
            set.Addit(30);
            set.Addit(3);
            set.Remove(30);
            set.Addit(-23);
            set.Remove(12);
            

            Assert.AreEqual("3 -23", set.ToString());
            set.Remove(3);
            set.Remove(-23);
            //set.Remove(100);
            Assert.ThrowsException<Set.EmptySetException>(() => set.Remove(2));
            set.Addit(4);
            Assert.ThrowsException<Set.ElementNotFoundException>(() => set.Remove(1));

        }
        [TestMethod]
        
        public void SetEmptyTest()
        {
            Set a = new Set();
            Assert.IsTrue(a.IsEmpty());

            a.Addit(20);

            Assert.IsFalse(a.IsEmpty());
        }

        [TestMethod]
        public void SetContainsTest()
        {
            Set a = new Set();
            a.Addit(20);
            Assert.IsTrue(a.Contains(20));

            

            Assert.IsFalse(a.Contains(100));
            Assert.IsFalse(a.Contains(-10));
        }
        [TestMethod]
        public void RandomElementTest()
        {
            Set a = new Set();
            a.Addit(20);
            Assert.AreEqual(20, a.Random());
            a.Addit(-20);
            a.Addit(34);
            Assert.IsTrue(a.Contains(a.Random()));
            a.Remove(20);
            a.Remove(-20);
            a.Remove(34);
            Assert.ThrowsException<Set.EmptySetException>(() => a.Random());
        }
        [TestMethod]
        public void SumTest()
        { Set a=new Set();
            a.Addit(20);
            Assert.AreEqual(20, a.Sum());
            a.Addit(15);
            a.Addit(10);
            Assert.AreEqual(45, a.Sum());
            a.Addit(-4);
                Assert.AreEqual(41,a.Sum());
            a.Remove(20);
            a.Remove(15);
            a.Remove(10);
            a.Remove(-4);
            Assert.ThrowsException<Set.EmptySetException>(() => a.Sum());
        }
       
    }
}

