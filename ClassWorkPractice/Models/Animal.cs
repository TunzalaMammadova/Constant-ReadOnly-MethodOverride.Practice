using System;

public class Animal
{
	public int Id { get; set; }
	
	public virtual void Sound()
	{
		Console.WriteLine("Animal sound");
	}

}

