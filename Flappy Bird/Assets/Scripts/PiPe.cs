using UnityEngine;
using System.Collections;

public class PiPe : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        transform.position = new Vector3(transform.position.x, Random.Range(-1.5f, 3.0f), transform.position.z);
    }
    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player"&&GameController.Instance.status==GameStatus.Nomal)
        {
            AudioController.Instance.PlayPoint();
            GameController.Instance.AddScore();
        }
    }

}
