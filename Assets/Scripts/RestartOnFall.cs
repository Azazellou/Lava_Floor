using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartOnFall : MonoBehaviour
{
    [SerializeField]
    string strTag;


    private void OnCollisionEnter(Collision collision) 
    {
        if (collision.collider.tag == strTag)
        {
            GetComponent<AudioSource>().Play();
            SceneManager.LoadScene("Menu");
            
        }
    }
}
