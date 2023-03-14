using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class VolumeSlider : MonoBehaviour
{
    public TextMeshProUGUI numberText;
    private Slider volumeSlider;

    // Start is called before the first frame update
    void Start()
    {
        volumeSlider = GetComponent<Slider>();
        SetNumberText(volumeSlider.value);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetNumberText(float value)
    {
        numberText.text = value.ToString();
    }
}
