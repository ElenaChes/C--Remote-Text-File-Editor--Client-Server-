# C#&Console Remote File Editor Concept Using A Server.

A college project in C#, with the requerment to use a remote database/file directory and have permissions separation.
Note: The project is separated to a client side and a server(admin) side, but set to work on the same computer for testing purposes. 
(Adjust IP addresses in code before compiling to run accross computers in the same network)

# Installation

1. Run Server_Final. exe then Client_Final.exe from the Compiled folders in each section. 
or 
2. Compile Server_Final.sln then Client_Final.sln via Visual Studio.


# Usage
 
1. Login via the client form.
There's currently 3 users in the system: admin (pass: 123), user1 (pass: 111), user2 (pass: 222). To add new users, modify users.txt in the server section.

Users:
2. Load an existing text file from the user folder or open a new one.
3. Make changes to said file and save, it'll automatically get saved to the user's folder.

Admin:
2. Go through the user folders and manage the files.
3. Changes made by the admin won't affect the files, but only the admin can delete existing files.