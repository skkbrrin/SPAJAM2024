using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class Rin_Test : MonoBehaviour
{
    GameObject Rin_test; // あいうえお

    // Start is called before the first frame update
    void Start()
    {
        this.Rin_test = GameObject.Find("Rin_Test");
    }

    // Update is called once per frame
    void Update()
    {
        this.Rin_test.GetComponent<TextMeshProUGUI>().text = "質問文";
    }
}
