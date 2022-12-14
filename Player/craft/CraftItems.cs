using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngineV.Player.craft
{
    public class Craftitems : CraftMain
    {
        public void CraftItem(string Item)
        {
            if ("Wooden pickaxe" == Item || "WP" == Item || "wp" == Item)
                Craft2I(Items.Wood, 3, Items.stick, 2, Items.WoodenPickaxe, 1);
            else if ("wooden axe" == Item || "Wooden axe" == Item || "WA" == Item || "wa" == Item)
                Craft2I(Items.Wood, 3, Items.stick, 2, Items.WoodenAxe, 1);
            else if ("wooden sword" == Item || "Wooden sword" == Item || "WS" == Item || "ws" == Item)
                Craft2I(Items.Wood, 3, Items.stick, 2, Items.WoodenAxe, 1);
            else if ("Sticks" == Item || "sticks" == Item)
                Craft1I(Items.Wood, 4, Items.stick, 32);
            else if ("Wood" == Item || "wood" == Item)
                Craft1I(Items.stick, 8, Items.Wood, 1);

            if ("Stone pickaxe" == Item || "SP" == Item || "sp" == Item)
                Craft2I(Items.stone, 3, Items.stick, 2, Items.StonePickaxe, 1);
            /*
            else if ("furnace" == Item || "furn" == Item || "Furn" == Item)
                Craft1IStation(items.stone, 8, CraftingStations.SmeltingStation);
            else if ("Anvil" == Item || "anvil" == Item)
                Craft2IStation(items.ironIngot, 4, items.iron_block, 3, CraftingStations.Anvil);
            */

            if ("iron" == Item || "Iron" == Item)
                Craft2I(Items.ironore, 2, Items.coal, 1, Items.ironIngot, 1);

            if ("ironblock" == Item || "IronBlock" == Item || "IB" == Item || "ib" == Item)
                Craft1I(Items.ironIngot, 8, Items.iron_block, 1);
            else if ("iron2" == Item || "Iron2" == Item)
                Craft2I(Items.ironore, 4, Items.coal, 2, Items.ironIngot, 2);

            if ("steel" == Item || "Steel" == Item || "SB" == Item || "sb" == Item)
                Craft3I(Items.ironore, 2, Items.coal, 4, Items.lava_bukkit, 1, Items.steel, 1);

            if ("Iron pickaxe" == Item || "IP" == Item || "ip" == Item)
                Craft2I(Items.ironIngot, 3, Items.stick, 2, Items.IronPickaxe, 1);
        }
        public void Craft1I(Items items1, int Item1Con, Items Re, int ReCon)
        {
            for (int s = 0; s < PlayerMain.InvSystem.GetInvLength(); s++)
            {
                int F = 0;
                if (PlayerMain.InvSystem.GetInvData(items1) == true)
                {
                    PlayerMain.InvSystem.TakeFromInv(items1, Item1Con);
                    F++;
                }
                if (F == 1)
                {
                    bool Done = false;
                    for (int i = 0; i < PlayerMain.InvSystem.GetInvLength(); i++)
                    {
                        if (PlayerMain.InvSystem.GetInvData(Re) == true && Done != true)
                        {
                            PlayerMain.InvSystem.SetInvData(Re, ReCon);
                            Done = true;
                        }
                    }
                }
            }
        }
        public void Craft2I(Items items1, int Item1Con, Items items2, int Item2Con, Items Re, int ReCon)
        {
            for (int s = 0; s < PlayerMain.InvSystem.GetInvLength(); s++)
            {
                for (int a = 0; a < PlayerMain.InvSystem.GetInvLength(); a++)
                {
                    int F = 0;
                    if (PlayerMain.InvSystem.GetInvData(items1) == true)
                    {
                        PlayerMain.InvSystem.TakeFromInv(items1, Item1Con);
                        F++;
                    }
                    if (PlayerMain.InvSystem.GetInvData(items2) == true)
                    {
                        PlayerMain.InvSystem.TakeFromInv(items2, Item2Con);
                        F++;
                    }
                    if (F == 2)
                    {
                        if (Re == Items.bronze)
                            PlayerMain.IncBronzeCount();
                        bool Done = false;
                        for (int i = 0; i < PlayerMain.InvSystem.GetInvLength(); i++)
                        {
                            if (PlayerMain.InvSystem.GetInvData(Re) == true && Done != true)
                            {
                                PlayerMain.InvSystem.SetInvData(Re, ReCon);
                                Done = true;
                            }
                        }
                    }
                }
            }
        }
        public void Craft3I(Items items1, int Item1Con, Items items2, int Item2Con, Items items3, int Item3Con, Items Re, int ReCon)
        {
            for (int s = 0; s < PlayerMain.InvSystem.GetInvLength(); s++)
            {
                for (int a = 0; a < PlayerMain.InvSystem.GetInvLength(); a++)
                {
                    for (int d = 0; d < PlayerMain.InvSystem.GetInvLength(); d++)
                    {
                        int F = 0;
                        if (PlayerMain.InvSystem.GetInvData(items1) == true)
                        {
                            PlayerMain.InvSystem.TakeFromInv(items1, Item1Con);
                            F++;
                        }
                        if (PlayerMain.InvSystem.GetInvData(items2) == true)
                        {
                            PlayerMain.InvSystem.TakeFromInv(items2, Item2Con);
                            F++;
                        }
                        if (PlayerMain.InvSystem.GetInvData(items3) == true)
                        {
                            PlayerMain.InvSystem.TakeFromInv(items3, Item3Con);
                            F++;
                        }
                        if (F == 3)
                        {
                            bool Done = false;
                            for (int i = 0; i < PlayerMain.InvSystem.GetInvLength(); i++)
                            {
                                if (PlayerMain.InvSystem.GetInvData(Re) == true && Done != true)
                                {
                                    PlayerMain.InvSystem.SetInvData(Re, ReCon);
                                    Done = true;
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
