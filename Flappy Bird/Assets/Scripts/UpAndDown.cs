using UnityEngine;
using System.Collections;

public class UpAndDown : MonoBehaviour {

    void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "Player" && GameController.Instance.status == GameStatus.Nomal)
        {
            AudioController.Instance.PlayHit();
            GameController.Instance.status = GameStatus.Over;
            AudioController.Instance.PlayDie();
        }

    }
}
