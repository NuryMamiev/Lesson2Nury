using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;
using Button = UnityEngine.UI.Button;

public class CubeRotatorRight : MonoBehaviour
{
    [SerializeField] private float rotationSpeed = 10f;
    [SerializeField] private Button _button;

    public void Start()
    {
        _button.onClick.AddListener(Rotate);
    }

    private void Rotate()
    {
        transform.Rotate(Vector3.down,rotationSpeed * Time.deltaTime);
    }

}
    

  
