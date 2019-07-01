using System.Linq;
using System.Threading.Tasks;
using Alsein.Extensions;

namespace Cynthia.Card
{
	[CardEffectId("54013")]//维里赫德旅先锋
	public class VriheddVanguard : CardEffect
	{//使所有“精灵”友军获得1点增益。 每次被交换时，再次触发此能力。
		public VriheddVanguard(GameCard card) : base(card){}
		public override async Task<int> CardPlayEffect(bool isSpying,bool isReveal)
		{
			return 0;
		}
	}
}