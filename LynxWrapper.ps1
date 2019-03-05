<# This form was created using POSHGUI.com  a free online gui designer for PowerShell
.NAME
    Lynx-Wrapper
.SYNOPSIS
    Helper Application for Lynx
.DESCRIPTION
    This application helps with using Finishlynx by organizing folder for you and giving you quick access and overview over all races of the current event.
#>

Add-Type -AssemblyName System.Windows.Forms
Add-Type -AssemblyName System.Drawing
[System.Windows.Forms.Application]::EnableVisualStyles()


#Set All labels and text, can potentially be used for localisation
$LabelForm              = "Lynx Wrapper"
$LabelOptions           = "Optionen"
$LabelTTOptions         = $LabelOptions
$TextTTOptions          = "Öffnet das Optionsmenü"
$LabelRefresh           = "Aktualisieren"
$LabelTTRefresh         = $LabelRefresh
$TextTTRefresh          = "Liste der Läufe aktualisieren"
$LabelCheckSingleRace   = "Neue Läufe (Single User)"
$LabelTTCheckSingleRace = $LabelCheckSingleRace
$TextTTCheckSingleRace  = "Zeige gespeicherte Läufe ohne Bilddaten (Single User)"
$LabelCheckMultiRace    = "Neue Läufe (Multi User)"
$LabelTTCheckMultiRace  = $LabelCheckMultiRace
$TextTTCheckMultiRace   = "Zeige gespeicherte Läufe ohne Bilddaten (Multi User)"
$LabelCheckNotJudged    = "Nicht ausgewertete Läufe"
$LabelTTCheckNotJudged  = $LabelCheckNotJudged
$TextTTCheckNotJudged   = "Zeige Läufe mit Bilddaten, die noch nicht ausgewertet sind"
$LabelCheckJudged       = "Ausgewertete Läufe"
$LabelTTCheckJudged     = $LabelCheckJudged
$TextTTCheckJudged      = "Zeige ausgewertete Läufe"

$ButtonLabels           = $LabelOptions,$LabelRefresh
$CheckLabels            = $LabelCheckSingleRace,$LabelCheckMultiRace,$LabelCheckNotJudged,$LabelCheckJudged

#Calculate Label sizes and window size
$font = New-Object System.Drawing.Font('Microsoft Sans Serif', 12, [System.Drawing.FontStyle]'Bold')
$ButtonLabelWidth =  ($ButtonLabels | ForEach-Object -Process {[System.Windows.Forms.TextRenderer]::MeasureText($_, $font)} | Measure-Object Width -Maximum).Maximum
$ButtonLabelHeight = ([System.Windows.Forms.TextRenderer]::MeasureText($ButtonLabels[0], $font)).Height

$font = New-Object System.Drawing.Font('Microsoft Sans Serif', 10)
$CheckLabelWidth = ($CheckLabels | ForEach-Object -Process {[System.Windows.Forms.TextRenderer]::MeasureText($_, $font)} | Measure-Object Width -Maximum).Maximum
$CheckLabelHeight = ( [System.Windows.Forms.TextRenderer]::MeasureText($CheckLabels[0], $font)).Height
Write-Host "$CheckLabelWidth , $CheckLabelHeight"


$LynxWrapper                  = New-Object system.Windows.Forms.Form
$LynxWrapper.ClientSize       = '500,565'
$LynxWrapper.text             = $LabelForm
$LynxWrapper.BackColor        = "#c8c8c8"
$LynxWrapper.TopMost          = $false

$TTOptions                       = New-Object system.Windows.Forms.ToolTip
$TTOptions.ToolTipTitle          = $LabeTTlOptions

$Options                         = New-Object system.Windows.Forms.Button
$Options.BackColor               = "#ffffff"
$Options.text                    = $LabelOptions
$Options.width                   = 120
$Options.height                  = 35
$Options.location                = New-Object System.Drawing.Point(30,15)
$Options.Font                    = 'Microsoft Sans Serif,12,style=Bold'

