<# This form was created using POSHGUI.com  a free online gui designer for PowerShell
.NAME
    Lynx-Wrapper
.SYNOPSIS
    Hlper Application for Lynx
.DESCRIPTION
    This application helps with using Finishlynx by organizing folder for you and giving you quick access and overview over all races of the current event.
#>

Add-Type -AssemblyName System.Windows.Forms
Add-Type -AssemblyName System.Drawing
[System.Windows.Forms.Application]::EnableVisualStyles()

$LynxWrapper                  = New-Object system.Windows.Forms.Form
$LynxWrapper.ClientSize       = '500,600'
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
$RaceList.location               = New-Object System.Drawing.Point(20,65)
$RaceList.Items

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

$TTNewRaceMulti             = New-Object system.Windows.Forms.ToolTip
$TTNewRaceMulti.ToolTipTitle  = "Neue Läufe (Multi User)"

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

$ShowRaceNotJudged               = New-Object system.Windows.Forms.CheckBox
$ShowRaceNotJudged.text          = "Nicht ausgewertete Läufe"
$ShowRaceNotJudged.AutoSize      = $false
$ShowRaceNotJudged.BackColor     = "#66a3ff"
$ShowRaceNotJudged.width         = 200
$ShowRaceNotJudged.height        = 25
$ShowRaceNotJudged.location      = New-Object System.Drawing.Point(30,520)
$ShowRaceNotJudged.Font          = 'Microsoft Sans Serif,10'
$ShowRaceNotJudged.Checked       = $true

$TTJudgedRace                    = New-Object system.Windows.Forms.ToolTip
$TTJudgedRace.ToolTipTitle       = "Zeige ausgewertete Läufe"

$ShowJudgedRaces                 = New-Object system.Windows.Forms.CheckBox
$ShowJudgedRaces.text            = "Ausgewertete Läufe"
$ShowJudgedRaces.AutoSize        = $false
$ShowJudgedRaces.BackColor       = "#ff80ff"
$ShowJudgedRaces.width           = 200
$ShowJudgedRaces.height          = 20
$ShowJudgedRaces.location        = New-Object System.Drawing.Point(270,520)
$ShowJudgedRaces.Font            = 'Microsoft Sans Serif,10'

$TTOptions.SetToolTip($Options,'Öffnet das Optionsmenü')
$TTRefresh.SetToolTip($Refresh,'Liste der Läufe aktualisieren')
$TTNewRaceSingle.SetToolTip($ShowNewRaceSingle,'Zeige gespeicherte Läufe ohne Bilddaten (Single User)')
$TTNewRaceMulti.SetToolTip($ShowNewRaceMulti,'Zeige gespeicherte Läufe ohne Bilddaten (Multi User)')
$TTNotJudgedRace.SetToolTip($ShowRaceNotJudged,'Zeige Läufe mit Bilddaten, die noch nicht ausgewertet sind')
$TTJudgedRace.SetToolTip($ShowJudgedRaces,'undefined')
$LynxWrapper.controls.AddRange(@($Options,$Refresh,$RaceList,$ShowNewRaceSingle,$ShowNewRaceMulti,$ShowRaceNotJudged,$ShowJudgedRaces))

#Write your logic code here

$RaceList.View = 'Details'

$RaceColumn1 = New-Object System.Windows.Forms.ColumnHeader
$RaceColumn1.DisplayIndex = 0
$RaceColumn1.Text = "Lauf"
$RaceColumn1.Width = 150

$RaceColumn2 = New-Object System.Windows.Forms.ColumnHeader
$RaceColumn2.DisplayIndex = 1
$RaceColumn2.Text = "Status"
$RaceColumn2.Width = 150

$RaceColumn3 = New-Object System.Windows.Forms.ColumnHeader
$RaceColumn3.DisplayIndex = 2
$RaceColumn3.Text = "Letzte Änderung"
$RaceColumn3.Width = 110

$RaceList.Columns.Add($RaceColumn1)
$RaceList.Columns.Add($RaceColumn2)
$RaceList.Columns.Add($RaceColumn3)

$Race1 = New-Object System.Windows.Forms.ListViewItem('60m MJU 14 Lauf 2')
$Race1.SubItems.Add('Neuer Lauf (Single User)')
$Race1.SubItems.Add('14:05')

$Race2 = New-Object System.Windows.Forms.ListViewItem('Rennen mit Übermäßig langem Namen .............')
$Race2.SubItems.Add('Nicht ausgewerteter Lauf')
$Race2.SubItems.Add('13:20')
$Race2.Subitems[1].BackColor="#38ea2e"


$RaceList.Items.Add($Race1)
$RaceList.Items.Add($Race2)

$RaceList.Items[0].UseItemStyleForSubItems = $false
$RaceList.Items[0].SubItems[1].BackColor="#38ea2e"
$RaceList.Items[1].UseItemStyleForSubItems = $false



$RaceList.Add_Click({Write-Host $RaceList.SelectedIndices})
$LynxWrapper.Add_Resize({Write-Host $LynxWrapper.Width $LynxWrapper.Height})


$Folder = Get-ChildItem Z:\
$EventFiles=$Folder | Where-Object Name -like "*.evn"
$FinishFiles=$Folder | Where-Object Name -like "*.i01"

Write-Host $Folder
Write-Host $EventFiles
Write-Host $FinishFiles

foreach ($File in $EventFiles){

    $SearchFile=($File.Name.split("."))[0]+".i01"
    
    #Write-Host "Checking" $Searchfile
    
    $InsertRace = New-Object System.Windows.Forms.ListViewItem(($File.Name.Split("."))[0])

    if($FinishFiles.Name.Contains($SearchFile)){
        $InsertRace.SubItems.Add('Nicht ausgewerteter Lauf')
        $InsertRace.SubItems[1].BackColor="#66a3ff"

    } else {
        $InsertRace.SubItems.Add('Neuer Lauf (Single User)')
        $InsertRace.SubItems[1].BackColor="#ffff4d"
    }
    $InsertRace.SubItems.Add($File.LastWriteTime.ToString())
    $RaceList.Items.Add($InsertRace)
}
foreach ($Item in $RaceList.Items){$Item.UseItemStyleForSubItems = $false}

[void]$LynxWrapper.ShowDialog()