# Remote File Editor.

<img align="right" style="width:300px; height:auto;" src="https://github.com/ElenaChes/Csharp-Remote-Text-File-Editor--Client-Server/assets/54331769/e6d880dc-e91d-4ac6-8573-655af068ac02">


A college project in C# using server-client sides.<br>
Description: a file editor with a remote file directory and permission management.

> The project is separated into a client side and a server(admin) side, but set to work on the same computer for testing purposes.<br>
(Adjust IP addresses in code before compiling to run accross computers in the same network)

<img align="right" style="width:400px; height:auto;" src="https://github.com/ElenaChes/Csharp-Remote-Text-File-Editor--Client-Server/assets/54331769/7ef365c6-fb99-4954-aca6-f6de1410658f">

# Installation

1. Run `Server_Final/Compiled/Server_Final.exe`.
2. Run `Client_Final/Compiled/Client_Final.exe`.

or 

1. Compile `Server_Final/Server_Final.sln` via Visual Studio.
2. Compile `Client_Final/Client_Final.sln` via Visual Studio.


# Usage
 
1. Login via the client form.

There's currently 3 users in the system:
- admin (pass: 123)
- user1 (pass: 111)
- user2 (pass: 222)

### To add new users:
- If running the compiled files, modify: `Server_Final/Compiled/users.txt`
- If running via Visual Studio, modify: `Server_Final/Server_Final/bin/Debug/users.txt`

## Users:

2. Load an existing text file from the user folder or open a new one.
3. Make changes to the file and save, the filewill get updated on the server's end.

## Admin:

2. Go through the user folders and manage the files.
3. Changes made by the admin won't affect the files, but only the admin can delete existing files.
