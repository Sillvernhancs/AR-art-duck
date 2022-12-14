using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationCycle : MonoBehaviour
{
    public Texture M1;
    public Texture M2;
    public Texture M3;
    public Texture M4;
    public Texture M5;

    [SerializeField] private  float fps = 10.0f;

    private Material matt;
    private Texture[] frames = new Texture[5];

    void Start()
    {
        frames[0] = M1;
        frames[1] = M2;
        frames[2] = M3;
        frames[3] = M4;
        frames[4] = M5;

        matt = GetComponent<Renderer> ().material;
    }

    // Update is called once per frame
    void Update()
    {
        updateTexture();
        int index = (int)(Time.time * fps);
        index = index % frames.Length;
        matt.mainTexture = frames[index];
    }

    IEnumerator updateTexture()
    {
        yield return new WaitForSeconds(2f);
    }
}
