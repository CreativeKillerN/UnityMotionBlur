place "MotionBlurShader".shader in your project's Shaders folder.

Create a new material using the MotionBlurShader. Assign it to the objects you want to apply the motion blur effect to.

attach "MotionBlur.cs" to the camera.

Create an empty GameObject and attach the MotionBlur script to it. Assign the MotionBlurShader material you created earlier to the motionBlurMaterial field in the script.

In the Inspector, adjust the blurAmount parameter in the MotionBlur script to control the intensity of the motion blur effect.

Now, when you run your scene, the objects with the assigned material will have a motion blur effect applied to them. This is a simplified example, and there are more advanced techniques and optimizations you can use for motion blur, such as using velocity information from the depth buffer or using more complex shaders.

At the moment I am going to be creating more game dev Add-ons as I am trying to get into game development