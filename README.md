## Download
[Download DestinyItemTagger.zip](DestinyItemTagger.zip)

## Overview
This application automatically tags armour and weapons in DIM depending on rules that you setup in the included spreadsheets.

## Rules
### Perk Sets
You can specify Perk Sets that will tag an item as "Favourite" in DIM if all the perks in a set appear on the same item.
For weapons these Perk Sets are weapon type specific, for amour they are not.
### Perk Scores
You can give Perks a Score and items will be tagged in DIM as "Keep" if the score of all the perks on an item adds up to be equal to or above the specified Perk Score Level.  The armour and weapon Perk Scores are item type specific.
### Power Level
You can specify a Power Level and items will be tagged with "Infuse" if they have the same or higher PowerLevel. You can also choose if you want to include the "Infuse" tag in the export.
### Example Rules
Example perk rule spreadsheets based on common reddit wisdom are included in DestinyItemTagger.zip.

## Usage
1. Download and unzip DestinyItemTagger.zip
2. Go to settings in DIM and scroll to the spreadsheets section at the bottom
3. Export destinyWeapons.csv and destinyArmour.csv then place them in the same folder as the unzipped app
4. Peruse the other spreadsheets in this folder to check out the perk sets and perk scores and change them if desired
5. Launch the application and change the armour perk score, weapon perk score and power level if desired
6. Click Export and a new file dimImport.csv will be created in the application folder
7. Go back to the spreadsheet section in DIM and import the dimImport.csv file
8. Use a dim filter to show the items for dismantlement, I use "tag:none -is:exotic -is:masterwork"

## Finally
Enjoy!
