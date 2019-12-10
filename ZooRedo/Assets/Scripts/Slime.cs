using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Zoo
{
    public class Slime : Animal, ITrickster, IOmnivore
    {
        public override void SayHello()
        {
            Balloon.SetActive(true);
            text.text = "s-s-slimey";
        }

        public void EatMeat()
        {
            Balloon.SetActive(true);
            text.text = "braaaaaaaaains";
        }

        public void EatLeaves()
        {
            Balloon.SetActive(true);
            text.text = "woowoowoo leafy";
        }
        public void PerformTrick()
        {
            StartCoroutine(DoTrick());
        }

        public IEnumerator DoTrick()
        {
            for (int i = 0; i < 360; i++)
            {
                transform.localRotation = Quaternion.Euler(0, i, 0);
                yield return new WaitForEndOfFrame();
            }
        }
    }
}
