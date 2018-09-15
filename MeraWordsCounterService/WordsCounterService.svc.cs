using MeraWordsCounter.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace MeraWordsCounterService
{
	public class WordsCounterService : IWordsCounterService
	{
		public WordsCounterService()
		{
			
		}

		public int GetWordCount(int textId)
		{
			return 5;
		}

		public List<Text> GetAvailableTexts()
		{
			return new List<Text>() { new Text() { Id = 1 }, new Text() { Id = 2 } };
		}
	}
}
