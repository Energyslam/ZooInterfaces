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
        private Dictionary<string, Animal> animalDictionary = new Dictionary<string, Animal>();
        private List<Animal> animalList = new List<Animal>();
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

        private void Start()
        {
            foreach (KeyValuePair<string, Animal> pair in animalDictionary)
            {
                pair.Value.animalname = pair.Key;
            }
        }

        public void AddAnimalEntry(string name, Animal obj)
        {
            animalDictionary.Add(name, obj);
        }

        public void AddAnimalToList(Animal go)
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
                animalDictionary[txt.text].GetComponent<IAnimal>().SayHello();
            }
            catch (Exception e)
            {
                foreach (IAnimal ani in animalList.OfType<IAnimal>())
                {
                    ani.SayHello();
                }
            }
        }
        public void AddToCollections(string name, Animal obj)
        {
            AddAnimalEntry(name, obj);
            AddAnimalToList(obj);
        }
    }
}
