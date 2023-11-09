using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickTest : MonoBehaviour
{
    private int posX = 0;
    private int posY = 0;
    public GameObject mapRef = null;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update () {
        
    }

    void OnMouseDown() {
        Debug.Log("CLICKED");
        if (getType() == 0 || getType() == 1) {
            //Do nothing
        } else {
            Destroy(this.gameObject);
        }
        
        //this.gameObject.transform.position = new Vector3(Random.Range(-1,1),Random.Range(-1,2),0);
    }

    private int getType() {
        return mapRef.GetComponent<GameMap>().getValue(posX, posY);
        //return 0;
    }

    public void setPosition(int x, int y) {
        posX = x;
        posY = y;
    }
}
