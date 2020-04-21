using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusteriTakip
{
   public class OncelikKuyruk : IQueue
    {
        private object[] Queue;
        private int front = -1;
        private int size = 0;
        private int count = 0;
        public float TamamlamaSuresi { get; set; }
        public OncelikKuyruk(int size)
        {
            this.size = size;
            Queue = new object[size];
            TamamlamaSuresi = 0;
        }
        public float OrtalamaIslemTamamlamaSuresiHesapla()
        {
            return TamamlamaSuresi / 20;
        }

        public void Insert(object o)
        {
            if (count == size)
            {
                throw new Exception("Queue is full");
            }

            if (IsEmpty())
            {
                front++;
                Queue[front] = o;
                count++;
            }
            else
              {
                int i;
                for (i = count - 1; i >= 0; i--)
                {
                    if (((Musteri)o).IslemSuresi > ((Musteri)Queue[i]).IslemSuresi)
                    {
                        Queue[i +1] = Queue[i];

                    }
                    else
                        break;     
                }
                    Queue[i+1] = o;
                    front++;
                    count++;
            

            }
        }




        public bool IsEmpty()
        {
            return (count == 0);

        }

        public object Peek()
        {
            return Queue[front];
            
        }

        public object Remove()
        {
            if (this.IsEmpty())
            {
                throw new Exception("Queue is empty...");
            }
            object temp = Queue[front];
            TamamlamaSuresi +=((Musteri)temp).IslemSuresi ;
            Queue[front] = null;
            front--;
            count--;
            return temp;
        }


    }
}


