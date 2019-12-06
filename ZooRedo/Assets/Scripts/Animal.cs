using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Zoo
{
    public class Animal : MonoBehaviour
    {
        [SerializeField]
        protected GameObject Balloon;
        [SerializeField]
        protected Text text;
        public string name;
    }
}
