/*
    All Rights Reserved
    This software is proprietary information of
    Intelligent Sense
    Use is subject to license terms.
    Filename: damage.js
*/

var fights = [
	{firstPokemon: "fire", secondPokemon: "grass", damage: 2},
	{firstPokemon: "fire", secondPokemon: "water", damage: 0.5},
	{firstPokemon: "water", secondPokemon: "grass", damage: 0.5},
	{firstPokemon: "water", secondPokemon: "electric", damage: 0.5},
	{firstPokemon: "water", secondPokemon: "electric", damage: 0.5},
	{firstPokemon: "grass", secondPokemon: "electric", damage: 1},
	{firstPokemon: "fire", secondPokemon: "electric", damage: 1},
	]

var firstPokemon = new pokemon("squirtle", "water", 82.5, 50.3);
var secondPokemon = new pokemon("pikachu", "water", 70, 40);

function pokemon(pName, pType, pAttack, pDefense){
	this.name = pName;
	this.type = pType;
	this.attack = pAttack;
	this.defense = pDefense;
}

function damage(pFirstPokemon, pSecondPokemon) {
	var damage;
	var power;	

	var typeFirstPokemon = pFirstPokemon.type; 
	var typeSecondPokemon = pSecondPokemon.type;
	
	if (typeFirstPokemon == typeSecondPokemon) {
		power = 1;
	}

	for(var indexFirstPokemon = 0; indexFirstPokemon < fights.length; indexFirstPokemon++){
		if(typeFirstPokemon === fights[indexFirstPokemon].firstPokemon){
			for (var indexSecondPokemon = 0; indexSecondPokemon < fights.length; indexSecondPokemon++) {
				if(typeSecondPokemon === fights[indexSecondPokemon].secondPokemon){
					power = fights[indexSecondPokemon].damage;
					damage = Math.round(50 * (pFirstPokemon.attack / pSecondPokemon.defense) * power);
					document.write("El daño que causa " + pFirstPokemon.name + " a " + pSecondPokemon.name + " es: " + damage);
					console.log("El daño que causa " + pFirstPokemon.name + " a " + pSecondPokemon.name + " es: " + damage);
					return damage

				}
			}
		}

	}

	
	// if(typeFirstPokemon == typeSecondPokemon){
	// 	power = 1;
	// } else if(typeFirstPokemon == "fire" && typeSecondPokemon=="grass"){
	// 	power = 2;
	// } else if(typeFirstPokemon == "fire" && typeSecondPokemon=="water"){
	// 	power = 0.5;
	// } else if(typeFirstPokemon == "water" && typeSecondPokemon=="grass"){
	// 	power = 0.5;
	// } else if(typeFirstPokemon == "water" && typeSecondPokemon=="electric"){
	// 	power = 0.5;
	// } else if(typeFirstPokemon == "grass" && typeSecondPokemon=="electric"){
	// 	power = 1;
	// } else if(typeFirstPokemon == "fire" && typeSecondPokemon=="electric"){
	// 	power = 1;
	// }

	// damage = 50 * (pFirstPokemon.attack / pFirstPokemon.defense) * power;
	// damage = Math.round(damage);

	// document.write("El daño que causa " + pFirstPokemon.name + " a " + pSecondPokemon.name + " es: " + damage);
	// console.log("El daño que causa " + pFirstPokemon.name + " a " + pSecondPokemon.name + " es: " + damage);

	// return damage;
}

		
damage(firstPokemon, secondPokemon);