using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Reaktion;
using UnityEngine.UI;

public class SliderInjector : InjectorBase
{

    public Slider slider;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        dbLevel = 20.0f * Mathf.Log10(slider.value);
    }

}
