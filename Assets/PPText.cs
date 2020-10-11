using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Assets
{
    class PPText : MonoBehaviour
    {
        public string Name;

        void Start()
        {
            PlayerPrefs.SetInt("Score", 0);
        }

        // Update is called once per frame
        void Update()
        {
            GetComponent<Text>().text = PlayerPrefs.GetInt(Name) + "";
        }

    }
}
