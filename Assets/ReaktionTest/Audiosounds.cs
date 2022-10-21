using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Interactions;

public class Audiosounds : MonoBehaviour
{

    AudioSource As1;
    AudioSource AS2;
    AudioSource AS3;
    AudioSource AS4;

    // Start is called before the first frame update
    private void Start()
    {
        As1 = GetComponent<AudioSource>();
        AS2 = GetComponent<AudioSource>();
        AS3 = GetComponent<AudioSource>();
        AS4 = GetComponent<AudioSource>();
    }




    public void AudioPlay1(InputAction.CallbackContext context)
    {
        As1.Play(0);
        Debug.Log("P is pressed");
    }

    public void AudioPlay2(InputAction.CallbackContext context)
    {
        AS2.Play(0);
        Debug.Log("L is pressed");
    }
    public void AudioPlay3(InputAction.CallbackContext context)
    {
        AS3.Play(0);
        Debug.Log("A is pressed");
    }
    public void AudioPlay4(InputAction.CallbackContext context)
    {
        AS4.Play(0);
        Debug.Log("Y is pressed");
    }


    public void AudioStop1(InputAction.CallbackContext context)
    {
        As1.Stop();
        Debug.Log("S is pressed");
    }
    public void AudioStop2(InputAction.CallbackContext context)
    {
        AS2.Stop();
        Debug.Log("T is pressed");
    }
    public void AudioStop3(InputAction.CallbackContext context)
    {
        AS3.Stop();
        Debug.Log("O is pressed");
    }
    public void AudioStop4(InputAction.CallbackContext context)
    {
        AS4.Stop();
        Debug.Log("P is pressed");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
