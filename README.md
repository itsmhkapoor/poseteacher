# Poseteacher
## Abstract
Learning complex movements can be a time consuming process, but it is necessary for the mastery of activities like Karate Kata, Yoga and dance choreographies. It is important to have a teacher in person to demonstrate the correct pose sequences step by step and correct errors in the student’s body postures.
In-person sessions can be impractical due to epidemics or travel distance, while videos make it hard to see the 3D postures of the teacher and of the students. As an alternative, we propose the teaching of poses in Augmented Reality (AR) with a virtual teacher and 3D avatars.

## Open source usage
This work is based on https://github.com/curiosity-inc/azure-kinect-dk-unity (MIT License), which is an example repo for how to use Azure Kinect DK. In particular, we used code from the fork https://github.com/Aviscii/azure-kinect-dk-unity. We upgraded the Azure Kinect Body Tracking SDK and Azure Kinect SDK.
As alternative to pose estimation with Kinect we used https://github.com/Daniil-Osokin/lightweight-human-pose-estimation-3d-demo.pytorch (Apache-2.0 License). 

## Environment
As of July 5, 2020, this repo has been tested under the following environment.
- Windows 10 Education N (Version 10.0.18363) with Media Feature Pack (important)
- [Azure Kinect Sensor SDK](https://docs.microsoft.com/en-us/azure/Kinect-dk/sensor-sdk-download) v1.4.0
- test by running k4aviewer.exe in C:\Program Files\Azure Kinect SDK v1.4.0\tools
- [Azure Kinect Body Tracking SDK](https://docs.microsoft.com/en-us/azure/Kinect-dk/body-sdk-download) v0.9.0
- test by running k4abt_simple_3d_viewer.exe in C:\Program Files\Azure Kinect Body Tracking SDK\tools
- Unity 2019.3.11f1 // newest Unity version at the moment
- CUDA v10.0 // try nvcc  --version (ONNX runtime officially only supports up to CUDA 10.0) 
- cudnn v7.5.1.10 // check C:\Program Files\NVIDIA GPU Computing Toolkit\CUDA\v10.2\include\cudnn.h

## Get Started
1. Clone the poseteacher2 repo.
2. 
    - a) With Azure Kinect: Copy the following files from Azure Kinect Sensor SDK or Azure Kinect Body Tracking SDK to the folder unity in the poseteacher2 repo:
    
    - k4a.dll (Body Tracking SDK or Kinect SDK)
    - k4abt.dll (Body Tracking SDK)
    - onnxruntime.dll (Body Tracking SDK)
    - depthengine_2_0.dll (Body Tracking SDK or Kinect SDK)
    - dnn_model_2_0.onnx (Body Tracking SDK)
    - make sure that cudnn is properly installed and in the path. Otherwise it might be necessary to add the     cudnn files to the unity folder as well. 

    - b) Without Azure Kinect or GPU: Clone https://github.com/Daniil-Osokin/lightweight-human-pose-estimation-3d-demo.pytorch and copy demo_ws.py into the repo. Then install the required packages according to the repo and run demo_ws.py. Beware that Pytorch still has issues with Python 3.8, so we recommend using Python 3.7.
3. Open Assets/PoseteacherScene
4. Most of the application logic is inside of the PoseteacherMain.cs script which is attached to the PoseteacherMain game object. There is also the HolographicRemotingScript.cs script to establish the connection via Holographic Remoting; in the Unity inspector the attribute "Hololens IP" needs to be set in order to connect automatically.
5. Click play inside the Unity editor.

## How to use
- It is recommended to use the UI to navigate in the application.
- For debugging we added the following keyboard shortcuts:
    - press X for normal operation
    - press Y for recording
    - press Z for playback
    - press L to load playback
    - press R to reset/delete saved playback


## Usefull links
- [MixedRealityKeyboard System keyboard Helper Classes](https://github.com/microsoft/MixedRealityToolkit-Unity/tree/mrtk_development/Assets/MRTK/SDK/Experimental/MixedRealityKeyboard)
- [MixedRealityKeyboard System keyboard Helper Classes documentation](https://microsoft.github.io/MixedRealityToolkit-Unity/Assets/MRTK/SDK/Experimental/MixedRealityKeyboard/README_MixedRealityKeyboard.html)
- [System keyboard example visualization script](https://github.com/microsoft/MixedRealityToolkit-Unity/blob/mrtk_development/Assets/MRTK/Examples/Demos/HandTracking/Scripts/SystemKeyboardExample.cs)
- [Experimental NonNativeKeyboard documentation (minimal)](https://microsoft.github.io/MixedRealityToolkit-Unity/api/Microsoft.MixedReality.Toolkit.Experimental.UI.NonNativeKeyboard.html)
