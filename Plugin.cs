using HarmonyLib;
using BepInEx;

namespace NoFecundityNerf
{
    [BepInPlugin("rzfury.noFecundityNerf", "NoFecundityNerf", "1.0.0")]
    public class Plugin : BaseUnityPlugin
    {
        private void Awake()
        {
            // Plugin startup logic
            Logger.LogInfo($" {PluginInfo.PLUGIN_NAME} is loaded!");
            new Harmony(PluginInfo.PLUGIN_GUID).PatchAll(typeof(Patch.NoFecundityNerf));
        }
    }
}
