[![GitHub release][release-img]][release]
[![License][license-img]][license]
![Downloads][download]

 <img src="https://github.com/cyberark/RPCMon/blob/assets/RPCMonLogo.png" width="260">   
A GUI tool for scanning RPC communication through Event Tracing for Windows (ETW).  
The tool was published as part of a research on RPC communication between the host and a Windows container.  

## Overview
RPCMon can help researchers to get a high level view over an RPC communication between processes. It was built like Procmon for easy usage, and uses James Forshaw .NET library for RPC. RPCMon can show you the RPC functions being called, the process who called them, and other relevant information.  
RPCMon uses a hardcoded RPC dictionary for fast RPC information processing which contains information about RPC modules. It also has an option to build an RPC database so it will be updated from your computer in case some details are missing in the hardcoded RPC dictionary. 


## Usage

Double click the EXE binary with **Admin privileges** ("Run As Administrator") and you will get the GUI Windows.  
RPCMon needs a DB to be able to get the details on the RPC functions, without a DB you will have missing information.   
To load the DB, press on `DB -> Load DB...` and choose your DB. You can a DB we added to this project: `/DB/RPC_UUID_Map_Windows10_1909_18363.1977.rpcdb.json`.  

## Build
When downloading it from GitHub you might get error of block files, you can use PowerShell to unblock them:  
```pwoershell
Get-ChildItem -Path 'D:\tmp\PipeViewer-main' -Recurse | Unblock-File
```
## Features
* A detailed overview of RPC functions activity.
* Build an RPC database to parse RPC modules or use hardcoded database.
* Filter\highlight rows based on cells.
* Bold specific rows.

## Demo  

https://user-images.githubusercontent.com/11998736/165285471-e143eebd-bfbf-49a2-8e70-107f083c60fc.mp4

## Credit
We want to thank James Forshaw ([@tyranid](https://github.com/tyranid)) for creating the open source [NtApiDotNet](https://github.com/googleprojectzero/sandbox-attacksurface-analysis-tools/tree/main/NtApiDotNet) which allowed us to get the RPC functions.  

## License
Copyright (c) 2022 CyberArk Software Ltd. All rights reserved  
This repository is licensed under  Apache-2.0 License - see [`LICENSE`](LICENSE) for more details.


## References:
For more comments, suggestions or questions, you can contact Eviatar Gerzi ([@g3rzi](https://twitter.com/g3rzi)) and CyberArk Labs.

[release-img]: https://img.shields.io/github/release/cyberark/RPCMon.svg
[release]: https://github.com/cyberark/RPCMon/releases

[license-img]: https://img.shields.io/github/license/cyberark/RPCMon.svg
[license]: https://github.com/cyberark/RPCMon/blob/master/LICENSE

[download]: https://img.shields.io/github/downloads/cyberark/RPCMon/total?logo=github
