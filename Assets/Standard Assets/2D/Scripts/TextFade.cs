using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextFade : MonoBehaviour {

    private Text text;
    private float fade_timer = 0;
    private float delay = 0;
    private float time = 0;

	// Use this for initialization
	void Start () {
        text = GetComponent<Text>();
        text.color = new Color(text.color.r, text.color.g, text.color.b, 0.0f);
	}
	
	// Update is called once per frame
	void Update () {
        if (text.color.a > 0) {
            fade_timer += Time.deltaTime;
            if (fade_timer > delay) {
                float alpha = 1 - (fade_timer - delay) / time;
                text.color = new Color(text.color.r, text.color.g, text.color.b, alpha);
            }
        }
	}

    public void SetText(string new_text, float fade_delay, float fade_time) {
        text.text = new_text;
        text.color = new Color(text.color.r, text.color.g, text.color.b, 1.0f);
        fade_timer = 0;
        delay = fade_delay;
        time = fade_time;
    }
}
