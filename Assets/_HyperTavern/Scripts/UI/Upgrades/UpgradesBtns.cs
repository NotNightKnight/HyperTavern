using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HT
{
    public class UpgradesBtns : MonoBehaviour
    {
        [SerializeField]
        private Trees trees;
        [SerializeField]
        private Baskets baskets;

        [SerializeField]
        private BarController barController;
        [SerializeField]
        private CustomerController customerController;
        [SerializeField]
        private PlayerController playerController;

        public void BuyTreeBtn()
        {
            trees.BuyTree();
        }
        public void BuyBasketBtn()
        {
            baskets.BuyBasket();
        }

        public void HireBartender()
        {
            barController.BuyBartender();
        }
        public void HireWaitress()
        {

        }
    }
}