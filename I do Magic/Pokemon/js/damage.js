/*
    All Rights Reserved
    This software is proprietary information of
    Intelligent Sense
    Use is subject to license terms.
    Filename: damage.js
*/

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
	
	if(typeFirstPokemon == typeSecondPokemon){
		power = 1;
	} else if(typeFirstPokemon == "fire" && typeSecondPokemon=="grass"){
		power = 2;
	} else if(typeFirstPokemon == "fire" && typeSecondPokemon=="water"){
		power = 0.5;
	} else if(typeFirstPokemon == "water" && typeSecondPokemon=="grass"){
		power = 0.5;
	} else if(typeFirstPokemon == "water" && typeSecondPokemon=="electric"){
		power = 0.5;
	} else if(typeFirstPokemon == "grass" && typeSecondPokemon=="electric"){
		power = 1;
	} else if(typeFirstPokemon == "fire" && typeSecondPokemon=="electric"){
		power = 1;
	}

	damage = 50 * (pFirstPokemon.attack / pFirstPokemon.defense) * power;
	damage = Math.round(damage);

	document.write("El daño que causa " + pFirstPokemon.name + " a " + pSecondPokemon.name + " es: " + damage);
	console.log("El daño que causa " + pFirstPokemon.name + " a " + pSecondPokemon.name + " es: " + damage);

	return damage;
}

			
var firstPokemon = new pokemon("squirtle", "water", 82.5, 50.3);
var secondPokemon = new pokemon("pikachu", "electric", 70, 40);
console.log(damage(firstPokemon, secondPokemon));