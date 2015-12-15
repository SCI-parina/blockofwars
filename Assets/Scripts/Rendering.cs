using UnityEngine;
using System.Collections;

public class Rendering : MonoBehaviour {

    public Renderer rend;
    public Material material;
    public Texture2D texture;
    public WWW www;
    // Use this for initialization
    IEnumerator Start()
    {
        var url = "http://doge.naurunappula.com/screen/0d/2e/0d2ed4f4e7d37d9d/0/1299237.png";
        gameObject.GetComponent<Renderer>().material.SetTexture("_MainTex", texture);
        while (true)
        {
            var www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(gameObject.GetComponent<Renderer>().material.mainTexture as Texture2D);
            
        }
    }

    // Update is called once per frame
    void Update(){
    }
}
