using HarmonyLib;
using MelonLoader;
using Il2Cpp;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

[assembly: MelonInfo(
    typeof(LongerGames.Main),
    "Longer Games",
    "1.0.0",
    "TheMadWhale"
)]

namespace LongerGames
{
    public class Main : MelonMod
    {
        private static readonly int[] PointsToWinValues =
        {
            3000,
            3500,
            4000,
            4500,
            5000,
            5500,
            6000,
            7000,
            8000,
            9000,
            10000,
            12000,
            15000
        };

        public static void ExtendPointsToWin(BattleSettingsMenu menu)
        {
            if (menu == null ||
                menu.gameObject.name != "Battle Settings Menu")
            {
                return;
            }

            var toggle = menu.togglePointsToWin;

            if (toggle == null)
                return;

            var options =
                new Il2CppStructArray<int>(
                    PointsToWinValues.Length
                );

            for (int i = 0; i < PointsToWinValues.Length; i++)
            {
                options[i] = PointsToWinValues[i];
            }

            toggle.toggleButtonOptions = options;
            toggle.minToggleIndex = 0;
            toggle.maxToggleIndex = PointsToWinValues.Length - 1;
        }
    }


    [HarmonyPatch(
        typeof(BattleSettingsMenu),
        nameof(BattleSettingsMenu.CacheComponents)
    )]
    public static class BattleSettingsMenuPatch
    {
        public static void Postfix(
            BattleSettingsMenu __instance)
        {
            Main.ExtendPointsToWin(__instance);
        }
    }
}
