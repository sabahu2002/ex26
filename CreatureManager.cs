using System.Collections;
using System.Collections.Generic;
using Assignment26;
using UnityEngine;
namespace Assignment26
{
    public class CreatureManager : MonoBehaviour
    {
        Kangaroo hub = new Kangaroo();
        Duck pop = new Duck();

        // Start is called before the first frame update
        void Start()
        {
            List<Creature> Animals = new List<Creature>()
            {
                new Kangaroo(),
                new Duck()
            };
            List<IRunnable> Run = new List<IRunnable>();
            Run.Add(hub);
            Run.Add(pop);
            List<IJumpable> Jump = new List<IJumpable>();
            Jump.Add(hub);
            List<ISwimmable> Swim = new List<ISwimmable>();
            Swim.Add(pop);


            foreach (Creature Animal in Animals)
            {
                Animal.Speak();
            }

            foreach (IRunnable runnable in Run)
            {
                runnable.Run();
            }

            foreach (IJumpable jumpable in Jump)
            {
                jumpable.Jump();
            }

            foreach (ISwimmable swimmable in Swim)
            {
                swimmable.Swim();
            }

        }







    }
}
