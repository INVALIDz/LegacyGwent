using System.Linq;
using System.Threading.Tasks;
using Alsein.Extensions;

namespace Cynthia.Card
{
	[CardEffectId("44028")]//蓝衣铁卫斥候
	public class BlueStripesScout : CardEffect
	{//使己方半场其他“泰莫利亚”单位，以及手牌和牌组所有战力与自身相同的非间谍“泰莫利亚”单位获得1点增益。 操控。
		public BlueStripesScout(GameCard card) : base(card){}
		public override async Task<int> CardPlayEffect(bool isSpying,bool isReveal)
		{
			return 0;
		}
	}
}