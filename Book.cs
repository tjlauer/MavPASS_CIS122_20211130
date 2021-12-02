//written by Mav Pass
// 11/30/2021

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MavPASS_CIS122_20211130
{
	public class Book
	{
		//variables
		private string lastName = "n/a";
		private string firstName = "n/a";
		private string title = "n/a";
		private int iSBN = -1;

		//gets and sets
		public string LastName { get { return this.lastName; } set { this.lastName = value; } }
		public string FirstName { get { return this.firstName; } set { this.firstName = value; } }
		public string Title { get { return this.title; } set { this.title = value; } }
		public int ISBN { get { return this.iSBN; } set { this.iSBN = value; } }

		//constructors
		public Book() : this("n/a", "n/a", "n/a", -1)
		{ }
		public Book(string aLastName, string aFirstName, string aTitle, int anISBN)
		{
			this.LastName = aLastName;
			this.FirstName = aFirstName;
			this.Title = aTitle;
			this.ISBN = anISBN;
		}

		//methods
		public override string ToString()
		{
			string msg = "";
			msg += $"Last Name: {this.LastName}. First Name: {this.FirstName}. Title: {this.Title}. ISBN: {this.ISBN} \n";
			return msg;
		}
	}
}
