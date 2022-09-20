using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HT
{
    public class Baskets : MonoBehaviour
    {
        [SerializeField]
        private List<GameObject> baskets;

        private int activeBaskets = 1;

        public void BuyBasket()
        {
            if(activeBaskets < 4)
            {
                baskets[activeBaskets].SetActive(true);

                activeBaskets++;
            }
        }
    }
}