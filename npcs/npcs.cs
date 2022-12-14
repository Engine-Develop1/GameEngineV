using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngineV.npcs
{
    public enum NPCNames
    {
        Player,
        Elf,
        Bolvar,
        TheShopKeeperInStrombard,
        TheShopKeeperInFirestromb,
        TheWild
    }
    public class npcs
    {
        public string ConvToString(NPCNames npc)
        {
            switch (npc)
            {
                case NPCNames.Player:
                    return "You:";
                case NPCNames.Elf:
                    return "Elfi:";
                case NPCNames.Bolvar:
                    return "Bolvar:";
                case NPCNames.TheShopKeeperInStrombard:
                    return "The Shop Keeper:";
                case NPCNames.TheShopKeeperInFirestromb:
                    return "The Shop Keeper:";
                case NPCNames.TheWild:
                    return "The wild:";
                default:
                    break;
            }
            return "";
        }
    }
}
