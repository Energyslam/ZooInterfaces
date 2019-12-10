using System;
using UnityEngine;
using UnityEngine.UI;

namespace Zoo
{
    class Lion : Animal, ICarnivore
    {
        public override void SayHello()
        {
            Balloon.SetActive(true);
            text.text = "roooaoaaaaar";
        }

        public void EatMeat()
        {
            Balloon.SetActive(true);
            text.text = "nomnomnom thx mate";
        }
    }
}
