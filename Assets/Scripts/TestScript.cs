using UnityEngine;
using UnityEngine.InputSystem;

public class TestScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        var input = Gamepad.current;
        if (input == null)
        {
            Debug.Log("No gamepad connected");
            return;
        }
        this.transform.position += new Vector3(input.leftStick.x.ReadValue() / 10, 0, input.leftStick.y.ReadValue() / 10);
    }
}
