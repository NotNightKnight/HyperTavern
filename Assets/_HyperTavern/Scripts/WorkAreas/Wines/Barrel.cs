/*
 * @author: Mehmet Baran ÖZBOYACI
 * @date:   18.09.2022 
 * 
 * Barrel class
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HT
{
    public class Barrel : MonoBehaviour
    {
        [SerializeField]
        private PlayerController playerController;

        [SerializeField]
        private WineBarrels wineBarrels;

        [SerializeField]
        private Transform barrelArea;

        private void OnMouseDown()
        {
            if(!playerController.Carrying)
            {
                playerController.MovePlayer(barrelArea.position);

                wineBarrels.TakeBarrel(gameObject);

                playerController.Carrying = true;
                playerController.IsBarrel = true;
                playerController.CarryBarrel();

                Invoke(nameof(Carry), 0.5f);
            }
        }

        private void Carry()
        {
            gameObject.SetActive(false);
        }
    }
}