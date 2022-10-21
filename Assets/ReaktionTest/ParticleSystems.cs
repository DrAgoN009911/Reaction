using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Interactions;

public class ParticleSystems : MonoBehaviour
{

    ParticleSystem ps;
    ParticleSystem ps1;


    private void Start()
    {
        ps = GetComponent<ParticleSystem>();
        ps1 = GetComponent<ParticleSystem>();
    }

    public void onSpray(InputAction.CallbackContext context)
    {
        ps.Emit(50);
    }


    public void onSpray2(InputAction.CallbackContext context)
    {
        ps.Emit(100);
    }

    public void onSpray3(InputAction.CallbackContext context)
    {
        ps.Emit(40);
    }
    public void onSpray4(InputAction.CallbackContext context)
    {
        ps.Emit(90);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
