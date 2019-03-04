<# This form was created using POSHGUI.com  a free online gui designer for PowerShell
.NAME
    Lynx-Wrapper 2.0
.SYNOPSIS
    Hlper Application for Lynx
.DESCRIPTION
    This application helps with using Finishlynx by organizing folder for you and giving you quick access and overview over all races of the current event.
#>

Add-Type -AssemblyName System.Windows.Forms
[System.Windows.Forms.Application]::EnableVisualStyles()

$LynxWrapper                  = New-Object system.Windows.Forms.Form
$LynxWrapper.ClientSize       = '500,565'
$LynxWrapper.text             = "Lynx-Wrapper"
$LynxWrapper.BackColor        = "#c8c8c8"
$LynxWrapper.TopMost          = $false

$TTOptions                       = New-Object system.Windows.Forms.ToolTip
$TTOptions.ToolTipTitle          = "Optionen"

$Options                         = New-Object system.Windows.Forms.Button
$Options.BackColor               = "#ffffff"
$Options.text                    = "Optionen"
$Options.width                   = 120
$Options.height                  = 35
$Options.location                = New-Object System.Drawing.Point(30,15)
$Options.Font                    = 'Microsoft Sans Serif,12,style=Bold'

$TTRefresh                       = New-Object system.Windows.Forms.ToolTip
$TTRefresh.ToolTipTitle          = "Aktualisieren"

$Refresh                         = New-Object system.Windows.Forms.Button
$Refresh.BackColor               = "#ffffff"
$Refresh.text                    = "Aktualisieren"
$Refresh.width                   = 120
$Refresh.height                  = 35
$Refresh.location                = New-Object System.Drawing.Point(350,15)
$Refresh.Font                    = 'Microsoft Sans Serif,12,style=Bold'

$RaceList                        = New-Object system.Windows.Forms.ListView
$RaceList.text                   = "listView"
$RaceList.width                  = 460
$RaceList.height                 = 400
$RaceList.visible                = $true
$RaceList.enabled                = $true
$RaceList.location               = New-Object System.Drawing.Point(20,65)

$TTNewRaceSingle                 = New-Object system.Windows.Forms.ToolTip
$TTNewRaceSingle.ToolTipTitle    = "Neue Läufe (Single User)"

$ShowNewRaceSingle               = New-Object system.Windows.Forms.CheckBox
$ShowNewRaceSingle.text          = "Neue Läufe (Single User)"
$ShowNewRaceSingle.AutoSize      = $false
$ShowNewRaceSingle.BackColor     = "#ffff4d"
$ShowNewRaceSingle.width         = 200
$ShowNewRaceSingle.height        = 25
$ShowNewRaceSingle.location      = New-Object System.Drawing.Point(30,480)
$ShowNewRaceSingle.Font          = 'Microsoft Sans Serif,10'

$TTNewRaceMulti                  = New-Object system.Windows.Forms.ToolTip
$TTNewRaceMulti.ToolTipTitle     = "Neue Läufe (Multi User)"

$ShowNewRaceMulti                = New-Object system.Windows.Forms.CheckBox
$ShowNewRaceMulti.text           = "Neue Läufe (Multi User)"
$ShowNewRaceMulti.AutoSize       = $false
$ShowNewRaceMulti.BackColor      = "#38ea2e"
$ShowNewRaceMulti.width          = 200
$ShowNewRaceMulti.height         = 25
$ShowNewRaceMulti.location       = New-Object System.Drawing.Point(270,480)
$ShowNewRaceMulti.Font           = 'Microsoft Sans Serif,10'

$TTNotJudgedRace                 = New-Object system.Windows.Forms.ToolTip
$TTNotJudgedRace.ToolTipTitle    = "Nicht ausgewertete Läufe"

$ShowNotJudgedRace               = New-Object system.Windows.Forms.CheckBox
$ShowNotJudgedRace.text          = "Nicht ausgewertete Läufe"
$ShowNotJudgedRace.AutoSize      = $false
$ShowNotJudgedRace.BackColor     = "#66a3ff"
$ShowNotJudgedRace.width         = 200
$ShowNotJudgedRace.height        = 25
$ShowNotJudgedRace.location      = New-Object System.Drawing.Point(30,520)
$ShowNotJudgedRace.Font          = 'Microsoft Sans Serif,10'

$TTJudgedRace                    = New-Object system.Windows.Forms.ToolTip
$TTJudgedRace.ToolTipTitle       = "Zeige ausgewertete Läufe"

$ShowJudgedRace                  = New-Object system.Windows.Forms.CheckBox
$ShowJudgedRace.text             = "Ausgewertete Läufe"
$ShowJudgedRace.AutoSize         = $false
$ShowJudgedRace.BackColor        = "#ff80ff"
$ShowJudgedRace.width            = 200
$ShowJudgedRace.height           = 20
$ShowJudgedRace.location         = New-Object System.Drawing.Point(270,520)
$ShowJudgedRace.Font             = 'Microsoft Sans Serif,10'

$TTOptions.SetToolTip($Options,'Öffnet das Optionsmenü')
$TTRefresh.SetToolTip($Refresh,'Liste der Läufe aktualisieren')
$TTNewEventSingle.SetToolTip($ShowNewRaceSingle,'Zeige gespeicherte Läufe ohne Bilddaten (Single User)')
$TTShowNewEventMulti.SetToolTip($ShowNewRaceMulti,'Zeige gespeicherte Läufe ohne Bilddaten (Multi User)')
$TTNotJudged.SetToolTip($ShowNotJudgedRace,'Zeige Läufe mit Bilddaten, die noch nicht ausgewertet sind')
$TTJudgedRace.SetToolTip($ShowJudgedRace,'undefined')
$LynxWrapper.controls.AddRange(@($Options,$Refresh,$RaceList,$ShowNewRaceSingle,$ShowNewRaceMulti,$ShowNotJudgedRace,$ShowJudgedRace))

$RaceList.Add_Click({ handleListviewclick $this $_ })

function handleListviewclick ($sender,$event) { }


#Write your logic code here

[void]$LynxWrapper.ShowDialog()