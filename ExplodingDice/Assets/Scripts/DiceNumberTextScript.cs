using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DiceNumberTextScript : MonoBehaviour
{

    public TextMeshProUGUI textMesh;
    public static int diceNumber;

    // Use this for initialization
    void Start()
    {
        textMesh = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        textMesh.text = diceNumber.ToString();
    }
}
