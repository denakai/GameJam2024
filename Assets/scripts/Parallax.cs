using UnityEngine;

public class FitToCamera : MonoBehaviour
{
    private float length, startpos;
    [SerializeField] public GameObject cam;
    public float parallaxEffect;
    void Start()
    {
        startpos = transform.position.x;
        length = GetComponent<SpriteRenderer>().bounds.size.x;

    }
    void Update()
    {
        float temp = (cam.transform.position.x * (1 - parallaxEffect));
        float dist = (cam.transform.position.x * parallaxEffect);

        transform.position = new Vector3(startpos + dist, 1.4f, transform.position.z);


        if (temp > startpos + length)
        {
            startpos += length * 2;
        }
        else if (temp < startpos - length)
        {
            startpos -= length * 2;
        }

    }
}