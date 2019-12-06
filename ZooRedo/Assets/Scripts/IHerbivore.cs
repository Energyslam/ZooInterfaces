using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Zoo
{
    public interface IHerbivore : IAnimal
    {
        void EatLeaves();
    }
}
