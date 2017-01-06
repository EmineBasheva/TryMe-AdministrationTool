@rem Generate the C# code for .proto files

setlocal

@rem enter this directory
cd /d %~dp0

set TOOLS_PATH=packages\Grpc.Tools.1.0.1\tools\windows_x64

%TOOLS_PATH%\protoc.exe -I./AdminDesk/protos --csharp_out AdminDesk  ./AdminDesk/protos/admin_tool.proto --grpc_out AdminDesk --plugin=protoc-gen-grpc=%TOOLS_PATH%\grpc_csharp_plugin.exe

endlocal
pause