using System.Linq;
using System.Threading.Tasks;
using Alsein.Extensions;

namespace Cynthia.Card
{
	[CardEffectId("23003")]//哥亚特
	public class Golyat : CardEffect
	{//获得7点增益。 每次被伤害时，额外承受2点伤害。
		public Golyat(GameCard card) : base(card){}
		public override async Task<int> CardPlayEffect(bool isSpying,bool isReveal)
		{
			return 0;
		}
	}
}