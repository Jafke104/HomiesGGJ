using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Choice : MonoBehaviour
{
    public GameObject Carly;
    public GameObject Pierre;
    public GameObject Yuuki;
    public GameObject Dante;

    // Start is called before the first frame update
    void Start()
    {
        if (GameManager.current.choices[0] == 0)
            Pierre.SetActive(false);
        else if (GameManager.current.choices[0] == 1)
            Carly.SetActive(false);

        if (GameManager.current.choices[1] == 0)
            Dante.SetActive(false);
        else if (GameManager.current.choices[1] == 1)
            Yuuki.SetActive(false);

        if (GameManager.current.choices[0] == 0 && GameManager.current.choices[1] == 0)
        {
            Pierre.SetActive(false);
            Dante.SetActive(false);
        }

        else if (GameManager.current.choices[0] == 0 && GameManager.current.choices[1] == 1)
        {
            Pierre.SetActive(false);
            Yuuki.SetActive(false);
        }

        else if (GameManager.current.choices[0] == 1 && GameManager.current.choices[1] == 1)
        {
            Carly.SetActive(false);
            Yuuki.SetActive(false);
        }

        else if (GameManager.current.choices[0] == 1 && GameManager.current.choices[1] == 0)
        {
            Carly.SetActive(false);
            Dante.SetActive(false);
        }




    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
