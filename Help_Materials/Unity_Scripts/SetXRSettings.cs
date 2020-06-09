using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class SetXRSettings : MonoBehaviour
{
    public float TextureResolutionScale = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
        XRSettings.eyeTextureResolutionScale = TextureResolutionScale;

        // Activate for Oculus only:
        // OVRManager.tiledMultiResLevel = OVRManager.TiledMultiResLevel.LMSMedium;
    }

}
