using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngineV.Player.craft
{
    public class CraftMain
    {
        public PlayerMain PlayerMain;
        public Craftitems Craftitems;
        public void StartCraftSystems(PlayerMain player)
        {
            PlayerMain = player;
            Craftitems = new Craftitems();
        }
    }
}
