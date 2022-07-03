using HarmonyLib;
using NeosModLoader;

namespace NeosDisableGamepads
{
    public class NeosDisableGamepads : NeosMod
    {
        public override string Name => "NeosDisableGamepads";
        public override string Author => "Lexevo";
        public override string Version => "1.0.0";
        public override string Link => "https://github.com/Lexevolution/NeosDisableGamepads/";
        public override void OnEngineInit()
        {
            Harmony harmony = new Harmony("net.lexevo.NeosDisableGamepads");
            harmony.PatchAll();
        }
		
        [HarmonyPatch(typeof(FrooxEngine.StandardGamepad), "Bind")]
        class NeosDisableGamepadsPatch
        {
            public static bool Prefix()
            {
                return false; //dont run rest of method
            }
        }
    }
}