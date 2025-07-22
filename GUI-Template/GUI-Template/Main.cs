using MelonLoader;
using UnityEngine;

namespace TheCabin
{
    public class Main : MelonMod
    {

        // Creates the buttons & Puts the menu on screen
        public override void OnInitializeMelon()
        {
            MelonEvents.OnGUI.Subscribe(DrawMenu, 100);
            MelonEvents.OnGUI.Subscribe(buttons, 100);
        }

        // Creates the menu
        private void DrawMenu()
        {
            GUI.Box(new Rect(10, 0, 300, 200), "YOUR MENU NAME HERE");
        }

        // Mods/Buttons
        public static void buttons()
        {
            if (GUI.Button(new Rect(10, 0, 130, 15), "Quit Game"))
            {
                UnityEngine.Application.Quit();
            }
        }
    }
}
