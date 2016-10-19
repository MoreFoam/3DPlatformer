using UnityEngine;
using System.Collections;

[ExecuteInEditMode]
public class Level1_Changes : MonoBehaviour {

	// Use this for initialization
	void Start () {
		makeThingsNice(true);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void makeThingsNice(bool makeNice) {

		if (makeNice) {

			GameObject.Find ("TheRiver").GetComponent<MeshRenderer> ().sharedMaterial.SetColor ("_RefrColor", new Color (.937f, .937f, .937f, 1.00f));
			GameObject.Find ("Lake").GetComponent<MeshRenderer> ().sharedMaterial.SetColor ("_RefrColor", new Color (.937f, .937f, .937f, 1.00f));

			Material sunnySkybox = (Material)Resources.Load ("SkyBrightMorning", typeof(Material));

			RenderSettings.skybox = sunnySkybox;

			Texture cleanWaterFallTexture = (Texture)Resources.Load ("Waterfall Texture", typeof(Texture));

			GameObject.Find ("PSWater").GetComponent<ParticleSystem> ().GetComponent<Renderer> ().sharedMaterial.SetTexture ("_MainTex", cleanWaterFallTexture);

			GameObject.Find ("Door").GetComponent<Transform> ().rotation = Quaternion.Euler (0, -90, 0);
			GameObject.Find ("Door").GetComponent<Transform> ().position = new Vector3 (66.48f, 4f, 243.57f);

			GameObject.Find ("Background Music").GetComponent<AudioSource>().pitch=1f;

			GameObject.Find ("Sun").GetComponent<Light>().intensity=1.2f;

			GameObject.Find ("Extra Light 1").GetComponent<Light>().intensity=.2f;
			GameObject.Find ("Extra Light 2").GetComponent<Light>().intensity=.2f;
			GameObject.Find ("Extra Light 3").GetComponent<Light>().intensity=.2f;

			for (var i=3;i<=5;i++) {
				GameObject.Find ("Broken Bridge Piece "+i).GetComponent<BoxCollider>().enabled=false;
				GameObject.Find ("Broken Bridge Piece "+i).GetComponent<MeshRenderer>().enabled=false;
			}
			GameObject.Find ("Fixed Bridge Piece").GetComponent<BoxCollider>().enabled=true;
			GameObject.Find ("Fixed Bridge Piece").GetComponent<MeshRenderer>().enabled=true;

			RenderSettings.fog = false;

			Texture niceGrassTexture = (Texture)Resources.Load ("Nice Grass Texture", typeof(Texture));

			GameObject.Find ("Terrain").GetComponent<Terrain> ().terrainData.splatPrototypes [1].texture = (Texture2D)niceGrassTexture;
			GameObject.Find ("Terrain").GetComponent<Terrain> ().Flush ();

			Debug.Log (GameObject.Find ("Terrain").GetComponent<Terrain> ().terrainData.splatPrototypes[1].texture);
			Debug.Log ((Texture2D)niceGrassTexture);

		} else {

			GameObject.Find ("TheRiver").GetComponent<MeshRenderer> ().sharedMaterial.SetColor ("_RefrColor", new Color (.675f, .525f, .078f, 1.00f));
			GameObject.Find ("Lake").GetComponent<MeshRenderer> ().sharedMaterial.SetColor ("_RefrColor", new Color (.675f, .525f, .078f, 1.00f));
			
			Material cloudySky = (Material)Resources.Load ("SkyHaloSky", typeof(Material));
			
			RenderSettings.skybox = cloudySky;
			
			Texture dirtyWaterFallTexture = (Texture)Resources.Load ("Dirty Waterfall Texture", typeof(Texture));
			
			GameObject.Find ("PSWater").GetComponent<ParticleSystem> ().GetComponent<Renderer> ().sharedMaterial.SetTexture ("_MainTex", dirtyWaterFallTexture);
			
			GameObject.Find ("Door").GetComponent<Transform> ().rotation = Quaternion.Euler (0, 180, 0);
			GameObject.Find ("Door").GetComponent<Transform> ().position = new Vector3 (68.98f, 4f, 246.07f);

			GameObject.Find ("Background Music").GetComponent<AudioSource>().pitch=.5f;

			GameObject.Find ("Sun").GetComponent<Light>().intensity=.8f;

			GameObject.Find ("Extra Light 1").GetComponent<Light>().intensity=.1f;
			GameObject.Find ("Extra Light 2").GetComponent<Light>().intensity=.1f;
			GameObject.Find ("Extra Light 3").GetComponent<Light>().intensity=.1f;

			for (var i=3;i<=5;i++) {
				GameObject.Find ("Broken Bridge Piece "+i).GetComponent<BoxCollider>().enabled=true;
				GameObject.Find ("Broken Bridge Piece "+i).GetComponent<MeshRenderer>().enabled=true;
			}
			GameObject.Find ("Fixed Bridge Piece").GetComponent<BoxCollider>().enabled=false;
			GameObject.Find ("Fixed Bridge Piece").GetComponent<MeshRenderer>().enabled=false;

			RenderSettings.fog = true;

		}
	}
}
