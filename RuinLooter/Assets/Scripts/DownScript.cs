using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DownScript : MonoBehaviour
{
    public GameObject salleHaut;
    public GameObject couloirHaut;
    GameObject piece;
    void Start()
    {
        Vector2 position = transform.position;
        //if (position.y - 10.0f == null)
        {
            float newPiece = Random.Range(1, 3);
            switch (newPiece)
            {
                case 1:
                    piece = salleHaut;
                    break;
                case 2:
                    piece = couloirHaut;
                    break;
            }
            Vector2 newPosition = transform.position;
            newPosition.y = position.y - 10.0f;
            GameObject nouvellePiece = Instantiate(piece, newPosition, Quaternion.identity);
        }
    }
}
