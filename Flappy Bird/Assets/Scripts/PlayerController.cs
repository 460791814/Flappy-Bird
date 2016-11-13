using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
    public int rate;//频率
    private float timer = 0;
    private float trueTime;
    private int frameCount = 0;
    public Material material;
    private Rigidbody rigibody;
    public float speed;
    // Use this for initialization
    void Start()
    {
        trueTime = 1.0f / rate;
        material = this.GetComponent<Renderer>().material;
        rigibody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (GameController.Instance.status == GameStatus.Nomal || GameController.Instance.status == GameStatus.Start)
        {
            timer += Time.deltaTime;
            if (timer > trueTime)
            {
                frameCount++;
                timer = 0;
                int index = frameCount % 3;
                material.SetTextureOffset("_MainTex", new Vector2(0.33333333f * index, 0));
            }



        }
    }
    void FixedUpdate()
    {
        if (GameController.Instance.status == GameStatus.Nomal || GameController.Instance.status == GameStatus.Start)
        {
            if (Input.GetMouseButtonDown(0))
            {
                AudioController.Instance.PlayWing();
                rigibody.AddForce(new Vector3(0, speed, 0));
                rigibody.velocity = new Vector3(3, 0, 0);
            }
        }
    }

}
