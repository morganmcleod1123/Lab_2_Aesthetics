Lab_2_Aesthetics Eval Doc

Our game was inspired by the groundhog demo in which a single player wanders a 2D map and discovers obstacles. Using the arrows or the WASD input the user can move in any direction to find and pick up stamps by colliding with them. The user is then prompted to “deliver” the stamps to the houses that are scattered around the map. What is every mailman’s worst enemy? Dogs! If the dog collides with the mailman the game starts over and the user must try again. There are also signs with dialog that have been placed near the starting place of the mailman so that the user can quickly understand the objective. In order to match the simplicity of the game, we decided to go with a pixelated aesthetic approach. Each sprite was carefully selected to match the pixel theme along with the tilemap.

There were a lot of joys and struggles during the project. It was really fun to create the dog’s movements. It has the beginning prospects for an NPC. As always working with Github can be difficult. If partners try to push things at the same time, it is difficult to find which files should be merged and which should be dropped. Additionally, it was frustrating making the barrier that blocks you from winning the game. The GameManager keeps track of the number of stamps that the user has picked up and delivered. It was difficult trying to link this float to another script for the locked barrier. Initially, we tried using the same method of calling upon the float as we had with calling upon a method in GameManger (i.e. GameManger.Instance.score), but that didn’t work. So we moved to create a method in GameManger that returned the score that we could call upon in the new script which seemed to work.

There was a lot of overlap between the contributions. For instance, Olivia made the dog gave it movements but Morgan created more dogs to add more obstacles for the mailman. Morgan created the tilemap and Olivia made the barriers that go around the map so that the player cannot escape the game. Olivia started to make the locked barrier that keeps the win game function away from the user until they have completed their goal and then Morgan finished it. Morgan modified the end game function, that Olivia had written, which happens when you collide with the dog. Olivia made the start screen and Morgan made the end screen. Morgan also made the water that speeds the user up and added a trail behind the user. Also once the player picks up the stamp (using the function Olivia wrote) and delivers it to the house, a particle system of stars occurs (that Morgan made).


Attributions:

stamp Icons made by "https://www.freepik.com" title="Freepik">Freepik</a> from <a href="https://www.flaticon.com/" title="Flaticon">www.flaticon.com</a></div>

dog https://opengameart.org/content/pug-rework
House and Mailman: https://bakudas.itch.io/generic-rpg-pack
Background Tileset https://stealthix.itch.io/rpg-nature-tileset
mail sound https://freesound.org/people/eggtimer/sounds/103066/
