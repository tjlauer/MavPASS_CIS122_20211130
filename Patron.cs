//written by Mav Pass
// 11/30/2021

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MavPASS_CIS122_20211130
{
	public class Patron
	{
		//variables
		private int patronID = -1;
		private string lastName = "n/a";
		private string firstName = "n/a";
		private List<Book> borrowedBooks = new List<Book>();

		//gets and sets
		public int PatronID { get { return this.patronID; } set { this.patronID = value; } }
		public string LastName { get { return this.lastName; } set { this.lastName = value; } }
		public string FirstName { get { return this.firstName; } set { this.firstName = value; } }
		public List<Book> BorrowedBooks { get { return this.borrowedBooks; } set { this.borrowedBooks = value; } }

		//constuctor
		public Patron() : this(-1, "n/a", "n/a")
		{ }
		public Patron(int aPatronID, string aLastName, string aFirstName)
		{
			this.PatronID = aPatronID;
			this.LastName = aLastName;
			this.FirstName = aFirstName;
		}

		//methods
		public void Borrowed(Book aBook)
		{
			BorrowedBooks.Add(aBook);
		}
		public override string ToString()
		{
			string msg = "";
			msg += $"Patron ID: {this.PatronID}. Last Name: {this.LastName}. First Name: {this.FirstName}. \n";
			foreach (Book b in BorrowedBooks)
			{
				msg += b.ToString();
			}
			return msg;
		}

	}
}
