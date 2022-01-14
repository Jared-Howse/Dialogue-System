using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XNode;

[System.Serializable]
public class Response: BaseNode
{
    [Output] public int exit;
    [SerializeField] private string responseText;

    public string ResponseText => responseText;

    public override string GetString()
    {
        return "ResponseNode";
    }

    private void OnValidate()
    {
        name = responseText;
    }
}
