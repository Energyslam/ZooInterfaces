using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;
using System;

namespace Zoo
{
    public class GameManager : MonoBehaviour
    {
        private static GameManager _instance;
        private Dictionary<string, IAnimal> animalDictionary = new Dictionary<string, IAnimal>();
        private List<IAnimal> animalList = new List<IAnimal>();
        public static GameManager Instance { get { return _instance; } }
        void Awake()
        {
            if (_instance != null && _instance != this)
            {
                Destroy(this.gameObject);
            }
            else
            {
                _instance = this;
            }
        }

        public void AddAnimalEntry(string name, IAnimal obj)
        {
            animalDictionary.Add(name, obj);
        }

        public void AddAnimalToList(IAnimal go)
        {
            animalList.Add(go);
        }

        public void FeedHerbivores()
        {
            foreach (IHerbivore herbi in animalList.OfType<IHerbivore>())
            {
                herbi.EatLeaves();
            }
        }

        public void FeedCarnivores()
        {
            foreach (ICarnivore carni in animalList.OfType<ICarnivore>())
            {
                carni.EatMeat();
            }
        }

        public void DoTricks()
        {
            foreach (ITrickster trickster in animalList.OfType<ITrickster>())
            {
                trickster.PerformTrick();
            }
        }

        public void SayName(Text txt)
        {
            try
            {
                animalDictionary[txt.text].SayHello();
            }
            catch (Exception e)
            {
                foreach (IAnimal ani in animalList.OfType<IAnimal>())
                {
                    ani.SayHello();
                }
            }
        }
    }
}
