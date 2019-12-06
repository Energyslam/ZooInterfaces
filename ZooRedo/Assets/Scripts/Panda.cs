using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Zoo
{
    public class Panda : Animal, IHerbivore
    {
        public void SayHello()
        {
            Balloon.SetActive(true);
            text.text = "oniiiiichan";
        }

        public void EatLeaves()
        {
            Balloon.SetActive(true);
            text.text = "bamboo?";
        }
    }
}
