Melee Functionality:

	* dealDamage(ICharacter): int
		Deals damage to provided character object and returns 


Melee Attributes:

	* damage: float
		The amount of damage issued to character
	* name: string
		Name of the weapon
	* weight: float
		The weight of the weapon
	* description: string
		Description of the weapon
	* texture: Texture2D
		Image of weapon
	* class: int
		Level/Class of weapon. For example, player will first create Level/Class 1 and upgrade to Level/Class 2, 		etc..
	* isBroken: bool
		True if weapon is broken, false if not broken.
	* durability: float
		The amount of damage a weapon can sustain before breaking.
	* bonus: float
		Bonus that will be added to weapon's damage. Defaults to 0.
