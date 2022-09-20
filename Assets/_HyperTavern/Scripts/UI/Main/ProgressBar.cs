/*
 * @author: Mehmet Baran ÖZBOYACI
 * @date:   18.09.2022 
 * 
 * ProgressBar class
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

namespace HT
{
    public class ProgressBar : MonoBehaviour
    {
        [SerializeField]
        private Slider progressSlider;

        [SerializeField]
        private PlayerController playerController;

        public void StartWorking()
        {
            progressSlider.DOValue(progressSlider.maxValue, 5f / playerController.workSpeed);
        }
        public void StopWorking()
        {
            progressSlider.value = 0;
        }
    }
}