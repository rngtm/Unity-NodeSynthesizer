# Unity-NodeSynthesizer
Nose-Based Synthesizer on UnityEditor, based on xNode.<br>

GitHub - Siccity/xNode: Lets you view and edit node graphs inside Unity<br>
https://github.com/Siccity/xNode

# Unity Version
Unity 2018.3.0f1<br>

# Usage
## Create SoundGraph
Right click on Project window, <br>
select **Create/SoundGraph**. <br>

<img src = "Demo/1_create_soundgraph.png"><br>

The following is a **SoundGraph** asset.<br>
<img src = "Demo/2_soundasset.png"><br>

## Open SoundGraph
To open SoundGraph asset, double click SoundGraph asset.<br>

Double clicking SoundGraph asset will open xNode Window.<br>
<img src = "Demo/3_window.png"><br>

## Create Sound
To create sound, you must create Oscillator and Output Node.<br>

### Create OutputNode
Output Master node output sound to speaker.<br>

<img src = "Demo/5_output_master.png" width = 240><br>

Right click and *select* **Sound Node Graph > Output > Output Master**<br>
<img src = "Demo/4_select_output.png">

### Create Oscillator Node
**Sine Osc** node generates sine wave.<br>
<img src = "Demo/7_sin.png" width = 240><br>

Right click and *select* **Sound Node Graph > Generator > Sine Osc**<br>

<img src = "Demo/6_create_sin.png"><br>

### Output Sound
Connect Sine OSC node and Output Master node.<br>
<img src = "Demo/8_connect.png"><br>

## PlaySound
Add SoundGraphPlayer component to GameObject.<br>
Assign SoundGraph asset to SoundGraphPlayer.<br>
<img src = "Demo/9_SoundGraphPlayer.png"><br>
<br>
Sound will be played at run time.<br>


