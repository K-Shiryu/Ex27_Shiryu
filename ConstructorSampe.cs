using System;
using ConsoleUtility;

namespace ConstructorSampe
{
    class ConstructorSampeMain
    {
        static void Main(string[] args)
        {
            Box box1 = new Box();
            Console.WriteLine($"体積は{box1.GetVolume()}、表面積は{box1.GetSurface()}");
            Box box2 = new Box(
                InteractiveInput.InputFloat("幅："),
                InteractiveInput.InputFloat("高さ："),
                InteractiveInput.InputFloat("奥行："));
            Console.WriteLine($"体積は{box2.GetVolume()}、表面積は{box2.GetSurface()}");
        }
    }
}
