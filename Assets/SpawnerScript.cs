using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript : MonoBehaviour
{

    [SerializeField] GameObject oneKnob;
    [SerializeField] GameObject oneSocket;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spawnPieces(1.1f, getRandomPiece()));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator spawnPieces(float interval, GameObject piece)
    {
        yield return new WaitForSeconds(interval);
        GameObject newPiece = Instantiate(piece, new Vector3(7.5f, 0.1f, 0), Quaternion.identity);

        StartCoroutine(spawnPieces(interval, getRandomPiece()));
    }


    private GameObject getRandomPiece()
    {
        if (Random.Range(0, 2) == 1)
        {
            return oneSocket;
        }
        return oneKnob;
    }
}
