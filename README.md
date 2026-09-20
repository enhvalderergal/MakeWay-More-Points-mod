# Longer Games

A simple **Make Way** mod that adds higher **Points to Win** options for longer matches.

## Installation

1. Download and install **MelonLoader** using the MelonLoader Installer:

   [MelonLoader Installer v4.3.0](https://github.com/LavaGang/MelonLoader.Installer/releases/tag/4.3.0)

2. Install MelonLoader for **Make Way**.

3. Locate your Make Way installation folder.

4. Place `MakeWay.dll` inside the `Mods` folder:

   `Make Way/Mods/MakeWay.dll`

5. Launch the game.

That's it. The additional Points to Win options will appear in the Battle Settings menu.

## Added Points to Win

The mod extends the normal Points to Win selection with:

* 7,000
* 8,000
* 9,000
* 10,000
* 12,000
* 15,000

The original values from 3,000 to 6,000 remain available.

## Source Code

The main source code for the mod is included in `Main.cs`.

The mod works by extending Make Way's existing `PointsToWin` selector with additional values. The game then uses its normal battle settings and scoring system to apply the selected value when the match starts.

## Version

**1.0.0**

Created by **TheMadWhale**
