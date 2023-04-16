using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using TMPro;

public class ChangeState : MonoBehaviour
{
    public GameObject background;
    public TMP_Text textMesh;
    private int sign = -1;

    private void Start() {
        background.GetComponent<Renderer>().material.color = Color.white;
        textMesh.text = "OFF";
    }
    private void OnMouseDown() {
        if(sign == 1){
            background.GetComponent<Renderer>().material.color = Color.white;
            StartCoroutine(GetRequest("1"));
            textMesh.text = "OFF";
        }
        else{
            background.GetComponent<Renderer>().material.color = Color.green;
            StartCoroutine(GetRequest("0"));
            textMesh.text = "ON";
        }
        transform.Rotate(sign * 40f, 0.0f, 0, Space.Self);
        sign *= -1;
    }

    IEnumerator GetRequest(string s){
        using(UnityWebRequest webRequest = UnityWebRequest.Get("https://blynk.cloud/external/api/update?token=RYZTA01LYDi7IgsTnv3xJP_Co5RRGWVS&v1="+s)){
            yield return webRequest.SendWebRequest();
        }
    }
}
