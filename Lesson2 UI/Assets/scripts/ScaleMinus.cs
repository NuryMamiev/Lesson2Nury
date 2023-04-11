using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScaleMinus : MonoBehaviour
{
    [SerializeField] private float scaleMinus = 1;
    [SerializeField] private Button _button;

    private void Start()
    {
        _button.onClick.AddListener(ScaleMin);
        
    }

    private void ScaleMin()
    {
        transform.localScale -= new Vector3(scaleMinus, scaleMinus, scaleMinus);
    }
}
