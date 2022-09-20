/*
 * @author: Mehmet Baran ÖZBOYACI
 * @date:   18.09.2022 
 * 
 * BarBarrel class
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HT
{
    public class BarBarrel : MonoBehaviour
    {
        [SerializeField]
        private BarController barController;

        [SerializeField]
        private PlayerController playerController;

        [SerializeField]
        private Transform barBarrelArea;

        [SerializeField]
        private MeshRenderer meshRenderer;

        private void OnMouseDown()
        {
            if(playerController.Carrying)
            {
                if(playerController.IsBarrel)
                {
                    if (!barController.HasBarrel)
                    {
                        barController.HasBarrel = true;
                        barController.BartenderWorks();

                        playerController.MovePlayer(barBarrelArea.position);

                        playerController.Carrying = false;
                        playerController.IsBarrel = false;

                        playerController.DropBarrel();

                        Invoke(nameof(BarrelDropped), 0.3f);
                    }
                }
            }
        }

        private void BarrelDropped()
        {
            meshRenderer.enabled = true;
        }
        
        public void BarrelEmpty()
        {
            meshRenderer.enabled = false;
        }
    }
}
