using UnityEngine;
using System.Collections;

public class ChangeColider : MonoBehaviour {
    private GameObject pipe;
    void Awake()
    {
        pipe = transform.parent.gameObject;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            pipe.transform.position = new Vector3(GameController.Instance. last_bg.transform.position.x + 10, pipe.transform.position.y, pipe.transform.position.z);
            GameController.Instance.last_bg =pipe;
        }
    }
}
