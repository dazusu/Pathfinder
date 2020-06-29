# Pathfinder
This is a test app for testing Navmeshes for FFXI, you can also dump zone collision data to obj and build the navmeshes for zones.

Pathfinder will Download the Navmeshes i have uploaded to Github.
it will do this when you first start the app, it will not do it if you already have the navmeshes in "dumped navmeshes" folder.

Please run pathfinder as Admin and make sure you are fully logged into FFXI.


Navmeshes will load when you zone or first load the app, you can click unload and load at any time.

# Path Test To Points Of Interest Tab

To test a navmeshe 
 *1 Load Points of interest 
 *2 Select Point of interest
 *3 Hit start
 
 this test app using the kb to move in ffxi, for better results you might want to use EliteMMO SetAutoFollow function.


# Dat Tab
Here you can dump the zone collision data to an obj file,

 *1 Click Load Zones  
 # this zone dat list is provided by Devi Ltti (Thanks Devi) and converted to xml by me.
 
 *2 you can Select a zone to dump or click dump all map dats.
 # you will notice some zones are commented out in the zonelist.xml file, this is because you can not dump them with pathfinder.exe.
If i can't export the zone.dat using pathfinder.exe then i use Noesis to export the zone to obj file. To export maps so they are compatible with FFXINAV.dll please use the following settings.

Output type = obj.
Advanced Export Options:

-rotate 180 0 -90 -fbxsmoothgroups -fbxtexrelonly -fbxtexext .tga

You can download Noesis from the link below.
https://richwhitehouse.com

to pathfind with meshes made with the files from noesis using FFXINAV.dll you need to set 
# FindPath(start,end,True).


#NavMesh Tab

here you can build navmeshes using FFXINAV.dll

the settings you see are the default settings i have dumped all the zones for. 
some zones you may need to change MaxClimb, for example zone 271 maxclimb is 0.3

