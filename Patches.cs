using HarmonyLib;
using System.Collections.Generic;

namespace WorstGearFirst
{
    class Patches
    {
        [HarmonyPatch(typeof(Inventory), "GetHighestConditionGearThatMatchesName")]
        internal static class Inventory_GetHighestConditionGearThatMatchesName
        {
            private static bool Prefix(Inventory __instance, ref GearItem __result, string name)
            {
                __result = Implementation.GetWorstItemByName(name);

                return false;
            }
        }

        [HarmonyPatch(typeof(Utils), "GetBestBow")]
        internal static class Utils_GetBestBow
        {
            private static bool Prefix(ref GearItem __result, List<GearItem> items)
            {
                __result = Implementation.GetWorstItemByName("GEAR_Bow");

                return false;
            }
        }

        [HarmonyPatch(typeof(Utils), "GetBestTorch")]
        internal static class Utils_GetBestTorch
        {
            private static bool Prefix(ref GearItem __result, List<GearItem> items)
            {
                __result = Implementation.GetWorstItemByName("GEAR_Torch");

                return false;
            }
        }

        [HarmonyPatch(typeof(Utils), "GetBestFlareGun")]
        internal static class Utils_GetBestFlareGun
        {
            private static bool Prefix(ref GearItem __result, List<GearItem> items)
            {
                __result = Implementation.GetWorstItemByName("GEAR_FlareGun");

                return false;
            }
        }
    }
}
