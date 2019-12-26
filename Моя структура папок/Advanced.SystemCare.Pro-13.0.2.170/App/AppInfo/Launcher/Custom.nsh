${SegmentFile}

!addplugindir '${PACKAGE}\App\AppInfo\Launcher\CUSTOM_PLUGIN'

!define CUSTOM_ASCAPPDIR '$AppDirectory\AdvancedSystemCare'

Var CUSTOM_LOGGEDINUSER

${SegmentPreExec}
	; get user name and update default values
	System::Call "advapi32::GetUserName(t .r0, *i ${NSIS_MAX_STRLEN} r1) i.r2"
	StrCpy $CUSTOM_LOGGEDINUSER $0
	WriteINIStr '$DataDirectory\PD\Advanced SystemCare\AscService.ini' SkipUacTask 'ASC12_SkipUac_$CUSTOM_LOGGEDINUSER' 0
!macroend

${SegmentPostPrimary}
	${DebugMsg} "Check for local IObit ASC, if not exist then cleanup..."
	${IfNot} ${RegistryKeyExists} 'HKLM\SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall\Advanced SystemCare_is1'
 		DeleteRegValue HKCU 'Software\Microsoft\Windows\CurrentVersion\Run' 'Advanced SystemCare 12'
 		DeleteRegValue HKCU 'Software\Microsoft\Windows\CurrentVersion\Run' SmartRAM

		${DebugMsg} "Remove folders and files leftovers"
		ReadEnvStr $0 ALLUSERSAPPDATA
		RMDir /r "$0\IObit"

		ReadEnvStr $0 USERPROFILE
		RMDir '$0\AppData\LocalLow\IObit\Advanced SystemCare'
		RMDir '$0\AppData\LocalLow\IObit\SafeBrowse'
		RMDir '$0\AppData\LocalLow\IObit'
	${EndIf}

	; shutdown dlls...
	${DebugMsg} "Shutdown DLLs"
	nsExec::ExecToStack '$SYSDIR\regsvr32.exe /s /u "${CUSTOM_ASCAPPDIR}\Surfing Protection\BrowerProtect\ASCPlugin_Protection.dll"'

	; It's Ok to shutdown these services, the local app if installed will start it again if run
	${DebugMsg} "Shutdown services"
	nsExec::ExecToStack '"SC.EXE" STOP AdvancedSystemCareService12'
	nsSCM::Stop /NOUNLOAD "AdvancedSystemCareService12"
	nsExec::ExecToStack '"SC.EXE" DELETE AdvancedSystemCareService12'
	nsSCM::Remove /NOUNLOAD "AdvancedSystemCareService12"
	DeleteRegKey HKLM 'SYSTEM\ControlSet001\services\AdvancedSystemCareService12'
	DeleteRegKey HKLM 'SYSTEM\CurrentControlSet\services\AdvancedSystemCareService12'

	nsExec::ExecToStack '"SC.EXE" STOP cpuz143'
	nsSCM::Stop /NOUNLOAD "cpuz143"
	nsExec::ExecToStack '"SC.EXE" DELETE cpuz143'
	nsSCM::Remove /NOUNLOAD "cpuz143"
	DeleteRegKey HKLM 'SYSTEM\ControlSet001\services\cpuz143'
	DeleteRegKey HKLM 'SYSTEM\CurrentControlSet\services\cpuz143'
	
	nsExec::ExecToStack '"SC.EXE" STOP iobit_monitor_server'
	nsSCM::Stop /NOUNLOAD "iobit_monitor_server"
	nsExec::ExecToStack '"SC.EXE" DELETE iobit_monitor_server'
	nsSCM::Remove /NOUNLOAD "iobit_monitor_server"
	DeleteRegKey HKLM 'SYSTEM\ControlSet001\Services\iobit_monitor_server'
	DeleteRegKey HKLM 'SYSTEM\CurrentControlSet\Services\iobit_monitor_server'
	
	nsExec::ExecToStack '"SC.EXE" STOP TrkWks'
	nsSCM::Stop /NOUNLOAD "TrkWks"
	nsExec::ExecToStack '"SC.EXE" DELETE TrkWks'
	nsSCM::Remove /NOUNLOAD "TrkWks"
	DeleteRegKey HKLM 'SYSTEM\ControlSet001\Services\TrkWks'
	DeleteRegKey HKLM 'SYSTEM\CurrentControlSet\Services\TrkWks'

	${DebugMsg} "Remove tasks and startups"
	nsExec::ExecToStack '"$SYSDIR\schtasks.exe" /Delete /TN ASC12_AutoCare /F'
	nsExec::ExecToStack '"$SYSDIR\schtasks.exe" /Delete /TN ASC12_PerformanceMonitor /F'
	; delete %SystemDrive%\Windows\System32\Tasks\ASC12_SkipUac_ThumbApps
	nsExec::ExecToStack '"$SYSDIR\schtasks.exe" /Delete /TN "ASC12_SkipUac_$CUSTOM_LOGGEDINUSER" /F'

	${DebugMsg} "Shutdown persistence apps on exit"
	FindProcDLL::KillProc 'RealTimeProtector.exe'

	${DebugMsg} "Cleanup unwanted downloaded setup installers or executables"
	Delete '${CUSTOM_ASCAPPDIR}\Dashlane_Launcher.exe'
	Delete '${CUSTOM_ASCAPPDIR}\DriverBooster.exe'
	Delete '${CUSTOM_ASCAPPDIR}\IMF.exe'
	Delete '${CUSTOM_ASCAPPDIR}\IObitUninstaller.exe'
	Delete '${CUSTOM_ASCAPPDIR}\LiveUpdate.exe'
	Delete '${CUSTOM_ASCAPPDIR}\SmartDefrag.exe'
	Delete '${CUSTOM_ASCAPPDIR}\SPSetup.exe'
	Delete '${CUSTOM_ASCAPPDIR}\ASCService.exe'
	Delete '${CUSTOM_ASCAPPDIR}\RealTimeProtector.exe'
	RMDir /r '${CUSTOM_ASCAPPDIR}\Surfing Protection'

	${DebugMsg} "Cleanup -FilesMove files"
	Delete '$DataDirectory\PD\dnsprotect.ini'
	Delete '$DataDirectory\PD\LocalOpted.ini'
	Delete '$DataDirectory\AUpdate.ini'
	Delete '$DataDirectory\DriveDetection.ini'
	Delete '$DataDirectory\UsrClass.dat.iobit'

	${DebugMsg} "Delete warning..."
	Delete '${CUSTOM_ASCAPPDIR}\ASCVER.exe'
!macroend
