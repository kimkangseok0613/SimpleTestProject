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
         * 개의 이름,       string
         * 개의 나이,       int
         * 개가 짖는 소리   void Bark()
         */

        // 컴포넌트 스스로 자기자신의 기능을 실행하도록 다룬다.
        // 유니티 이벤트 함수 -> life cycle 갖습니다.

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
                Debug.Log("왈왈!");
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
            Debug.Log($"나의 반려 동물의 이름 : {myDog.DogName}, 반려 동물의 나이 : {myDog.Age}");
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
        // Dog의 이름을 변경해주는 함수

        private void ChangeDogName()
        {
            myDog.DogName = modifyName;
        }

        // Dog의 나이를 변경해주는 함수

        private void ChangeDogAge()
        {
            myDog.Age = modifyAge;
        }
    }

}