using Terraria;
using Terraria.ModLoader;

namespace DiabloMod {
    // This class is responsible for dealing with JSON files and updating item name after creation.
    // We have a separate JSON for each item type that can receive Prefixes/Suffixes or that can be unique.
    // We have to load each JSON on game load, which is made in the DiabloMod class.
    // After each JSON is loaded within the game's memory, we call this class to deal with the drops.
    public class LootGenerator : GlobalItem {
        
    }
}