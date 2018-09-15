using MeraWordsCounter.Model;
using System.Collections.Generic;
using System.ServiceModel;

namespace MeraWordsCounterService
{
	// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
	[ServiceContract]
	public interface IWordsCounterService
	{

		[OperationContract]
		int GetWordCount(int textId);

		[OperationContract]
		List<Text> GetAvailableTexts();
	}
}
