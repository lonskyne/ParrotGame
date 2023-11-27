using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ParrotGame.General
{
    public class LookAtCamera : MonoBehaviour
    {
        [SerializeField] private Vector3 rotOffset;

        private Transform camT;

        private void Start()
        {
            camT = Camera.main.transform;
        }

        private void Update()
        {
            transform.LookAt(camT.position);
            transform.rotation *= Quaternion.Euler(rotOffset);
        }
    }
}
