/*
 * @author: Mehmet Baran ÖZBOYACI
 * @date:   17.09.2022 
 * 
 * BarController class
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HT
{
    public class BarController : MonoBehaviour
    {
        [SerializeField]
        private PlayerController playerController;

        [SerializeField]
        private Transform barArea;

        [SerializeField]
        private BarBarrel barBarrel;

        [SerializeField]
        private Glasses glasses;

        [SerializeField]
        private GameObject bartender;

        [SerializeField]
        private int barrelSupply;

        private int supplyLimit;

        public bool HasBarrel
        { get; set; }

        public int GlassesCount
        { get; set; }

        private bool hasBartender = false;

        private void Start()
        {
            supplyLimit = barrelSupply;
        }

        private void OnMouseDown()
        {
            if(!hasBartender)
            {
                if (!playerController.Working)
                {
                    if (!playerController.Carrying)
                    {
                        playerController.MovePlayer(barArea.position);

                        if (HasBarrel && GlassesCount != 6)
                        {
                            playerController.Filling = true;
                            //playerController.Working = true;
                            playerController.StartWorking();

                            Invoke(nameof(FillGlass), 5f / playerController.workSpeed);
                        }
                    }
                }
            }
        }

        private void FillGlass()
        {
            glasses.Filled();

            GlassesCount++;
            barrelSupply--;

            if (barrelSupply == 0)
            {
                HasBarrel = false;
                barBarrel.BarrelEmpty();
                barrelSupply = supplyLimit;
            }

            playerController.Filling = false;
            //playerController.Working = false;
            playerController.StopWorking();
        }
        public void TakeGlass()
        {
            glasses.Taken();

            GlassesCount--;
        }

        public void BuyBartender()
        {
            bartender.SetActive(true);
            hasBartender = true;
        }
        public void BartenderWorks()
        {
            //InvokeRepeating(nameof(BartenderFill), 5f,)
        }
        private void BartenderFill()
        {
            glasses.Filled();

            GlassesCount++;
            barrelSupply--;

            if (barrelSupply == 0)
            {
                HasBarrel = false;
                barBarrel.BarrelEmpty();
                barrelSupply = supplyLimit;
            }
        }
    }
}