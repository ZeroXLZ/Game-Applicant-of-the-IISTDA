using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using UnityEngine;

public class LicenseFileOpen : MonoBehaviour
{
    public void OpenFile()
    {
        Process.Start(Directory.GetCurrentDirectory()+ @"\license.txt");
    }
}
