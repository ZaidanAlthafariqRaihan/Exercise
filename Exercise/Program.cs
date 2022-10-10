using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
	class Program
	{
		// Deklarasi array int dengan ukuran 23
		private int[] a = new int[23];

		// Deklarasi variabel int untuk menyimpan banyaknya data pada array
		private int n;
		// Fungsi / Method untuk menerima masukan
		public void read()
		{
			// Menerima angka untuk menentukan banyaknya data yang disimpan pada array
			while (true)
			{
				Console.Write("Masukkan banyaknya elemen pada Array: ");
				string s = Console.ReadLine();
				n = Int32.Parse(s);
				if (n <= 23)
					break;
				else
					Console.WriteLine("\nArray dapat mempunyai maksimal 23 elemen. \n");
			}
			Console.WriteLine("");
			Console.WriteLine("------------------------");
			Console.WriteLine(" Masukkan elemen array ");
			Console.WriteLine("------------------------");

			// Pengguna memasukkan elemen pada array
			for (int i = 0; i < n; i++)
			{
				Console.Write("<" + (i + 1) + ">");
				string s1 = Console.ReadLine();
				a[i] = Int32.Parse(s1);
			}
		}
		public void display()
		{
			// Menampilkan array yang tersusun
			Console.WriteLine("");
			Console.WriteLine("---------------------------------");
			Console.WriteLine(" Elemen array yang telah tersusun ");
			Console.WriteLine("---------------------------------");
			for (int j = 0; j < n; j++)
			{
				Console.WriteLine(a[j]);
			}
			Console.WriteLine("");
		}

		public void BubbleSortArray()
		{
			for (int i = 1; i < n; i++)
			{
				// Pada pass i , bandingkan n - i elemen pertama dengan elemen selanjutnya
				for (int j = 0; j < n - 1; j++)
				{
					if (a[j] > a[j + 1]) // Jika elemen tidak dalam urutan yang benar
					{
						// Tukar elemen int temp;
						int temp;
						temp = a[j];
						a[j] = a[j + 1];
						a[j + 1] = temp;
					}
				}
			}
		}
		static void Main(string[] args)
		{
			// Creating the object of the Bubblesort class
			Program myList = new Program();

			// Pemanggilan fungsi untuk menerima elemen array
			myList.read();
			// Pemanggilan fungsi untuk mengurutkan array
			myList.BubbleSortArray();
			// Pemanggilan fungsi untuk menampilkan array yang tersusun
			myList.display();
			// Exit
			Console.WriteLine("\n\nTekan Tombol Apa Saja Jntuk Keluar. ");
			Console.Read();
		}
	}
}