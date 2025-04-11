using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment29
{
    public class TypeTester : MonoBehaviour
    {
        void Start()
        {
            Cat cat = new Cat();

            Animal animalRef = cat;
            animalRef.MakeSound();
            animalRef.Move();

            Cat catAgain = animalRef as Cat; 
            catAgain.MakeSound();
            catAgain.Move();

            List<ICanFight> fighters = new List<ICanFight> { cat, new Warrior() };

            foreach (var f in fighters)
            {
                f.Attack();

                if (f is Cat)
                    Debug.Log("The object is a Cat.");
                else if (f is Warrior)
                    Debug.Log("The object is a Warrior.");
            }
        }
    }
}
