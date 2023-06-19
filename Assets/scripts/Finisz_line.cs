using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Finisz_line : MonoBehaviour
{
    [SerializeField] float ReLoadSceneTime =1.1f;
    [SerializeField] ParticleSystem FinishEffect;

    void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.tag=="Player")
        {
            FinishEffect.Play();
            Invoke("ReloadScene", ReLoadSceneTime);
        }
    }

    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
