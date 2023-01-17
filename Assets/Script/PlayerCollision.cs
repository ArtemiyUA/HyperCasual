using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerCollision : MonoBehaviour
{
    public static PlayerCollision instance;

   [Header("Objects")]
    [SerializeField] GameObject textScore;
    [SerializeField] GameObject flash;
    [SerializeField] GameObject movement;


    [Header("Sounds")]
    [SerializeField] AudioClip playerDie;
    [SerializeField] AudioClip pickUpOil;
    [SerializeField] AudioClip pickUpBeer;
    [SerializeField] AudioClip finishSound;
    [SerializeField] AudioClip gateLimitSound;
    private Animator playerAnim;
    AudioSource audioSource;


    public static bool isDead = false;

   
    private void Awake()
    { 
        playerAnim = GetComponent<Animator>();
        flash.SetActive(false);

        audioSource = GetComponent<AudioSource>();
        GetComponent<Collider>().enabled = true;
        movement.GetComponent<PlayerMovement>().enabled = true;
        PathCreation.Examples.PathFollower.speed = 2;
        textScore.SetActive(true);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Oil")
        {
            audioSource.PlayOneShot(pickUpOil);
        }

        if (other.gameObject.tag == "Beer")
        {
            audioSource.PlayOneShot(pickUpBeer);
        }
        if (other.gameObject.tag == "GateLimit")
        {
            audioSource.PlayOneShot(gateLimitSound);

        }
        if (other.gameObject.tag == "Wall")
        {
            other.GetComponent<Walltrigger>().HitWall();
            if (isDead == true)
            {
                Die();
            }
        }
        if (other.gameObject.tag == "Saw")
         {
            Die();
         }
         if (other.gameObject.tag == "Finish")
         {
             playerAnim.SetTrigger("playerVictory");
             audioSource.PlayOneShot(finishSound);
         }
        
    }

    public void Die()
    {       
            GetComponent<Collider>().enabled = false;
            playerAnim.SetTrigger("playerDie");
            PathCreation.Examples.PathFollower.speed = 0;
            textScore.SetActive(false);
            flash.SetActive(true);
            movement.GetComponent<PlayerMovement>().enabled = false;
            audioSource.PlayOneShot(playerDie);
            Invoke("ReloadScene", 2f);      
    }

    private void ReloadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
