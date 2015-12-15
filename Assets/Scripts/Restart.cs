using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Restart : MonoBehaviour {

    private bool active = false;

    public IEnumerator EndAndRestart(Text end_text, float time) {
        if (!active) {
            active = true;
            end_text.color = new Color(end_text.color.r, end_text.color.g, end_text.color.b, 1);
            yield return new WaitForSeconds(time);
            end_text.color = new Color(end_text.color.r, end_text.color.g, end_text.color.b, 0);
            Application.LoadLevel(0);
        }
    }
}
