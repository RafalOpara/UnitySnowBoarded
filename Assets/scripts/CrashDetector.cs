using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] ParticleSystem CrashEffect;
        CircleCollider2D playerHead;
        [SerializeField] float ReLoadSceneTime =1.1f;
        [SerializeField] AudioClip crashSFX;

        bool hasCrashed=false;
    private void Start()
    {
        playerHead = GetComponent<CircleCollider2D>();
    }  
 
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Ground" && playerHead.IsTouching(other.collider)&& !hasCrashed)

        {
            hasCrashed=true;
            FindObjectOfType<PlayerControler>().DisableControls();
            CrashEffect.Play();
            GetComponent<AudioSource>().PlayOneShot(crashSFX);
            Invoke("ReloadScene",ReLoadSceneTime);
        }
    }

    void ReloadScene()
    {
         SceneManager.LoadScene(0);
    }
}