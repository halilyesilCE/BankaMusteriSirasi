using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusteriTakip
{
    public class DaireselKuyruk : IQueue
    {
        private object[] Queue;
        private int front = -1;
        private int rear = -1;
        private int size = 0;
        private int count = 0;
        public float TamamlamaSuresi { get; set; }
        public float OrtalamaIslemTamamlanmaSuresi { get; set; }
        public DaireselKuyruk(int size)
        {
            this.size = size;
            Queue = new object[size];
           TamamlamaSuresi  = 0;

    }
        private void OrtalamaIslemTamamlamaSuresiHesapla()
        {
            OrtalamaIslemTamamlanmaSuresi = TamamlamaSuresi / 20;

        }

    public void Insert(object o)
        {
            if (count == size)
                throw new Exception("Queue dolu.");

            if (front == -1)
                front = 0;

            if (rear == size - 1)
            {
                rear = 0;
                Queue[rear] = o;
            }
            else
                Queue[++rear] = o;

            count++;
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
         
            if (IsEmpty())
            {
                throw new Exception("queue Boş");
            }
            
            object temp = Queue[front];
            Queue[front] = null;

            if (front == size - 1)
                front = 0;
            else
                front++;

            TamamlamaSuresi += ((Musteri)temp).IslemSuresi ;
            count--;

            if (count == 0)
            {
                OrtalamaIslemTamamlamaSuresiHesapla();
            }
            return temp;

        }
    }
}
