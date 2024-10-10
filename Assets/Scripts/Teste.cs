using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teste : MonoBehaviour
{
    private List<int> num = new List<int>();
    // Start is called before the first frame update
    void Start()
    {
        num.Add(0);
        num.Add(1);
        num.Add(2);
        num.Add(3);
        num.Add(4);
        num.Add(5);
        num.Add(6);
        num.Add(7);
        num.Add(8);
        num.Add(9);

    }

    // Update is called once per frame
    void Update()
    {
        num.GetRandom();
        Debug.Log("Valor final "+num.GetRandom());
        
    }
}
