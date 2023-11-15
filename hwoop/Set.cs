using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace hwoop
{
    public class Set
    {
        #region Exceptions
        public class EmptySetException : Exception { };
        // public class IndexOutOfRangeException : Exception { };
        public class ElementNotFoundException : Exception { };
        #endregion
        private List<int> sequence;
        public Set() {
            this.sequence = new List<int>();
        }
        public void Addit(int val)
        {
            int temp = 1;
            for (int i = 0; i < sequence.Count; i++)
            { if (this.sequence[i] == val)
                {
                    temp = 0;
                    break;
                } }
            if (temp == 1)
            { this.sequence.Add(val); }

        }

    

        //  }


        public override string ToString()
        {
            return string.Join(" ", sequence );
        }
    
    
        public void Remove(int val)
        {

            int temp = 1;
            if (sequence.Count > 0)
            {
                for (int i = 0; i < sequence.Count; i++)
                {
                    if (this.sequence[i] == val)
                    {
                        temp = 0;
                        break;
                    }
                }
                if (temp == 0)
                { this.sequence.Remove(val); }

                else
                { throw new ElementNotFoundException(); }
            }
            else { throw new EmptySetException(); }

        }
        public bool IsEmpty()
        {

            return this.sequence.Count == 0;
             
        }
        public bool Contains(int a)
        {
            int temp = 1;
            if (sequence.Count > 0)
            {
                for (int i = 0; i < sequence.Count; i++)
                {
                    if (this.sequence[i] == a)
                    {
                        temp = 0;
                        break;
                    }
                }
                if (temp == 0)
                { return true; }

                else return false;
            }
            else throw new EmptySetException();
        }

        
         
        public int Random()
        {
            Random rand = new Random();
            
            if (this.sequence.Count > 0) {
           
            return (this.sequence[rand.Next(sequence.Count)]);
            }
            else {
                throw new EmptySetException();
               }   //  return 0; }
        }

        public int Sum() {
            if (sequence.Count == 0) throw new EmptySetException();
            else { 
       int sum = 0;
            for(int i=0; i<sequence.Count;i++)
            {
sum += sequence[i];
            }
            return sum;
                }
       }
   
       
    }
}
