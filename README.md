# JunctionsManager
JunctionsManager is a part of Vizrex Utilities that we create for our in-house use. This utility is simply a UI on [`mklink`](https://technet.microsoft.com/en-us/library/cc753194(v=ws.11).aspx) command of Windows, to facilitate creation of Junctions or Soft Links in Windows environment.

## Background
At times, we need to follow a directory structure for our projects that is different than the hierarchy of our version control system. For example, we maintain a web projects on following path:

C:\Data\TFS\VizrexWeb\Src\vizrex-www

While in order to view this website in a web browser, we need to place it under the designated directory of a web server (e.g. XAMPP):
C:\Program Files\xampp\htdocs\vizrex-www
So we’ve three options:
1. Maintain the version control system in htdocs (in above example)
2. Keep the version control hireachy unchanged and maintain two separate copies of code
3. Map the concerned directory from version control hierarchy to required path

The first two options are unlikely to go with so only the third option is feasible. We can do so by creating a Soft Link between two directories. However, we still have to remember the syntax of command and as we need to do such operations usually in the beginning of a project only so it’s hard to remember it. Therefore, we created this utility.
If you want to read more about Soft Links or Junctions, please refer to this [link](https://msdn.microsoft.com/en-us/library/windows/desktop/aa365006(v=vs.85).aspx)

# Vizrex Utilities
We create several utilities for our in-house use, collectively named as Vizrex-Utilities. We have now begin to gradually make them open source. We warmly welcome your suggestions and contributions to these utilities. 
In order to contact or to know more about us, please visit our website http://vizrex.com

