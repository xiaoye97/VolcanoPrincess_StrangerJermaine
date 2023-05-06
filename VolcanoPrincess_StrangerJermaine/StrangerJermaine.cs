using BepInEx;
using HarmonyLib;

namespace xiaoye97
{
    [BepInPlugin(GUID, PluginName, VERSION)]
    public class StrangerJermaine : BaseUnityPlugin
    {
        public const string GUID = "me.xiaoye97.plugin.VolcanoPrincess.StrangerJermaine";
        public const string PluginName = "StrangerJermaine";
        public const string VERSION = "1.0.0";

        void Start()
        {
            Harmony.CreateAndPatchAll(typeof(StrangerJermaine));
        }

        [HarmonyPrefix, HarmonyPatch(typeof(Person), "AddFavor")]
        public static bool Person_AddFavor_Patch(Person __instance, ref int num)
        {
            if (__instance.enName == "42")
            {
                num = 0;
            }
            return true;
        }
    }
}
