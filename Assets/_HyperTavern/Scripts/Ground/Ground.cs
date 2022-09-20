/*
 * @author: Mehmet Baran ÖZBOYACI
 * @date:   17.09.2022 
 * 
 * Ground class for mouse click
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HT
{
    public class Ground : MonoBehaviour
    {
        [SerializeField]
        private PlayerController playerController;

        private void OnMouseDown()
        {
            playerController.MovePlayer();
        }
    }
}