# MediaplayerOverlay

MediaplayerOverlay is a basic C# application that draws a small window anywhere on your screen that displays the name of the music that you are currently listening to. 


## Usage

Currently the application only supports reading now playing info from a file. By default, the file it reads from is set to <code>C:\Users\USERNAME\Documents\np.txt</code> but this can easily be changed. The default now playing format is based on %artist%|%track%, but this can be changed to your liking. 
The goal is to also support reading directly from your favourite media player.

Configuration is done via the config file that is created on first run, or by directly changing the default configuration in code. The edited default config will then be written  upon first run.
The configuration file is located at <code>C:\Users\USERNAME\Documents\playingoverlay.cfg</code>

#### Preview

![MediaplayerOverlay](https://user-images.githubusercontent.com/9129712/93131309-23a90300-f6d4-11ea-8027-8f46c6c9f05a.png)
