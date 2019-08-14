using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using ElectronNET.API;
using ElectronNET.API.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ElectronMusicPlayer.Controllers
{
    public class HomeController : Controller
    {
<<<<<<< HEAD
        //This method should allow us to access the file system within he home controller
=======
>>>>>>> 743ce4548a1135ed2dff4daecb79f20aaa30a1a5
        public async Task<IActionResult> Index()
        {
            string musicPath = await Electron.App.GetPathAsync(PathName.music);
            string[] mp3Files = Directory.GetFiles(musicPath, "*.mp3", SearchOption.TopDirectoryOnly);
            string[] mp4Files = Directory.GetFiles(musicPath, "*.mp4", SearchOption.TopDirectoryOnly);
<<<<<<< HEAD
            string[] wavFiles = Directory.GetFiles(musicPath, "*.wav", SearchOption.TopDirectoryOnly);
=======
>>>>>>> 743ce4548a1135ed2dff4daecb79f20aaa30a1a5

            List<string> musicFiles = new List<string>();
            musicFiles.AddRange(mp3Files);
            musicFiles.AddRange(mp4Files);
<<<<<<< HEAD
            musicFiles.AddRange(wavFiles);
=======
>>>>>>> 743ce4548a1135ed2dff4daecb79f20aaa30a1a5

            return View(musicFiles);
        }
    }
}