/*
 * @author: Mehmet Baran ÖZBOYACI
 * @date:   17.09.2022 
 * 
 * GrapeBasket class
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HT
{
    public class GrapeBasket : MonoBehaviour
    {
        [SerializeField]
        private PlayerController playerController;

        [SerializeField]
        private WineBarrels wineBarrels;

        [SerializeField]
        private Transform basketArea;

        private bool isSmashing = false;

        private void OnMouseDown()
        {
            if(!isSmashing)
            {
                if (playerController.Carrying)
                {
                    if (playerController.IsGrape)
                    {
                        playerController.Carrying = false;
                        playerController.IsGrape = false;

                        playerController.MovePlayer(basketArea.position);

                        Invoke(nameof(DropGrapes), 0.5f);
                        Invoke(nameof(CreateWineBarrel), 10);
                    }
                }
            }
        }

        private void DropGrapes()
        {
            playerController.DropGrapes();

            isSmashing = true;
        }

        private void CreateWineBarrel()
        {
            wineBarrels.CreateBarrel();

            isSmashing = false;
        }
    }
}