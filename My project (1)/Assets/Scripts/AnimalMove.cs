using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityBasic.Prototype2
{
    public class AnimalMove : MonoBehaviour
    {
        public float speed = 3.0f;

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            // �Ʒ��� �������� �ڵ带 �ۼ��ϼ���
            // transform .  ������ �������� �ӵ�. ���� * �ӵ� * �ð�

            transform.position = transform.position + Vector3.back * speed * Time.deltaTime;
        }
    }
}
