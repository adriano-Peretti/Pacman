using System.Collections;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class BlinkSprite : MonoBehaviour
{
    public float Interval;

    private IEnumerator Start()
    {
        var spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.enabled = true;

        var waitCoroutine = new WaitForSeconds(Interval);

        while (true)
        {
            yield return waitCoroutine;
            spriteRenderer.enabled = !spriteRenderer.enabled;
        }
    }
}
