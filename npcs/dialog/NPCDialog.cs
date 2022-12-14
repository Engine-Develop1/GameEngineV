using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngineV.npcs.dialog
{
    public class NPCDialog : npcs
    {
        public void NpcWL(NPCNames npcNames ,string mess)
        {
            Console.WriteLine(ConvToString(npcNames) + mess);
        }
        public static bool PlayerInputOptions(string user, string input)
        {
            if (user == input)
                return true;
            else
                return false;
        }
        public static bool PlayerInputOptions(string user, string[] input)
        {
            bool re = true;
            for (int i = 0; i < input.Length; i++)
            {
                if (user == input[i])
                    re = true;
                else
                    re = false;
            }
            return re;
        }
        public static bool PlayerInputOptionsWin(string inputFelt, string input)
        {
            Console.Write(inputFelt);
            if (Console.ReadLine() == input)
                return true;
            else
                return false;
        }
        public static bool PlayerInputOptionsWin(string inputFelt, string[] input)
        {
            Console.Write(inputFelt);
            string User = Console.ReadLine();
            bool re = true;
            for (int i = 0; i < input.Length; i++)
            {
                if (User == input[i])
                    re = true;
                else
                    re = false;
            }
            return re;
        }
        public static string GetRandomLine(string[] lines, int min, int max)
        {
            Random random = new();
            return lines[random.Next(min, max)];
        }
    }
}
