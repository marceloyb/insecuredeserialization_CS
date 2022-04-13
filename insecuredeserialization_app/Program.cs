using System;
using System.IO;
using System.Web.Script.Serialization;

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
		// Setting console to accept more than 254 char
		Console.SetIn(new StreamReader(Console.OpenStandardInput(), Console.InputEncoding, false, bufferSize: 1024));

		// Instantiating serializer in insecure mode
		JavaScriptSerializer serializer = new JavaScriptSerializer(new SimpleTypeResolver());

		// Initializing book object and serializing it
		Book book1 = new Book();
		book1.Name = "Lord of The Rings";
		book1.Category = "Fantasy";

		var jsonBook = serializer.Serialize(book1);

		// Print Book JSON
		Console.WriteLine("Json content: \n" + jsonBook);

		// Read new JSON and deserialize it into Book object
		Console.WriteLine("\nInsert modified JSON: ");
		string editedBookJson = Console.ReadLine();

		Book lotrBook = serializer.Deserialize<Book>(editedBookJson);
		Console.WriteLine("Book object name (post JSON deserialization): " + lotrBook.Name);
		Console.WriteLine("Book object category (post JSON deserialization): " + lotrBook.Category);
	}
}