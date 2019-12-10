using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Zoo
{
    public abstract class Animal : MonoBehaviour, IAnimal
    {
        [SerializeField]
        protected GameObject Balloon;
        [SerializeField]
        protected Text text;
        public string animalname { get { return name; } set { name = value; } }
        public abstract void SayHello();
    }
}
