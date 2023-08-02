using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Liste
    {
        public Node head;

        public Liste()
        {
            head = null;
        }

        public void basaEkle(int data)
        {
            Node node = new Node(data);

            if(head == null)
            {
                head = node;
                Console.WriteLine("Liste oluşturuldu,başa ekleme yapıldı");
            }
            else
            {
                node.next = head;
                head = node;
                Console.WriteLine("Başa ekleme yapıldı");
            }
        }

        public void sonaEkle(int data)
        {
            Node node = new Node(data);
            if(head == null)
            {
                head=node;
                Console.WriteLine("Liste oluşturuldu,ekleme yapıldı");
            }
            else
            {
                Node temp = head;
                while(temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
                Console.WriteLine("Sona ekleme yapıldı.");
            }
        }

        public void arayaEkle(int data)
        {
            Node newNode = new Node();
            newNode.data = data;

            if (head == null)
            {
                Console.WriteLine("Liste Boş!");
            }
            else
            {
                Node temp = head;
                Node prevNode = null;

                // Eklenecek düğümün verisi, geçici düğümün verisinden büyük olduğu sürece
                // listenin sonuna kadar gezin ve doğru konumu bulun
                while (temp != null && data >= temp.data)
                {
                    prevNode = temp;
                    temp = temp.next;
                }

                // prevNode, yeni düğümün ekleneceği konumdaki önceki düğümü gösterir
                // temp, yeni düğümün ekleneceği konumdaki sonraki düğümü gösterir

                // Yeni düğümü doğru konuma ekleyin
                newNode.next = temp;
                prevNode.next = newNode;
            }
        }

        public void yazdir()
        {
            if(head == null)
            {
                Console.WriteLine("Liste boş");
            }
            else
            {
                Node temp = head;
                while(temp != null)
                {
                    
                    Console.WriteLine(temp.data);
                    temp = temp.next;
                }
            }
        }

        public void bastanSil()
        {
            Node node = new Node();
            if ( head == null)
            {
                Console.WriteLine("Liste yok!");
            }
            else
            {
                head = head.next;

            }
        }

        public void sondanSil()
        {
            Node temp = head;
            Node temp2 = temp;
            if(head == null)
            {
                Console.WriteLine("Liste yok!");
            }
            else
            {
                while(temp.next != null)
                {
                    temp2 = temp;
                    temp = temp.next;
                }
                temp2.next = null;
                Console.WriteLine("Sondan eleman silindi.");
            }
        }



    }
}
