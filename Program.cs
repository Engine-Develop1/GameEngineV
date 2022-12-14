using System;

namespace GameEngineV
{
    class Program
    {
        Player.PlayerMain PlayerMain;
        static void Main()
        {
            Program program = new();
            program.Start();
        }
        public void Start()
        {
            PlayerMain = new Player.PlayerMain();
            PlayerMain.StartPlayerSystems();
        }
    }
}
