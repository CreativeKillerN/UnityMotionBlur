using UnityEngine;

public class MotionBlur : MonoBehaviour
{
    public Material motionBlurMaterial;
    public float blurAmount = 0.5f;

    private RenderTexture previousFrame;

    private void OnEnable()
    {
        previousFrame = new RenderTexture(Screen.width, Screen.height, 0);
        previousFrame.Create();
    }

    private void OnRenderImage(RenderTexture source, RenderTexture destination)
    {
        Graphics.Blit(source, previousFrame);
        motionBlurMaterial.SetFloat("_BlurAmount", blurAmount);
        Graphics.Blit(previousFrame, destination, motionBlurMaterial);
    }

    private void OnDisable()
    {
        Destroy(previousFrame);
    }
}
