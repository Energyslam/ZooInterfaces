using System;
using System.Collections.Generic;
using UnityEngine;

namespace Zoo
{
    class Spawner : MonoBehaviour
    {
        [SerializeField]
        private GameObject lion, hippo, pig, tiger, zebra, slime, panda;
        private void Start()
        {
            Lion henk = Instantiate(lion, transform).GetComponent<Lion>();
            Hippo elsa = Instantiate(hippo, transform).GetComponent<Hippo>();
            Pig dora = Instantiate(pig, transform).GetComponent<Pig>();
            Tiger wally = Instantiate(tiger, transform).GetComponent<Tiger>();
            Zebra marty = Instantiate(zebra, transform).GetComponent<Zebra>();
            Slime slimo = Instantiate(slime, transform).GetComponent<Slime>();
            Panda panny = Instantiate(panda, transform).GetComponent<Panda>();
            AddToCollections("henk", henk);
            AddToCollections("elsa", elsa);
            AddToCollections("dora", dora);
            AddToCollections("wally", wally);
            AddToCollections("marty", marty);
            AddToCollections("slimo", slimo);
            AddToCollections("panny", panny);
        }

        private void AddToCollections(string name, IAnimal obj)
        {
            GameManager.Instance.AddAnimalEntry(name, obj);
            GameManager.Instance.AddAnimalToList(obj);
        }
    }
}
