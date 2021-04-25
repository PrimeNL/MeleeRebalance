using Terraria.ModLoader;

namespace MeleeRebalance {
	public class MeleeRebalance : Mod {
		public static MeleeRebalance instance;
		public override void Load() { instance = this; }
		public override void Unload() { instance = null; }

		public MeleeRebalance() {
			Properties = new ModProperties() {
				Autoload = true,
				AutoloadGores = true,
				AutoloadSounds = true
			};
		}
	}
}