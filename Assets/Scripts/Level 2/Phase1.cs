using UnityEngine;
using System.Collections;

public class Phase1 : MonoBehaviour
{
    public GameObject energy;
    public GameObject startFight;
    public bool Right = false;
    public bool Bottom = false;
    public bool Left = false;
    public bool Top = false;
    void Start()
    {
        
    }
    void Update()
    {
        if (startFight == null)
        {
            energy.SetActive(true);

        }
    }
   
    IEnumerator PhaseOne()
    {
        yield return new WaitForSeconds(1f);
        energy.transform.Translate(Vector3.right * 10f * Time.deltaTime);
        yield return new WaitForSeconds(1f);
        energy.transform.Translate(Vector3.down * 10f * Time.deltaTime);
        yield return new WaitForSeconds(1f);
        energy.transform.Translate(Vector3.left * 10f * Time.deltaTime);
        yield return new WaitForSeconds(1f);
        energy.transform.Translate(Vector3.up * 10f * Time.deltaTime);
        yield return new WaitForSeconds(1f);
    }
}
