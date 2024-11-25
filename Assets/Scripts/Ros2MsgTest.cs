using UnityEngine;
using ROS2;

public class Ros2MsgTest : MonoBehaviour
{
    private ROS2UnityComponent ros2Unity;
    private ROS2Node ros2Node;
    private IPublisher<std_msgs.msg.String> chatter_pub;
    private int i = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        TryGetComponent(out ros2Unity);
    }

    // Update is called once per frame
    void Update()
    {
        if (ros2Unity.Ok())
        {
            if (ros2Node == null)
            {
                // Nodeの名前を指定する
                ros2Node = ros2Unity.CreateNode("ROS2UnityTalkerNode");
                //トピックの名前と型を指定する
                chatter_pub = ros2Node.CreatePublisher<std_msgs.msg.String>("hello_from_Unity");
            }
        }

        // スペースキーが押されたら
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Space key was pressed.");

            i++;
            std_msgs.msg.String msg = new std_msgs.msg.String();
            msg.Data = "Hello world from Unity" + i;
            chatter_pub.Publish(msg);
        }
    }
}
