using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowInfo : MonoBehaviour
{
    public GameObject infoPanel;
    public GameObject text;
    private void OnMouseDown() {
        if(infoPanel.activeSelf == false) infoPanel.SetActive(true);
        else infoPanel.SetActive(false);
        if(text.activeSelf == false) text.SetActive(true);
        else text.SetActive(false);
    }
}
