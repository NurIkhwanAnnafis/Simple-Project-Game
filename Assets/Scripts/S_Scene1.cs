using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class S_Scene1 : MonoBehaviour
{
    public int imageIndex = 1;
    public GameObject[] imageList;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < imageList.Length; i++)
        {
            if (i == 0)
            {
                imageList[i].SetActive(true);
            }
            else
            {
                imageList[i].SetActive(false);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SetActiveImage(string type)
    {
        if (type == "add" && imageIndex + 1 < imageList.Length)
        {
            imageIndex++;
        }
        else if (type == "remove" && imageIndex - 1 >= 0)
        {
            imageIndex--;
        }
        if (imageIndex >= 0 && imageIndex < imageList.Length)
        {
            for (int i = 0; i < imageList.Length; i++)
            {
                if (i == imageIndex)
                {
                    imageList[i].SetActive(true);
                }
                else
                {
                    imageList[i].SetActive(false);
                }
            }
        }
    }
}
