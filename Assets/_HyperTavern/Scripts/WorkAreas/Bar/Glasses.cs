/*
 * @author: Mehmet Baran ÖZBOYACI
 * @date:   18.09.2022 
 * 
 * Glasses class
 */

using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace HT
{
    public class Glasses : MonoBehaviour
    {
        [SerializeField]
        private BarController barController;

        [SerializeField]
        private List<GameObject> glasses;

        public void Filled()
        {
            var myIndex = barController.GlassesCount;
            glasses[myIndex].SetActive(true);
        }
        public void Taken()
        {
            var myIndex = barController.GlassesCount-1;
            glasses[myIndex].SetActive(false);
        }
    }
}