/*
 * @author: Mehmet Baran ÖZBOYACI
 * @date:   17.09.2022 
 * 
 * GrapeCollect class
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HT
{
    public class GrapeCollect : MonoBehaviour
    {
        [SerializeField]
        private PlayerController playerController;

        [SerializeField]
        private Transform collectTransform;

        [SerializeField]
        private List<GameObject> grapes;

        private bool hasGrapes = true;

        private void OnMouseDown()
        {
            if(!playerController.Carrying)
            {
                if (hasGrapes)
                {
                    //playerController.Working = true;
                    playerController.StartWorking();
                    playerController.IsGrape = true;
                    playerController.MovePlayer(collectTransform.position);

                    Invoke(nameof(CollectGrapes), 5f / playerController.workSpeed);

                    hasGrapes = false;
                    Invoke(nameof(SpawnGrapes), 10);
                }
            }
        }

        private void CollectGrapes()
        {
            foreach (GameObject grape in grapes)
            {
                grape.SetActive(false);
            }
        }
        private void SpawnGrapes()
        {
            foreach(GameObject grape in grapes)
            {
                grape.SetActive(true);
            }
            hasGrapes = true;
        }
    }
}