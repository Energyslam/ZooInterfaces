using System;
using UnityEngine;
using UnityEngine.UI;

namespace Zoo
{
    class Zebra : Animal, IHerbivore
    {
        public void SayHello()
        {
            Balloon.SetActive(true);
            text.text = "zebra zebra";
        }

        public void EatLeaves()
        {
            Balloon.SetActive(true);
            text.text = "munch munch zank yee bra";
        }
    }
}
