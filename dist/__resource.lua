resource_manifest_version '44febabe-d386-4d18-afbe-5e627f4af937'

--dependency 'NativeUI'

files {
	'HandlingInfo.xml',
	'HandlingPresets.xml',
	'VehiclesPermissions.xml',
	'config.ini'
}
client_script {
	--'@NativeUI/NativeUI.net.dll',
	'NativeUI.net.dll',
	'System.Xml.Mono.net.dll',
	'HandlingEditor.Client.net.dll'
}