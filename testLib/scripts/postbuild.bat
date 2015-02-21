cd ..\bin\Debug
xcopy "testLib.dll" "..\..\..\libTestApp\bin\Debug" /D /y /s /r /I
xcopy "testLib.dll" "..\..\..\testService\bin\Debug" /D /y /s /r /I
exit