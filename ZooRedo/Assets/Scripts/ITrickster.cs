using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Zoo
{
    public interface ITrickster
    {
        void PerformTrick();
        IEnumerator DoTrick();
    }
}
