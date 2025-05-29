using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

public class CameraController : Singleton<CameraController>
{
  private CinemachineVirtualCamera cinemachineVirtualCamera;

  public void SetupPlayerCameraFollow()
  {
    cinemachineVirtualCamera = FindObjectOfType<CinemachineVirtualCamera>();
    cinemachineVirtualCamera.Follow = PlayerController.Instance.transform;
  }
}
