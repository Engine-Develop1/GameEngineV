using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace GameEngineV.Player.inv
{
    public class InvSystem
    {
        public items[] ItemInv;
        public int[] con;
        public int invindex;
        public InvSystem(int invspaces)
        {
            ItemInv = new items[invspaces];
            for (int i = 0; i < invspaces; i++)
            {
                ItemInv[i] = items.none;
            }
        }
        public items GetInvData(items item)
        {
            for (int i = 0; i < ItemInv.Length; i++)
            {
                if (ItemInv[i] == item)
                    return item;
            }
            return items.none;
        }
        public void SetInvData(items invData, int cona)
        {
            for (int i = 0; i < ItemInv.Length; i++)
            {
                if(ItemInv[i] == items.none)
                {
                    ItemInv[i] = invData;
                    con[i] = cona;
                    return;
                }
            }
        }
        public void TakeFromInv(items invData, int cona)
        {
            for (int i = 0; i < ItemInv.Length; i++)
            {
                if(invData == ItemInv[i])
                {
                    if(cona == -1)
                    {
                        ItemInv[i] = items.none;
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
    }
}
