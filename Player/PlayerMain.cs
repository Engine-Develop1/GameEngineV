using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngineV.Player
{
    public class PlayerMain
    {
        const int invspace = 10;
        public inv.InvSystem InvSystem;
        public void StartPlayerSystems()
        {
            InvSystem = new inv.InvSystem(invspace);
        }
    }
}
