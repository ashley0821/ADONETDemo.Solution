﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Func<string, bool, Person> funcA = (title, gender) => new Person { Name = title, Gender = gender };
			Person ashley = Demo.Parse<Person>("Ashley", true, funcA);

			Func<string, bool, Pet> funcB = (title, gender) => new Pet { NickName = title, Gender = gender };
			Pet nana = Demo.Parse<Pet>("Nana", true, funcB);
		}
	}

	public class Demo
	{
		public static T Parse<T>(string title, bool gender, Func<string, bool, T> func)
		{
			return func(title, gender);
		}
	}

	public class Person
	{
		public string Name { get; set; }
		public bool Gender { get; set; }
	}

	public class Pet
	{
		public string NickName { get; set; }//小名
		public bool Gender { get; set; }
	}
}
