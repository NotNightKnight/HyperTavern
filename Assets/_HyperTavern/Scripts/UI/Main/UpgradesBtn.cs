using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HT
{
    public class UpgradesBtn : MonoBehaviour
    {
        [SerializeField]
        private CanvasGroup upgradesPanel;

        private bool isOpen = false;

        public void OnClick()
        {
            if(isOpen)
            {
                upgradesPanel.alpha = 0;
                upgradesPanel.interactable = false;
                upgradesPanel.blocksRaycasts = false;

                isOpen = false;

                Resume();
            }
            else
            {
                upgradesPanel.alpha = 1;
                upgradesPanel.interactable = true;
                upgradesPanel.blocksRaycasts = true;

                isOpen = true;

                Pause();
            }
        }

        private void Pause()
        {
            Time.timeScale = 0;
        }
        private void Resume()
        {
            Time.timeScale = 1;
        }
    }
}