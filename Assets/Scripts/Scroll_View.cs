using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scroll_View : MonoBehaviour
{
    public GameObject scrollViewItem;

    void Start()
    {
        for (int i = 0; i < 20; i++)
        {
            GameObject item = Instantiate(scrollViewItem);
            item.transform.SetParent(transform, false);
        }
    }
}