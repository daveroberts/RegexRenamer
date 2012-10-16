using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace RegexRenameLib
{
	public class Renamer
	{
		public static bool matches(string oldname, string pattern)
		{
			try
			{
				Regex r = new Regex(pattern);
				Match match = Regex.Match(oldname, pattern, RegexOptions.IgnoreCase);
				return match.Success;
			}
			catch
			{
				return false;
			}
		}
		public static string newname(string oldname, string pattern, string newName)
		{
			try
			{
				Regex r = new Regex(pattern);
				Match match = Regex.Match(oldname, pattern, RegexOptions.IgnoreCase);
				if (match.Success)
				{
					string newReturn = newName;
					for(int i = 0; i < match.Groups.Count; i++)
					{
						if (i == 0)
						{
							continue;
						}
						string sMatch = match.Groups[i].Value;
						if (newReturn.Contains("\\" + i))
						{
							newReturn = newReturn.Replace("\\" + i, sMatch);
						}
					}
					return newReturn;
				}
				else
				{
					return "";
				}
			}
			catch
			{
				return "error";
			}
		}
	}
}
