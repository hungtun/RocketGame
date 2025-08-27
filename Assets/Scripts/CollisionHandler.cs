using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CollisionHandler : MonoBehaviour
{
    [SerializeField]AudioClip successAudio;
    [SerializeField]AudioClip crashAudio;
    [SerializeField]ParticleSystem successPaticle;
    [SerializeField]ParticleSystem crashPaticle;
    AudioSource audioSource;
    bool isTransitioning = false;
    bool collisionDisabled = true;
    float levelLoadDelay = 1f;
    private void Start() {
        audioSource = GetComponent<AudioSource>();
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.L))
        {
            Debug.Log("Collision disabled: "+collisionDisabled);
            collisionDisabled = !collisionDisabled;
            StartSuccessSequence();
        }
        else if(Input.GetKeyDown(KeyCode.C))
        {
            Debug.Log("Collision disabled: "+collisionDisabled);
            collisionDisabled = !collisionDisabled;
        }
    }
    private void OnCollisionEnter(Collision other) {
        if(isTransitioning || !collisionDisabled) return;
        switch (other.gameObject.tag) 
        {
            case "Friendly":
                Debug.Log("nothing");
                break;
            case "Fuel":
                Debug.Log("you've picked up fuel");
                break;
            case "Finish":
                StartSuccessSequence();
                break;
            default:
                StartCrashSequence();
                break ;
                
        }
    }
    void StartCrashSequence()
    {
        audioSource.Stop();
        audioSource.PlayOneShot(crashAudio); 
        crashPaticle.Play();
        isTransitioning = true; 
        GetComponent<Movement>().enabled = false;
        Invoke("ReloadLevel", levelLoadDelay);
    }
    void StartSuccessSequence()
    {
        audioSource.Stop();
        audioSource.PlayOneShot(successAudio);
        successPaticle.Play();
        isTransitioning = true; 
        GetComponent<Movement>().enabled = false;
        Invoke("LoadNextLevel", levelLoadDelay);
    }
    void LoadNextLevel()
    {
        int nextLevelIndex = SceneManager.GetActiveScene().buildIndex + 1;
        if (nextLevelIndex == SceneManager.sceneCountInBuildSettings)
        {
            nextLevelIndex = 0;
        }
        SceneManager.LoadScene(nextLevelIndex);
    }
    void ReloadLevel()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex);
    }
}
