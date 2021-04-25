using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace MeleeRebalance {
    public class MeleeRebalancePlayer : ModPlayer {
		public override void PreUpdateBuffs() {
            if(Player.HeldItem.DamageType == DamageClass.Melee) {
                Player.AddBuff(BuffType<Buffs.MeleeRebalanceBuff>(), 30, true);
            }
        }
    }
}
