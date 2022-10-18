using System;
using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace B22_Ex01_Alex_324777424_Lior_208678425
{
    public class FacebookSearch
    {
		public List<string> Search(object i_SelectedItem, string i_SearchStr)
		{
			List<string> searchResult = new List<string>();
			SearchSomething(i_SelectedItem, i_SearchStr, searchResult);

			return searchResult;
		}

		private void SearchSomething(object i_Obj, string i_SearchStr, List<string> i_SearchResult)
		{
			string newObj = null;
			if (i_Obj != null)
			{
				if (i_Obj is Event)
				{
					newObj = (i_Obj as Event).Name;
				}
				else if (i_Obj is User)
				{
					newObj = (i_Obj as User).Name;
				}
				else if (i_Obj is string)
				{
					newObj = i_Obj as string;
				}
				else if (i_Obj is Group)
				{
					newObj = (i_Obj as Group).Name;
				}
				else if (i_Obj is Status)
				{
					newObj = (i_Obj as Status).Message;
				}

				if (newObj != null)
				{
					if (newObj.IndexOf(i_SearchStr, StringComparison.OrdinalIgnoreCase) >= 0)
					{
						int location = 0;
						int size = 60;
						while (newObj.Length > location + size)
						{
							i_SearchResult.Add(newObj.ToString().Substring(location, size));
							location += size;
						}

						i_SearchResult.Add(newObj.ToString().Substring(location));
						i_SearchResult.Add(Environment.NewLine);
					}
				}
			}
		}
	}
}
