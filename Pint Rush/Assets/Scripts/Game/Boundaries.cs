using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PintRush
{
    public class Boundaries : MonoBehaviour
    {
        [SerializeField] private GameObject gm;

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if(collision.gameObject.tag == "Glass")
            {
                Destroy(collision.gameObject);
                gm.GetComponent<GameManagement>().RemoveGlass();
            }
        }
    }
}
