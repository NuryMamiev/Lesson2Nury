using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using Button = UnityEngine.UI.Button;

public class ScalePlus : MonoBehaviour
{
    [SerializeField] private float scalePlus = 1f;
    [SerializeField] private Button _button;

    private void Start()
    {
            _button.onClick.AddListener(SizePlus);
    }

    private void SizePlus()
    {
        transform.localScale += new Vector3(scalePlus, scalePlus, scalePlus);
    }
}
