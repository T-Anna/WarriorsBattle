# WarriorsBattle

This is my implementation of simple game introduced in [this tutorial](https://www.youtube.com/watch?v=decfmj7b5Vg&list=PLGLfVvz_LVvRX6xK1oi0reKci6ignjdSa&index=9) where 2 warriors fight against each other until one of them dies. 

Each **warrior** is characterized by:

- Initial health points
- Maximum points of attack they can deal in a single combat
- Maximum points of block they can use when defending an attack in a single combat

**Game** consists of single **combats** where one of warriors attack and the other block attacks. Attack's and block's points are random, determined based on maximum points of attack or blocks for a given warrior. After a combat health of defender is decreased if the attack points were greater than block points.

After one combat the order of attacker and defender changes. Warriors continue fighting until one of them dies.

Program assumes correct input data.
