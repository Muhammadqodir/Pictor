using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loadImg : MonoBehaviour
{
	public Sprite[] sprites;
    // Start is called before the first frame update
    void Start()
    {
    	int spriteId = PlayerPrefs.GetInt("selIImgId");
    	Debug.Log(spriteId);
    	GetComponent<SpriteRenderer>().sprite = sprites[spriteId];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
