using UnityEngine;

public class Distance : MonoBehaviour
{
    public float dist;
    public Transform photo1;
    public Transform photo2;
    public GameObject objPhoto1;
    public GameObject objPhoto2;
    public GameObject objPhoto12;

    // Use this for initialization
    void Start () {
        objPhoto12.SetActive(false);
	}
	
	// Update is called once per frame
	void Update ()
	{
        if (photo1.GetChild(0).GetComponent<MeshRenderer>()!=null)
	    {
            dist = Vector2.Distance(photo1.position, photo2.position);
            Debug.Log(dist);
	        if (dist < 1)
	        {
	            objPhoto12.SetActive(true);
	            objPhoto1.SetActive(false);
	            objPhoto2.SetActive(false);
	        }
	        else
	        {
	            objPhoto12.SetActive(false);
	            objPhoto1.SetActive(true);
	            objPhoto2.SetActive(true);
            }
	    }
    }
}
