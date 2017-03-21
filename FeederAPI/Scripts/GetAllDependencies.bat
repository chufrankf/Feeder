echo on
@rem Set Constants
set LogFile=GetAllDependencies.log
set FCRepros=C:\Users\frank\Documents\Git\Repos
set FCClassLibDir=%FCRepros%\FCLib\FCClassLib\FCClassLib\bin
set FeederAPIDir=%FCRepros%\FeederAPI\FeederAPI\Dependencies

echo ****** STARTING GetAllDependencies.bat at %date% %time% ******* >> %LogFile%

@rem copy files
echo **Copying FCClassLib Debug**
xcopy /y/r/i/f %FCClassLibDir%\Debug\*.dll %FeederAPIDir%\Debug\ >> %LogFile%

echo **Copying FCClassLib Release**
xcopy /y/r/i/f %FCClassLibDir%\Release\*.dll %FeederAPIDir%\Release\ >> %LogFile%
