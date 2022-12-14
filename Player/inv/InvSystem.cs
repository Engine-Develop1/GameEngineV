using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace GameEngineV.Player.inv
{
    public class InvSystem
    {
        public Items[] ItemInv;
        public int[] con;
        public int invindex;
        public InvSystem(int invspaces)
        {
            ItemInv = new Items[invspaces];
            for (int i = 0; i < invspaces; i++)
            {
                ItemInv[i] = Items.none;
            }
        }
        public bool GetInvData(Items item)
        {
            for (int i = 0; i < ItemInv.Length; i++)
            {
                if (ItemInv[i] == item)
                    return true;
            }
            return false;
        }
        public void SetInvData(Items invData, int cona)
        {
            for (int i = 0; i < ItemInv.Length; i++)
            {
                if(ItemInv[i] == Items.none)
                {
                    ItemInv[i] = invData;
                    con[i] = cona;
                    return;
                }
                else if(invData == ItemInv[i])
                {
                    con[i] += cona;
                    return;
                }
            }
        }
        public void TakeFromInv(Items invData, int cona)
        {
            for (int i = 0; i < ItemInv.Length; i++)
            {
                if(invData == ItemInv[i])
                {
                    if(cona == -1)
                    {
                        ItemInv[i] = Items.none;
                        con[i] = 0;
                        return;
                    }
                    else if(con[i] >= cona)
                    {
                        con[i] = cona;
                        return;
                    }
                }    
            }
        }
        public int GetInvLength()
        {
            return ItemInv.Length;
        }
    }
}
