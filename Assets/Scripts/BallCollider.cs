using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCollider : MonoBehaviour
{
    [SerializeField] private GameObject endGamePanel;

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Wall")
        {
            FindObjectOfType<BallController>().isAlive = false;
            endGamePanel.SetActive(true);
        }
    }
}
