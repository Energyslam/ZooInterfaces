using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Zoo
{
    public interface ICarnivore : IAnimal
    {
        void EatMeat();
    }
}
