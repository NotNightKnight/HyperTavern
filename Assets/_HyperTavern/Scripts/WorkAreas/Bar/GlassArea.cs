/*
 * @author: Mehmet Baran ÖZBOYACI
 * @date:   18.09.2022 
 * 
 * GlassArea class
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HT
{
    public class GlassArea : MonoBehaviour
    {
        [SerializeField]
        private PlayerController playerController;

        [SerializeField]
        private BarController barController;

        [SerializeField]
        private CustomerController customerController;

        [SerializeField]
        private Transform glassArea;

        private void OnMouseDown()
        {
            if(barController.GlassesCount > 0)
            {
                if(!playerController.Carrying)
                {
                    if(!customerController.HasCustomer)
                    {
                        playerController.MovePlayer(glassArea.position);

                        Invoke(nameof(Carry), 0.3f);
                    }
                }
            }
        }

        private void Carry()
        {
            playerController.Carrying = true;
            playerController.IsGlass = true;
            playerController.CarryGlass();

            barController.TakeGlass();
        }
    }
}