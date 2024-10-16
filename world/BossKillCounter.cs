using Terraria;
using Terraria.ModLoader;

namespace DiabloMod {
    public class BossKillCounter : GlobalNPC {
        public static int MoonLordKillCounter = 0;
        public override void OnHitNPC(NPC npc, NPC target, int damage, float knockback, bool crit)
        {
            if (npc.life <= 0 && npc.FullName.Contains("Moon") && npc.boss) {
                MoonLordKillCounter += 1;
                if (WorldState.State == 4) {
                    // Moonlord will start dropping a special item that starts a new invasion event
                }
            }
        }
    }
}