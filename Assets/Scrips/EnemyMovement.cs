using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float enemyShipSpeed;
    Transform _ComponentTransform;
    // Start is called before the first frame update
    void Awake()
    {
        _ComponentTransform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        _ComponentTransform.position = new Vector2(_ComponentTransform.position.x, _ComponentTransform.position.y - 1 * enemyShipSpeed * Time.deltaTime);
        if (_ComponentTransform.position.y <= -6.5)
        {
            Destroy(this.gameObject);
        }
    }
}
