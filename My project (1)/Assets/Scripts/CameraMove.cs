using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityBasic
{
    public class CameraMove : MonoBehaviour
    {
        public GameObject target; // ī�޶� �Ѿư� ���

        private Vector3 offset; // ī�޶�� ����� ���� �Ÿ�

        // Start is called before the first frame update
        void Start()
        {
            offset = transform.position - target.transform.position;
        }

        // Update is called once per frame
        void Update()
        {
            transform.position = target.transform.position + offset;
        }
    }
}
