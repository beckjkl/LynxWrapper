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

$Margin                 = 20

#Calculate Label sizes and window size
$font                   = New-Object System.Drawing.Font('Microsoft Sans Serif', 12, [System.Drawing.FontStyle]'Bold')
$ButtonLabelWidth       =  ($ButtonLabels | ForEach-Object -Process {[System.Windows.Forms.TextRenderer]::MeasureText($_, $font)} | Measure-Object Width -Maximum).Maximum
$ButtonLabelHeight      = ([System.Windows.Forms.TextRenderer]::MeasureText($ButtonLabels[0], $font)).Height

$ButtonWidth            = $ButtonLabelWidth * 1.2
$ButtonHeight           = $ButtonLabelHeight * 1.2

$font                   = New-Object System.Drawing.Font('Microsoft Sans Serif', 10)
$CheckLabelWidth        = ($CheckLabels | ForEach-Object -Process {[System.Windows.Forms.TextRenderer]::MeasureText($_, $font)} | Measure-Object Width -Maximum).Maximum
$CheckLabelHeight       = ( [System.Windows.Forms.TextRenderer]::MeasureText($CheckLabels[0], $font)).Height

$CheckBoxMargin         = 10
$CheckWidth             = ($CheckLabelWidth + $CheckBoxMargin) * 1.2
$CheckHeight            = $CheckLabelHeight * 1.2

#Set Object Positions and sizes
$DefaultFontWidth       = $Margin + $CheckWidth + $Margin + $CheckWidth + $Margin
$DefaultFontHeight      = 500


$LynxWrapper                  = New-Object System.Windows.Forms.Form
$LynxWrapper.ClientSize       = New-Object System.Drawing.Size($DefaultFontWidth,$DefaultFontHeight)
$LynxWrapper.text             = $LabelForm
$LynxWrapper.BackColor        = "#c8c8c8"
$LynxWrapper.TopMost          = $false

$TTOptions                       = New-Object System.Windows.Forms.ToolTip
$TTOptions.ToolTipTitle          = $LabelTTOptions

$Options                         = New-Object System.Windows.Forms.Button
$Options.BackColor               = "#ffffff"
$Options.text                    = $LabelOptions
$Options.width                   = $ButtonWidth
$Options.height                  = $ButtonHeight
$Options.location                = New-Object System.Drawing.Point($Margin,$Margin)
$Options.Font                    = 'Microsoft Sans Serif,12,style=Bold'

$TTRefresh                       = New-Object System.Windows.Forms.ToolTip
$TTRefresh.ToolTipTitle          = $LabelRefresh

$Refresh                         = New-Object System.Windows.Forms.Button
$Refresh.BackColor               = "#ffffff"
$Refresh.text                    = $LabelTTRefresh
$Refresh.width                   = $ButtonWidth
$Refresh.height                  = $ButtonHeight
$Refresh.location                = New-Object System.Drawing.Point(($DefaultFontWidth - ($ButtonWidth + $Margin)),$Margin)
$Refresh.Font                    = 'Microsoft Sans Serif,12,style=Bold'

$RaceList                        = New-Object System.Windows.Forms.ListView
$RaceList.text                   = "listView"
$RaceList.width                  = $DefaultFontWidth - (2 * $Margin)
$RaceList.height                 = $DefaultFontHeight - ($ButtonHeight + 2 * $CheckHeight + 5 * $Margin)
$RaceList.visible                = $true
$RaceList.enabled                = $true
$RaceList.location               = New-Object System.Drawing.Point($Margin,($ButtonHeight + 2 * $Margin))

$TTNewRaceSingle                 = New-Object System.Windows.Forms.ToolTip
$TTNewRaceSingle.ToolTipTitle    = $LabelTTCheckSingleRace

$ShowNewRaceSingle               = New-Object System.Windows.Forms.CheckBox
$ShowNewRaceSingle.text          = $LabelCheckSingleRace
$ShowNewRaceSingle.AutoSize      = $false
$ShowNewRaceSingle.BackColor     = "#ffff4d"
$ShowNewRaceSingle.width         = $CheckWidth
$ShowNewRaceSingle.height        = $CheckHeight
$ShowNewRaceSingle.location      = New-Object System.Drawing.Point($Margin,($DefaultFontHeight - 2 * ($Margin + $CheckHeight)))
$ShowNewRaceSingle.Font          = 'Microsoft Sans Serif,10'

$TTNewRaceMulti                  = New-Object System.Windows.Forms.ToolTip
$TTNewRaceMulti.ToolTipTitle     = $LabelTTCheckMultiRace

$ShowNewRaceMulti                = New-Object System.Windows.Forms.CheckBox
$ShowNewRaceMulti.text           = $LabelCheckMultiRace
$ShowNewRaceMulti.AutoSize       = $false
$ShowNewRaceMulti.BackColor      = "#38ea2e"
$ShowNewRaceMulti.width          = $CheckWidth
$ShowNewRaceMulti.height         = $CheckHeight
$ShowNewRaceMulti.location       = New-Object System.Drawing.Point((2 * $Margin + $CheckWidth),($DefaultFontHeight - 2 * ($Margin + $CheckHeight)))
$ShowNewRaceMulti.Font           = 'Microsoft Sans Serif,10'

$TTNotJudgedRace                 = New-Object System.Windows.Forms.ToolTip
$TTNotJudgedRace.ToolTipTitle    = $LabelCheckNotJudged

$ShowNotJudgedRace               = New-Object System.Windows.Forms.CheckBox
$ShowNotJudgedRace.text          = $LabelCheckNotJudged
$ShowNotJudgedRace.AutoSize      = $false
$ShowNotJudgedRace.BackColor     = "#66a3ff"
$ShowNotJudgedRace.width         = $CheckWidth
$ShowNotJudgedRace.height        = $CheckHeight
$ShowNotJudgedRace.location      = New-Object System.Drawing.Point($Margin,($DefaultFontHeight - ($Margin + $CheckHeight)))
$ShowNotJudgedRace.Font          = 'Microsoft Sans Serif,10'

$TTJudgedRace                    = New-Object System.Windows.Forms.ToolTip
$TTJudgedRace.ToolTipTitle       = $LabelCheckJudged

$ShowJudgedRace                  = New-Object System.Windows.Forms.CheckBox
$ShowJudgedRace.text             = $LabelCheckJudged
$ShowJudgedRace.AutoSize         = $false
$ShowJudgedRace.BackColor        = "#ff80ff"
$ShowJudgedRace.width            = $CheckWidth
$ShowJudgedRace.height           = $CheckHeight
$ShowJudgedRace.location         = New-Object System.Drawing.Point((2 * $Margin + $CheckWidth),($DefaultFontHeight - ($Margin + $CheckHeight)))
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