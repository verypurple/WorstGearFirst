using Il2CppSystem.Collections.Generic;
using MelonLoader;

namespace WorstGearFirst
{
    public class Implementation : MelonMod
    {
        internal static GearItem GetWorstItemByName(string name)
        {
            var items = new List<GearItem>();
            GameManager.GetInventoryComponent().GetItems(name, items);

            GearItem worstItem = null;

            foreach (var item in items)
            {
                if (!worstItem || !item.IsWornOut() && item.GetNormalizedCondition() < worstItem.GetNormalizedCondition())
                {
                    worstItem = item;
                }
            }

            return worstItem;
        }
    }
}
