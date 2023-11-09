using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMap : MonoBehaviour
{
    int[,] map;
    int[] shelf = new int[8];
    int sizeX = 10;
    int sizeY = 10;
    float clickableSizeX = 0.3f;
    float clickableSizeY = 0.3f;
    public GameObject clickable;

    Color[] colors = new Color[] {
        Color.clear,
        Color.black,
        Color.red,
        Color.green,
        Color.yellow
    };

    // Start is called before the first frame update
    void Start()
    {
        generateMap();
        spawnClickables();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void generateMap() {
        map = new int[sizeX,sizeY];
        for (int i = 0; i < sizeX; i++) {
            for( int j = 0; j < sizeY; j++) {
                map[i,j] = Random.Range(0,5);
                //Debug.Log(map[i,j]);
            }
        }
        Debug.Log(map);
    }

    void spawnClickables() {
        float distMod = 0.4f;
        float offsetX = -1f;
        float offsetY = 0f;
        for(int i = 0; i < map.GetLength(0); i++) {
            for(int j = 0; j < map.GetLength(1); j++) {
                GameObject myClickable = Instantiate(clickable, new Vector3(i*distMod + offsetX,j*distMod + offsetY ,0),Quaternion.identity);
                SpriteRenderer spriteRenderer = myClickable.GetComponent<SpriteRenderer>();
                spriteRenderer.color = colors[map[i,j]];
                myClickable.transform.localScale = new Vector3(clickableSizeX, clickableSizeY, 1f);
                myClickable.GetComponent<ClickTest>().mapRef = this.gameObject;
                myClickable.GetComponent<ClickTest>().setPosition(i,j);
                Debug.Log(map[i,j]);
            }
        }
    }

    public int getValue(int x, int y) {
        return map[x,y];
    }

    public void clickClickable(int x, int y) {
        
    }
}
