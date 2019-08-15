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
        //This method should allow us to access the file system within he home controller
        public async Task<IActionResult> Index()
        {
            string musicPath = await Electron.App.GetPathAsync(PathName.music);
            string[] mp3Files = Directory.GetFiles(musicPath, "*.mp3", SearchOption.TopDirectoryOnly);
            string[] mp4Files = Directory.GetFiles(musicPath, "*.mp4", SearchOption.TopDirectoryOnly);
            string[] wavFiles = Directory.GetFiles(musicPath, "*.wav", SearchOption.TopDirectoryOnly);

            List<string> musicFiles = new List<string>();
            musicFiles.AddRange(mp3Files);
            musicFiles.AddRange(mp4Files);
            musicFiles.AddRange(wavFiles);

            return View(musicFiles);
        }
    }
}