using System;

public class Book
{
	private string _name;
	private string _category;

	public string Name
	{
		get { return _name; }
		set
		{
			_name = value;
		}
	}

	public string Category
	{
		get { return _category; }
		set
		{
			_category = value;
		}
	}
}



class Program
{
	static void Main(string[] args)
	{
		// Book book1 = new Book('Lord of The Rings', 'Fantasy');
		Book book1 = new Book();
		book1.Name = 'Lord of The Rings';
		book1.Category = 'Fantasy';
		Console.WriteLine(book1.Name);
		Console.WriteLine(book1.Category);
	}
}