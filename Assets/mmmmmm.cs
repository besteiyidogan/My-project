using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class mmmmmm : MonoBehaviour
{
    // Start is called before the first frame update

    public int counter = 0;
    public int speed = 10;
    public GameObject startText;

    void Start()
    {
        print("Start");
        startText.GetComponent<TextMeshPro>().text = "Start";

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(0, 0, 1) * Time.deltaTime * speed);
    }
}
