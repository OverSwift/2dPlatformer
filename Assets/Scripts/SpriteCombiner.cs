using UnityEngine;
using System.Collections;

[RequireComponent (typeof(SpriteRenderer))]
public class SpriteCombiner : MonoBehaviour {

	public void CombineChildren() {

		SpriteRenderer sr = GetComponent<SpriteRenderer> ();
		SpriteRenderer[] renderers = GetComponentsInChildren<SpriteRenderer> ();
		print ("Child sprite renderers " + renderers.Length + " count");

		float finalTextureW = 0f;
		float finalTextureH = 0f;



		for (int i = 0; i < renderers.Length; i++) {
			Sprite sprite = renderers [i].sprite;

			if (sprite == null) {
				print ("Opps renderer without sprite");
				continue;
			}
			Texture2D texture = sprite.texture;

//			print ("Sprite bounds: " + sprite.bounds);

			print ("Transform : " + renderers [i].transform.localPosition);
			print ("Texture size w:" + texture.width + "h:" + texture.height);
		}
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
