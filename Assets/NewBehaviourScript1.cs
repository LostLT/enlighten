using System;
using UnityEngine;
using System.Collections;
using System.Linq;
using System.Text;

namespace InsideProject
{

    public class NewBehaviourScript1 : MonoBehaviour
    {

        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        public static void PreExport()
        {

            Console.WriteLine("From inside project: This is a pre-export method firing");


        }

        public static void PostExport(string path)
        {

            Console.WriteLine("From inside project: This is a post-export method firing, and this is the path we ingested: " + path);

        }
    }

}

