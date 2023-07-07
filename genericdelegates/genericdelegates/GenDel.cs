using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace genericdelegates
{
    internal class GenDel<T> where T : Exception
    {
        /* private T rollno;

         public GenDel(T roll)
         {
             this.Rollno = roll;
         }

         public T Rollno { get => rollno; set => rollno = value; }
        */
        /*
        private T[] arr;

        public GenDel(int size)
        {
            arr = new T[size];
        }

        public T getarr(int index)
        {
            return arr[index];
        }
        public void setarr(int index, T value)
        {
            arr[index] = value;
        }
        */
        /*
        private T message;

        public GenDel(T message)
        {
            this.Message = message;
        }
        public T disp()
        {
            return Message;
        }
        public T Message { get => message; set => message = value; }
        */


    }
}
