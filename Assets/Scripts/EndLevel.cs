using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndLevel : MonoBehaviour
{
    [SerializeField]
    string strTag;

    private void OnCollisionEnter(Collision collision) 
    {
        if (collision.collider.tag == strTag)
        {
            SceneManager.LoadScene("Game2");
            GetComponent<AudioSource>().Play();
        }
    }
}