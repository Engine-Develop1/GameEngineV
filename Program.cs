using System;
using GameEngineV.Player.craft;
using GameEngineV.Player;

namespace GameEngineV
{
    class Program
    {
        PlayerMain PlayerMain;
        CraftMain craftMain;
        static void Main()
        {
            Program program = new();
            program.Start();
        }
        void StartSystems()
        {
            PlayerMain = new PlayerMain();
            PlayerMain.StartPlayerSystems();
            craftMain = new CraftMain();
            craftMain.StartCraftSystems(PlayerMain);
        }
        public void Start()
        {
            StartSystems();
        }
    }
}
