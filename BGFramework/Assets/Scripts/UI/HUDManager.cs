using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField]
    private Slider healthBarAmount = null;
    [SerializeField]
    private float sliderFillSpeed = .5f;
    private float currentHealthValue;
    private float timeTillFill = 0;
    private float newHealthValue = 100;

    // Start is called before the first frame update
    void Start()
    {
        PlayerHealth.UpdateHealth += ChangeValue;
    }

    // Update is called once per frame
    void Update()
    {
        NewBarValue();
    }

    private void ChangeValue( int amount ) 
    {
        newHealthValue = amount;
        timeTillFill = 0;
    }

    private void NewBarValue()
    {
        if ( currentHealthValue != newHealthValue )
        {
            currentHealthValue = Mathf.Lerp(currentHealthValue, newHealthValue, timeTillFill);
            timeTillFill += sliderFillSpeed * Time.deltaTime;

        }

        healthBarAmount.value = currentHealthValue;
    }
}
