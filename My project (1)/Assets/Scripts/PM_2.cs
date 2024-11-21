using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityBasic.Prototype2
{
    public class PM_2 : MonoBehaviour
    {
        public float speed = 5.0f;
        // Start is called before the first frame update
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
            if(transform.position.x<-20)
            {
                transform.position = new Vector3(-20, transform.position.y, transform.position.z);
            }
            if (transform.position.x > 20)
            {
                transform.position = new Vector3(20, transform.position.y, transform.position.z);
            }

            // �÷��̾��� ���� �̵��� �Է¹޾ƾ� �Ѵ�. Horizontal Input.GetAxis()
            // transform ��ġ
            float horizontalInput = Input.GetAxis("Horizontal");
            // Debug.Log($"�Է¹��� ���� �� : {horiontalInput}");

            transform.position = transform.position + Vector3.right * horizontalInput * speed * Time.deltaTime;
        }
    }
}
