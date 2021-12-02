//written by Mav Pass
// 11/30/2021

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MavPASS_CIS122_20211130
{
	public class Library
	{
		//variables
		private List<Book> collectionOfBooks = new List<Book>();
		private List<Patron> listOfPatrons = new List<Patron>();

		//get and sets
		public List<Book> CollectionOfBooks { get { return this.collectionOfBooks; } set { this.collectionOfBooks = value; } }
		public List<Patron> ListOfPatrons { get { return this.listOfPatrons; } set { this.listOfPatrons = value; } }

		//constructor
		public Library()
		{ }

		//methods
		public Book BorrowBook()
		{
			return collectionOfBooks[0];
		}
		public void AddPatron(Patron aPatron)
		{
			ListOfPatrons.Add(aPatron);

		}
	}
}
