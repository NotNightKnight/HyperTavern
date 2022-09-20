/*
 * @author: Mehmet Baran ÖZBOYACI
 * @date:   17.09.2022 
 * 
 * WineBarrels class for holding barrels
 */

using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace HT
{
    public class WineBarrels : MonoBehaviour
    {
        [SerializeField]
        private List<GameObject> activeBarrels;

        [SerializeField]
        private List<GameObject> inactiveBarrels;

        private int barrelCount = 0;

        public void CreateBarrel()
        {
            if(barrelCount == 6)
            {
                Debug.Log("Max barrel reached!");
            }
            else
            {
                barrelCount++;

                inactiveBarrels.Last<GameObject>().SetActive(true);

                activeBarrels.Add(inactiveBarrels.Last<GameObject>());
                inactiveBarrels.Remove(inactiveBarrels.Last<GameObject>());
            }
        }
        public void TakeBarrel(GameObject barrel)
        {
            barrelCount--;

            activeBarrels.Remove(barrel);
            inactiveBarrels.Add(barrel);
        }
        //public void TakeBarrel()
        //{
        //    if(barrelCount == 0)
        //    {
        //        Debug.Log("No barrel to take!");
        //    }
        //    else
        //    {
        //        barrelCount--;

        //        activeBarrels.Last<GameObject>().SetActive(false);

        //        inactiveBarrels.Add(activeBarrels.Last<GameObject>());
        //        activeBarrels.Remove(activeBarrels.Last<GameObject>());
        //    }
        //}


    }
}