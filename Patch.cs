using HarmonyLib;

namespace NoFecundityNerf.Patch
{
    public static class NoFecundityNerf
    {
        [HarmonyPatch(typeof(DiskCardGame.DrawCopy))]
        [HarmonyPatch("CardToDrawTempMods", MethodType.Getter)]
        [HarmonyPostfix]
        static void Postfix(ref System.Collections.Generic.List<DiskCardGame.CardModificationInfo> __result)
        {
            if(SaveFile.IsAscension)
            {
                __result = null;
            }
        }
    }
}
