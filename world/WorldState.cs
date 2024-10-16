using System.Collections.Generic;
using System.Data;
using Steamworks;
using Terraria;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;

namespace DiabloMod {
    public class WorldState : ModWorld {
        public List<string> WorldDifficulties = new List<string> {"Normal","Nightmare","Hell","Inferno"};
        public static int State = BossKillCounter.MoonLordKillCounter;
        public string WorldMode;
        public override void Load(TagCompound tag)
        {
            WorldMode = WorldDifficulties[State];
        }

    }
}