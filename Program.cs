using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MavPASS_CIS122_20211130
{
	public class Program
	{
		public static void Main(string[] args)
		{
			// A library has a Collection of books.
			// A Book has an Author with a First and Last Name, a Title, and an ISBN number.
			// A Collection has a method BorrowBook() which returns a single book from the collection.
			// Do NOT delete the book from the collection – you could, but it is not necessary for this problem.

			// A library Patron has an PatronId number, a First Name, a Last Name and a list of borrowed books.
			// They may Borrow() books.

			// Create the appropriate classes.
			// Populate the Library Collection with 10 books.
			// Create two Patrons.
			// Have each Patron borrow 5 books.

			// In Main, print out both the Library’s collection of books,
			// and then the Patrons’ information, including the Patrons’ Names, PatrondDs
			// and the complete information of all the Patrons’ borrowed book
			Library OurLibrary = new Library();
			OurLibrary.CollectionOfBooks.Add(new Book());
			OurLibrary.CollectionOfBooks.Add(new Book());
			OurLibrary.CollectionOfBooks.Add(new Book());
			OurLibrary.CollectionOfBooks.Add(new Book());
			OurLibrary.CollectionOfBooks.Add(new Book());
			OurLibrary.CollectionOfBooks.Add(new Book());
			OurLibrary.CollectionOfBooks.Add(new Book());
			OurLibrary.CollectionOfBooks.Add(new Book());
			OurLibrary.CollectionOfBooks.Add(new Book());
			OurLibrary.CollectionOfBooks.Add(new Book());
			OurLibrary.CollectionOfBooks.Add(new Book());

			OurLibrary.AddPatron(new Patron());
			OurLibrary.AddPatron(new Patron());

			OurLibrary.ListOfPatrons[0].Borrowed(new Book());
			OurLibrary.ListOfPatrons[0].Borrowed(new Book());
			OurLibrary.ListOfPatrons[0].Borrowed(new Book());
			OurLibrary.ListOfPatrons[0].Borrowed(new Book());
			OurLibrary.ListOfPatrons[0].Borrowed(new Book());

			OurLibrary.ListOfPatrons[1].Borrowed(new Book());
			OurLibrary.ListOfPatrons[1].Borrowed(new Book());
			OurLibrary.ListOfPatrons[1].Borrowed(new Book());
			OurLibrary.ListOfPatrons[1].Borrowed(new Book());
			OurLibrary.ListOfPatrons[1].Borrowed(new Book());

			foreach (Book b in OurLibrary.CollectionOfBooks)
			{
				Console.WriteLine(b.ToString());
			}

			foreach (Patron p in OurLibrary.ListOfPatrons)
			{
				Console.WriteLine(p.ToString());
			}

			try
			{
				string example = File.ReadAllText("");
			}
			catch (FileNotFoundException e)
			{
				Console.WriteLine("The File not found!");
			}
			catch (Exception e)
			{
				Console.WriteLine("You have an error!" + e.ToString());
			}
			finally
			{
				// Shutting down!!!
				Console.WriteLine("Doing stuff");
			}



			Console.ReadLine();
		}
	}
}
