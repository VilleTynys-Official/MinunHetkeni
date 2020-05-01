using System;
using System.Collections.Generic;
using MediaManager;
using Xamarin.Forms;
using Plugin.SimpleAudioPlayer;
using System.IO;
using System.Reflection;

namespace MinunHetkeni
{

    
    public partial class MeditaatiotPage : ContentPage
    {
        public MeditaatiotPage()
        {
            InitializeComponent();
        }



        void PlayVideo(System.Object sender, System.EventArgs e)
        {
            var player = CrossSimpleAudioPlayer.Current;
            player.Load("why.mp3"); 
            player.Play();

        }

    }
}
