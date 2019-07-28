# DestinyItemTagger

This application automatically tags armour and weapons in DIM depending on rules that you setup in the included spreadsheets.

You can specify sets of perks that will tag the item as "Favourite" in DIM if all they appear on the same item.
For weapons these perk sets are weapon type specific, for amour they are not.

You can give each perk a score and items will be tagged in DIM as "Keep" if the score of all the perks is equal to or above a specified level.  The armour and weapon perk scores are type specific.

Usage
1. Go to setting in DIM and scroll to the spreadsheets section at the bottom
2. Export destinyWeapons.csv and destinyArmour.csv then place them in the same folder as the app
3. Peruse the other spreadsheets to check out the perk sets and perk scores
4. Launch the application and change the perk score level if desired
5. Click Tag and the tagged items will be displayed
6. Click Export and a new file dimImport.csv will be created in the application folder
7. Go back to the spreadsheet section in DIM and import the dimImport.csv file
8. Use a dim filter to show the items for dismantlement "tag:none -is:exotic -is:masterwork"

Enjoy!
