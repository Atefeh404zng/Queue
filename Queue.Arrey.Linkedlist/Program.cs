using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue.Arrey.Linkedlist
{
	class Program
	{
		class QueueArrey
		{
			//پیاده سازی صف با ارایه حلقوی
			public int[] queuearrey;
			public int size;
			//size koli barae array
			public int count ;
			//meghdar khane hae por dar arrey
			public int rear;
			public int front;
			bool Ntt = false;
			public static void Create()
			{
				QueueArrey firstqueue = new QueueArrey();
				firstqueue.size = 20;
				firstqueue.count = 0;
				firstqueue.front = firstqueue.rear;

			}
			public static int Size(QueueArrey firstqueue)
			{
				firstqueue.count=(firstqueue.size -firstqueue.front+firstqueue.rear)%firstqueue.size;
				return firstqueue.count;
			}
			public static Boolean IsEmpty(QueueArrey firstqueue)
			{
				if (firstqueue.count == 0)
				{
					firstqueue.Ntt = true;
				}
				else
					firstqueue.Ntt = false;
				return firstqueue.Ntt;
			}
			public static int FrontElement(QueueArrey firstqueue)
			{
				if (firstqueue.Ntt)
					throw new Exception("صف خالی است");
				
				return firstqueue.queuearrey[firstqueue.front];

			}
			public static void Enqueue(QueueArrey firstqueue,int d)
			{
				if (firstqueue.count == firstqueue.size)
					throw new Exception("صف پر است");

				firstqueue.queuearrey[firstqueue.rear] = d;
				firstqueue.rear = (firstqueue.rear + 1) % firstqueue.size;
				firstqueue.count++;
			}
			public static int Dequeue(QueueArrey firstqueue)
			{
				int temp = firstqueue.queuearrey[firstqueue.front];
				firstqueue.queuearrey[firstqueue.front] = 0;
				firstqueue.count--;
				firstqueue.front = (firstqueue.front+1) % firstqueue.size;
				return temp;
			}
		}
		public class QueueLinkedlist
		{
			//پیاده سازی صف با بیست پیوندی 
			public class Node
			{
				public int amount;
				public Node nextaddres;
			}
			public class Listdetail
			{
				public int ssize;
				//size koli list
				public int ccount;
				public Node front;
				public Node rear;
				public Boolean Mns;
			}
			public static Listdetail CCreate()
			{
				Listdetail secondqueue = new Listdetail();
				secondqueue.ssize = 20;
				secondqueue.front = secondqueue.rear;
				secondqueue.ccount = 0;
			
				return secondqueue;
			}
			public static int SSize(Listdetail secondlist)
			{
				return secondlist.ccount;
			}
			public static Boolean IIsempty(Listdetail secondqueue)
			{
				if (secondqueue.ccount == 0)
				{
					return secondqueue.Mns = true;
				}
				else
					secondqueue.Mns = false;
				return secondqueue.Mns;
			}
			public void EEnqeue(Listdetail secondlist,int s)
			{
				Node Ftp = new Node();
				Ftp.amount = s;
				secondlist.rear.nextaddres = Ftp;
				Ftp = secondlist.rear;
				secondlist.ccount++;
			}
			public int DDequeue(Listdetail secondlist)
			{
				Node Ssd = new Node();
				Ssd.amount = secondlist.front.amount;
				secondlist.front.nextaddres= secondlist.front;
				//nemidunam  ki mosavi chi mishe?
				secondlist.ccount--;
				//free node??
				return Ssd.amount;

			}

		}
		static void Main(string[] args)
		{
		}
	}
}
