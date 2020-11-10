using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeTask7
{
    public enum action {add, sub, zero, mul2}
    //public delegate string act(action action);
    class doubler
    {
        uint counter = 0;
        uint result = 1;
        ushort goal;
        public ushort Goal 
        { get 
            {
                Random Goal = new Random();
                goal= (ushort)Goal.Next(4048);
                return goal;
            } 
          set{}
        }
        public Stack<uint> ListAction = new Stack<uint>();

        public string ChangeCount(action action)
        {
            switch (action)
            {
                case action.add:
                    counter++;
                    break;
                case action.sub:
                    counter--;
                    break;
                case action.zero:
                    counter = 0;
                    break;      
            }
            return counter.ToString();
        }
        public string ChangeResult(action action)
        {
            switch (action)
            {
                case action.add:
                    result++;
                    break;
                case action.mul2:
                    result *= 2;
                    break;
                case action.zero:
                    result = 1;
                    break;
                case action.sub:
                    ListAction.Pop();
                    result = ListAction.Peek();
                    return result.ToString();
            }
            ListAction.Push(result);
            return result.ToString();
        }
        public bool CheckResult(string val1)
        {
            return ushort.Parse(val1) == goal;
        }
      
    }
}
