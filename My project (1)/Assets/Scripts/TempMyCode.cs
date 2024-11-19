using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;

namespace UnityBasic
{
    public class TempMyCode : MonoBehaviour
    {
        /*
         * dog
         * ���� �̸�,       string
         * ���� ����,       int
         * ���� ¢�� �Ҹ�   void Bark()
         */

        // ������Ʈ ������ �ڱ��ڽ��� ����� �����ϵ��� �ٷ��.
        // ����Ƽ �̺�Ʈ �Լ� -> life cycle �����ϴ�.

        // int ab;
        // int ab=1;
        // 

        [System.Serializable]
        public class Dog
        {
            public string DogName;
            public int Age;

            public void Bark()
            {
                Debug.Log("�п�!");
            }
        }

        public Dog myDog;

        private void Awake()
        {

        }

        // Start is called before the first frame update
        void Start()
        {
            ShowStatus();
        }

        private void ShowStatus()
        {
            Debug.Log($"���� �ݷ� ������ �̸� : {myDog.DogName}, �ݷ� ������ ���� : {myDog.Age}");
            myDog.Bark();
        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                ChangeDogAge();
                ShowStatus();
            }
            else if (Input.GetKeyDown(KeyCode.G))
            {
                ChangeDogAge();
                ShowStatus();
            }
        }


        public string modifyName;
        public int modifyAge;
        // Dog�� �̸��� �������ִ� �Լ�

        private void ChangeDogName()
        {
            myDog.DogName = modifyName;
        }

        // Dog�� ���̸� �������ִ� �Լ�

        private void ChangeDogAge()
        {
            myDog.Age = modifyAge;
        }
    }

}