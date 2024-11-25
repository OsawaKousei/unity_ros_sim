using UnityEngine;

public class TestScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // ↑キーが押されたら
        if (Input.GetKey(KeyCode.UpArrow))
        {
            // このオブジェクトを前に移動する
            this.transform.position += this.transform.forward * 0.1f;
        }
        // ↓キーが押されたら
        if (Input.GetKey(KeyCode.DownArrow))
        {
            // このオブジェクトを後ろに移動する
            this.transform.position -= this.transform.forward * 0.1f;
        }
        // →キーが押されたら
        if (Input.GetKey(KeyCode.RightArrow))
        {
            // このオブジェクトを右に移動する
            this.transform.position += this.transform.right * 0.1f;
        }
        // ←キーが押されたら
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            // このオブジェクトを左に移動する
            this.transform.position -= this.transform.right * 0.1f;
        }
    }
}
