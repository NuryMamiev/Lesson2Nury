
using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using Vector3 = System.Numerics.Vector3;

public class TargetOfUi : MonoBehaviour
{
    [SerializeField] private GameObject _gameObject;
    [SerializeField] private TextMeshProUGUI textRotation;
    [SerializeField] private TextMeshProUGUI textScale;

   

    private void Update()
    { 
        var  rotation = _gameObject.transform.rotation.eulerAngles;
        var  scale = _gameObject.transform.localScale;

        textRotation.text = "Rotation: " + (rotation.y);
        textScale.text = "Scale: " + (scale.x + scale.y + scale.z);
    }
}   
