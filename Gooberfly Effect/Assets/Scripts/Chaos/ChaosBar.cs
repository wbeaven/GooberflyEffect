using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChaosBar : MonoBehaviour
{
    public Slider slider;

    private float currentValue = 0;
    public float CurrentValue
    {
        get
        {
            return currentValue;
        }
        set
        {
            currentValue = value;
            slider.value = currentValue;
        }
    }

    private void Update()
    {
        CurrentValue = Chaos.chaosLevel;
    }
}
