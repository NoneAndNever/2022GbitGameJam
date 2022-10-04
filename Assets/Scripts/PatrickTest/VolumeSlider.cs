using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeSlider : MonoBehaviour
{
    [SerializeField] private Slider _slider;
    
    // Start is called before the first frame update
    void Start()
    {
        SoungManager.Instance.ChangeVolume(_slider.value);
        _slider.onValueChanged.AddListener(value => SoungManager.Instance.ChangeVolume(value));
    }

    // Update is called once per frame
    void Update()
    {
    }
}
