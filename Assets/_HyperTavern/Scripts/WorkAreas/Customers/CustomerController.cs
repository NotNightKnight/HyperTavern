/*
 * @author: Mehmet Baran ÖZBOYACI
 * @date:   18.09.2022 
 * 
 * CustomerController class
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HT
{
    public class CustomerController : MonoBehaviour
    {
        [SerializeField]
        private List<GameObject> customers;

        public int CustomerCount
        { get; set; }

        public bool HasCustomer
        { get; set; }
    }
}