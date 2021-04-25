using Terraria;
using Terraria.ModLoader;

namespace MeleeRebalance.Buffs {
    public class MeleeRebalanceBuff : ModBuff {
        public override void SetDefaults() {
            DisplayName.SetDefault("Defensive buff");
            Description.SetDefault("Grants 30% additional damage reduction.");
            Main.buffNoTimeDisplay[Type] = true;
            Main.debuff[Type] = false;
            CanBeCleared = false;
        }

        public override void Update(Player player, ref int buffIndex) {
            player.endurance += 0.3f;
        }
    }
}
