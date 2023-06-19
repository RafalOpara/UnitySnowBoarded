using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] ParticleSystem CrashEffect;
        CircleCollider2D playerHead;
        [SerializeField] float ReLoadSceneTime =1.1f;

    private void Start()
    {
        playerHead = GetComponent<CircleCollider2D>();
    }  
 
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Ground" && playerHead.IsTouching(other.collider))

        {
            CrashEffect.Play();
            Invoke("ReloadScene",ReLoadSceneTime);
        }
    }

    void ReloadScene()
    {
         SceneManager.LoadScene(0);
    }
}