/*
 * @author: Mehmet Baran ÖZBOYACI
 * @date:   18.09.2022 
 * 
 * Customer class
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HT
{
    public class Customer : MonoBehaviour
    {
        [SerializeField]
        private PlayerController playerController;
        [SerializeField]
        private CustomerController customerController;

        private void OnMouseDown()
        {
            if(playerController.Carrying)
            {
                if(playerController.IsGlass)
                {
                    playerController.MovePlayer(transform.position);

                    Invoke(nameof(Drop), 0.3f);
                }
            }
        }

        private void Drop()
        {
            playerController.Carrying = false;
            playerController.IsGlass = false;
            playerController.DropGlass();

            Invoke(nameof(Leave), 0.5f);
        }

        private void Leave()
        {
            customerController.CustomerCount--;
            if(customerController.CustomerCount == 0)
            {
                customerController.HasCustomer = false;
            }
            gameObject.SetActive(false);
        }
    }
}