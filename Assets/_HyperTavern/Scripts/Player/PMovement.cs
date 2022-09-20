/*
 * @author: Mehmet Baran ÖZBOYACI
 * @date:   17.09.2022 
 * 
 * PMovement class for moving player
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

namespace HT
{
    public class PMovement : MonoBehaviour
    {
        [SerializeField]
        private PlayerController playerController;

        RaycastHit hit;

        private void Start()
        {
            DOTween.Init(false, true, LogBehaviour.Default);
            DOTween.defaultEaseType = Ease.Linear;
        }

        public void MovePlayer(float speed)
        {
            Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 1000);

            var newPos = hit.point;

            transform.DOMove(newPos, 1 / speed);
        }
        public void MovePlayer(float speed, Vector3 position, float workSpeed)
        {
            Tweener tweener = transform.DOMove(position, 1 / speed);

            StartCoroutine(CheckTweener(tweener, workSpeed));
        }

        private IEnumerator CheckTweener(Tweener tweener, float speed)
        {
            yield return tweener.WaitForCompletion();
            //Debug.Log("Working... + " + Time.time);
            StartCoroutine(StartWorking(speed));
        }

        private IEnumerator StartWorking(float speed)
        {
            yield return new WaitForSeconds(5f/speed);

            //playerController.Working = false;
            playerController.StopWorking();
            playerController.Carrying = true;

            Carry();
        }

        private void Carry()
        {
            if(playerController.IsGrape)
            {
                playerController.CarryGrapes();
            }
            else if(playerController.IsBarrel)
            {
                playerController.CarryBarrel();
            }
            else if(playerController.IsGlass)
            {
                playerController.CarryGlass();
            }
            else
            {
                playerController.Carrying = false;
            }
        }
    }
}