using System;
using UnityEngine;

namespace _app.scripts
{
    public class TriggerBox : MonoBehaviour
    {
        public void OnTriggerEnter(Collider other)
        {
            if (other.transform.name == "sphere")
            {
                if (AudioManager.instance != null)
                {
                    AudioManager.instance.PlayAudio();
                }
                else
                {
                    Debug.Log(other.transform.name + " Entered Trigger");    
                }
            }
        }

        public void OnTriggerExit(Collider other)
        {
            Debug.Log(other.transform.name + " Exited Trigger");
        }

        public void OnCollisionEnter(Collision other)
        {
            if (AudioManager.instance != null)
            {
                AudioManager.instance.PlayAudio();
            }
            else
            {
                Debug.Log(" Collided with object");   
            }
        }
        public void OnCollisionExit(Collision other)
        {
            Debug.Log(" No Longer Colliding with object");
        }
    }
}