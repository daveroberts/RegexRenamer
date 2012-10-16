using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RegexRenameLib;

namespace Tester
{
	class Program
	{
		static void Main(string[] args)
		{
			string filename = "survivormanS10E04.avi";
			string what = Renamer.newname(filename, @"survivormans\d+e\d+.*?\.avi$", "hyuk");
			Console.WriteLine(what);
			Console.ReadLine();
		}
	}
}
