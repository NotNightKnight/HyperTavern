using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HT
{
    public class Trees : MonoBehaviour
    {
        [SerializeField]
        private List<GameObject> trees;

        private int activeTrees = 1;

        public void BuyTree()
        {
            if(activeTrees < 6)
            {
                trees[activeTrees].SetActive(true);
                activeTrees++;
            }
            else
            { }
        }
    }
}