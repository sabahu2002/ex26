using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UI;
namespace Assignment26
{

    public class Creature : MonoBehaviour
    {

        public virtual void Speak()
        {
            Debug.Log("A creature makes a sound.");
        }
    }
    public interface IRunnable
    {
        void Run();
    }
    public interface IJumpable
    {
        void Jump();
    }
    public interface ISwimmable
    {
        void Swim();
    }


    public class Kangaroo : Creature, IJumpable, IRunnable
    {
        public void Run()
        {
            Debug.Log("Kangaroo runs.");
        }
        public void Jump()
        {
            Debug.Log("Kangaroo jumps.");
        }
        public override void Speak()
        {
            Debug.Log("Kangaroo says: Hop!");
        }

    }
    public class Duck : Creature, ISwimmable, IRunnable
    {
        public void Run()
        {
            Debug.Log("Duk runs.");
        }
        public void Swim()
        {
            Debug.Log("Duck swims.");
        }
        public override void Speak()
        {
            Debug.Log("Duck says: Quack!");
        }

    }
}