$TTRefresh                       = New-Object system.Windows.Forms.ToolTip
$TTRefresh.ToolTipTitle          = $LabelRefresh

$Refresh                         = New-Object system.Windows.Forms.Button
$Refresh.BackColor               = "#ffffff"
$Refresh.text                    = $LabelTTRefresh
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
$TTNewRaceSingle.ToolTipTitle    = $LabelTTCheckSingleRace

$ShowNewRaceSingle               = New-Object system.Windows.Forms.CheckBox
$ShowNewRaceSingle.text          = $LabelCheckSingleRace
$ShowNewRaceSingle.AutoSize      = $false
$ShowNewRaceSingle.BackColor     = "#ffff4d"
$ShowNewRaceSingle.width         = 200
$ShowNewRaceSingle.height        = 25
$ShowNewRaceSingle.location      = New-Object System.Drawing.Point(30,480)
$ShowNewRaceSingle.Font          = 'Microsoft Sans Serif,10'

$TTNewRaceMulti                  = New-Object system.Windows.Forms.ToolTip
$TTNewRaceMulti.ToolTipTitle     = $LabelTTCheckMultiRace

$ShowNewRaceMulti                = New-Object system.Windows.Forms.CheckBox
$ShowNewRaceMulti.text           = $LabelCheckMultiRace
$ShowNewRaceMulti.AutoSize       = $false
$ShowNewRaceMulti.BackColor      = "#38ea2e"
$ShowNewRaceMulti.width          = 200
$ShowNewRaceMulti.height         = 25
$ShowNewRaceMulti.location       = New-Object System.Drawing.Point(270,480)
$ShowNewRaceMulti.Font           = 'Microsoft Sans Serif,10'

$TTNotJudgedRace                 = New-Object system.Windows.Forms.ToolTip
$TTNotJudgedRace.ToolTipTitle    = $LabelCheckNotJudged

$ShowNotJudgedRace               = New-Object system.Windows.Forms.CheckBox
$ShowNotJudgedRace.text          = $LabelCheckNotJudged
$ShowNotJudgedRace.AutoSize      = $false
$ShowNotJudgedRace.BackColor     = "#66a3ff"
$ShowNotJudgedRace.width         = 200
$ShowNotJudgedRace.height        = 25
$ShowNotJudgedRace.location      = New-Object System.Drawing.Point(30,520)
$ShowNotJudgedRace.Font          = 'Microsoft Sans Serif,10'

$TTJudgedRace                    = New-Object system.Windows.Forms.ToolTip
$TTJudgedRace.ToolTipTitle       = $LabelCheckJudged

$ShowJudgedRace                  = New-Object system.Windows.Forms.CheckBox
$ShowJudgedRace.text             = $LabelCheckJudged
$ShowJudgedRace.AutoSize         = $false
$ShowJudgedRace.BackColor        = "#ff80ff"
$ShowJudgedRace.width            = 200
$ShowJudgedRace.height           = 20
$ShowJudgedRace.location         = New-Object System.Drawing.Point(270,520)
$ShowJudgedRace.Font             = 'Microsoft Sans Serif,10'

$TTOptions.SetToolTip($Options,$TextTTOptions)
$TTRefresh.SetToolTip($Refresh,$TextTTRefresh)
$TTNewRaceSingle.SetToolTip($ShowNewRaceSingle,$TextTTCheckSingleRace)
$TTNewRaceMulti.SetToolTip($ShowNewRaceMulti,$TextTTCheckMultiRace)
$TTNotJudgedRace.SetToolTip($ShowNotJudgedRace,$TextTTCheckNotJudged)
$TTJudgedRace.SetToolTip($ShowJudgedRace,$TextTTCheckJudged)
$LynxWrapper.controls.AddRange(@($Options,$Refresh,$RaceList,$ShowNewRaceSingle,$ShowNewRaceMulti,$ShowNotJudgedRace,$ShowJudgedRace))

$RaceList.Add_Click({ handleListviewclick $this $_ })

function handleListviewclick ($sender,$event) { }


#Write your logic code here

[void]$LynxWrapper.ShowDialog()