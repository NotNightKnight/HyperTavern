/*
 * @author: Mehmet Baran ÖZBOYACI
 * @date:   17.09.2022 
 * 
 * PlayerController class for controlling player
 * and settings for player like movement speed etc.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HT
{
    public class PlayerController : MonoBehaviour
    {
        //Components
        [SerializeField]
        private PMovement pMovement;
        [SerializeField]
        private ProgressBar progressBar;

        //Variables
        [SerializeField]
        private int money = 0;
        [SerializeField]
        private float movementSpeed;
        [SerializeField]
        private float carrySpeed;
        [SerializeField]
        public float workSpeed;

        //States
        public bool Working
        { get; set; }
        public bool Carrying
        { get; set; }
        public bool Filling
        { get; set; }
        public bool IsGrape
        { get; set; }
        public bool IsBarrel
        { get; set; }
        public bool IsGlass
        { get; set; }

        //Carried Stuff
        [SerializeField]
        private List<GameObject> grapes;
        [SerializeField]
        private GameObject barrel;
        [SerializeField]
        private GameObject glass;

        public void MovePlayer()
        {
            if(Working)
            {
                //can't move while working
            }
            else if(Carrying)
            {
                pMovement.MovePlayer(carrySpeed);
            }
            else
            {
                pMovement.MovePlayer(movementSpeed);
            }
        }
        public void MovePlayer(Vector3 position)
        {
            if (Carrying)
            {
                pMovement.MovePlayer(carrySpeed, position, workSpeed);
            }
            else
            {
                pMovement.MovePlayer(movementSpeed, position, workSpeed);
            }
        }

        public void StartWorking()
        {
            Working = true;

            progressBar.StartWorking();
        }
        public void StopWorking()
        {
            Working = false;

            progressBar.StopWorking();
        }

        public void CarryGrapes()
        {
            foreach(GameObject grape in grapes)
            {
                grape.SetActive(true);
            }
        }
        public void DropGrapes()
        {
            foreach(GameObject grape in grapes)
            {
                grape.SetActive(false);
            }
        }

        public void CarryBarrel()
        {
            barrel.SetActive(true);
        }
        public void DropBarrel()
        {
            barrel.SetActive(false);
        }

        public void CarryGlass()
        {
            glass.SetActive(true);
        }
        public void DropGlass()
        {
            glass.SetActive(false);

            money += 50;
        }

        public int GetMoney()
        {
            return money;
        }

        public void BuyTree(int cost)
        {
            money -= cost;
        }
    }
}