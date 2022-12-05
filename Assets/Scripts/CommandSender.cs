using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEditor;
using TMPro;

public class CommandSender : MonoBehaviour
{

    [SerializeField] Machines machines;
    TMP_InputField inputField;
    private void Start()
    {
        inputField = GetComponent<TMP_InputField>();
    }

    private void Update()
    {
        
    }

}
