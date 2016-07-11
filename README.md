# VLCHandler
Small windows app in C# to handle vlchandler:// URL (open vlc from web browser) 

Setup : 
--------------------------
* Open `Media_streamingVLC.exe`
* Follow instructions to install the VLC handler

Usage : 
-------------------------
You can now open links like `vlchandler:http://download.blender.org/peach/bigbuckbunny_movies/big_buck_bunny_480p_surround-fix.avi` in your web browser !

It will directly open VLC Media Player and directly stream the video/audio file !

It's simple implementation of windows URL Scheme with VLC Media Player !
(Never found a such solution on the net, the reason why i've developped that !)

Note :
----------
* It need a proper installation of VLC Media player
* ConsoleApplication1 only contain the linker itself. It's embeded in the installer `Media_streamingVLC.exe` (that also register the URL Scheme using regedit)
