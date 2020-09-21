using System;
using Sims3.SimIFace;
using gplay = Sims3.Gameplay;

namespace TS3ScriptingMod
{
    // This is based on the pure scripting tutorial from Sims Wiki
    // http://simswiki.info/wiki.php?title=Tutorial:Sims_3_Pure_Scripting_Modding
    public class Pausinator
    {
        [Tunable] protected static bool kInstantiator = false;

        static Pausinator()
        {
            World.OnWorldLoadFinishedEventHandler
                += new EventHandler(OnWorldLoadFinished);
        }

        private static void OnWorldLoadFinished(object sender, EventArgs e)
        {
            gplay.Gameflow.SetGameSpeed(Gameflow.GameSpeed.Pause,
                gplay.Gameflow.SetGameSpeedContext.GameStates);

        }
    }
}
