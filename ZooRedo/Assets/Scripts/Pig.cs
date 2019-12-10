using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Zoo
{
    class Pig : Animal, IOmnivore, ITrickster
    {
        public override void SayHello()
        {
            Balloon.SetActive(true);
            text.text = "oink oink";
        }

        public void EatLeaves()
        {
            Balloon.SetActive(true);
            text.text = "munch munch oink";
        }

        public void EatMeat()
        {
            Balloon.SetActive(true);
            text.text = "nomnomnom oink thx";
        }
        public void PerformTrick()
        {
            StartCoroutine(DoTrick());
        }

        public IEnumerator DoTrick()
        {
            for (int i = 0; i < 360; i++)
            {
                transform.localRotation = Quaternion.Euler(i, i, i);
                yield return new WaitForEndOfFrame();
            }
        }
    }
}
