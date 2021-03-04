using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapManager : MonoBehaviour
{
    private static MapManager _instance;
    public static MapManager Instance
    {
        get
        {
            if (_instance == null)
            {

            }
            return _instance;
        }
    }
    public GameObject couloirHaut;
    public GameObject couloirBas;
    public GameObject couloirGauche;
    public GameObject couloirDroit;
    public GameObject salleHaut;
    public GameObject salleBas;
    public GameObject salleGauche;
    public GameObject salleDroit;
    GameObject piece;
    void Awake()
    {
        int firstPiece = Random.Range(1, 9);
        switch (firstPiece)
        {
            case 1:
                piece = couloirHaut;
                break;
            case 2:
                piece = couloirBas;
                break;
            case 3:
                piece = couloirGauche;
                break;
            case 4:
                piece = couloirDroit;
                break;
            case 5:
                piece = salleHaut;
                break;
            case 6:
                piece = salleBas;
                break;
            case 7:
                piece = salleGauche;
                break;
            case 8:
                piece = salleDroit;
                break;
        }
        Vector2 posSpawn = transform.position;
        posSpawn.x = 0f;
        posSpawn.y = 0f;
        GameObject newPiece = Instantiate(piece, posSpawn, Quaternion.identity);
    }
}
