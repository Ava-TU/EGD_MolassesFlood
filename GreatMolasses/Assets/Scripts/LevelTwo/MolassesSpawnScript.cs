using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MolassesSpawnScript : MonoBehaviour
{
    public float spawnSpeed = 0.5f;
    public GameObject molassesPrefab;

    [SerializeField] float minTrans;
    [SerializeField] float maxTrans;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(Spawn());
    }

    IEnumerator Spawn()
    {
        while (true)
        {
            var wanted = Random.Range(minTrans, maxTrans);
            var position = new Vector3(wanted, transform.position.y);
            GameObject gameObject = Instantiate(molassesPrefab, position, Quaternion.identity);
            yield return new WaitForSeconds(spawnSpeed);
            Destroy(gameObject, 5f);
        }
    }
}
