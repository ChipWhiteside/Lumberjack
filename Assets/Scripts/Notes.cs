/*
* The player has weapon sheath's they can put on which allow them to holster different
* weapon types on themselves to free up hand space (so they arent holding anything.
* 
* If a player only has a knife sheath equipped and they find a longsword, if they want to take that longsword back
* they have to sheath their knives and use their hands to hold the sword.
* 
* Players have their backpack which is where they store materials and small items
* Also have sheath inventory slots which show up in the.
* 
* Character slots include:
* Hands (always, nothing needs to be equipped for this slot to be available)
* Back sheath (Carries longsword, sheild, battle axe)
* Hip sheath (carries one handed sword, short axe (1 or 2), woodcutters axe, knives (1 or 2))
* Chest sheath (knives (1 or 2))
* 
* Animations: Make a "Front Hand Axe" animation which can be reflected for whether the player puts 
* the axe in the right or left hand.
* Make full idle animation of player with say the sword and sheild or running or something and keep limbs 
* on seperate layers so you can draw a new shield model to look and act the same as the old one in each animation.
* 
* The item equipped to the hands is the only item that shows on the player character in game,
* if that item is switched then it disappears and the new item shows but it is still in the
* players sheath inventory.
* 
* The player can carry different sheaths in their backpack that arent equipped to their person
* so the negative mulitplyers dont apply but if they find a weapon 
* 
* Player can take off backpack to be lighter and faster during a fight but if they die without 
* their backpack they loose all the items inside.
*/