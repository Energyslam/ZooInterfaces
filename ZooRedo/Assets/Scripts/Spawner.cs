﻿using System;
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
            GameManager.Instance.AddToCollections("henk", henk);
            GameManager.Instance.AddToCollections("elsa", elsa);
            GameManager.Instance.AddToCollections("dora", dora);
            GameManager.Instance.AddToCollections("wally", wally);
            GameManager.Instance.AddToCollections("marty", marty);
            GameManager.Instance.AddToCollections("slimo", slimo);
            GameManager.Instance.AddToCollections("panny", panny);
        }
    }
}
