using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dynamicCollection
{
	class Program
	{
		static void Main(string[] args)
		{
			DynamicCollection<int> d = new DynamicCollection<int>();
			d.Add(10);
			d.Add(20);
			d.Add(30);
			d.Add(40);
			//for (int i = 0; i < d.Length; i++)
			//{
			//	//Indexers
			//	Console.WriteLine(d[i]);
			//}

			//foreach (var item in d)
			//{
			//	Console.WriteLine(item);
			//}


			//--------------------------------LIST--------------------------------------
			//List<int> no = new List<int>() { 67, 566, 345, 2222 };//vector	    
			//no.Add(600);

			//no.Sort();
			//no.Reverse();
			//no.RemoveAt(1);
			//no.ToString();
			//foreach (var i in no)					    
			//{										    
			//	Console.WriteLine(i);				    
			//}										    
			//no.TrimExcess();						    


			List<Item> items = new List<Item>();
			Item i1 = new Item { ItemID = 111, name = "yolk", price = 34 };
			Item i2 = new Item { ItemID = 111, name = "key", price = 89 };
			Item i3 = new Item { ItemID = 111, name = "kite", price = 50 };
			items.Add(i1);
			//List<Item> iP = new List<Item>();
			List<Item> SortedList = items.OrderBy(o => o.price).ToList();
			Console.WriteLine(SortedList[1].name + "\t" + SortedList[1].price);

			//foreach (var item in SortedList)
			//{
			//	//Console.WriteLine(item.name + "\t" + item.price);
				

			//}


		}											    
	}	
	

	class Item
	{
		public int ItemID { get; set; }
		public string name { get; set; }
		public double price { get; set; }
	}
	class DynamicCollection<T> : IEnumerable
	{
		private T[] a = new T[1];
		int index = 0;
		
		public void Add(T ele)

		{ if (index >= a.Length)
			{
				//int[] arr = new int[a.Length + 1];
				//Array.Copy(a, arr, a.Length);
				////moving reference to new array
				//a = arr;
				Array.Resize(ref a, a.Length + 1);
			}
			a[index++] = ele;
		}
		public int Length { get { return index; } }
		public T this[int index]
		{
			get { return a[index]; }
			set { Add(value); }
		}
		public T Get(int index)
		{

			return a[index];
		}
		IEnumerator IEnumerable.GetEnumerator()
		{
			return a.GetEnumerator();
		}
	}					      
}													    
													    