public class Inventory {
	private List<Weapon> weapons;
	private List<Craft> crafting;
	private List<Item> misc;

	public List<Weapon> getWeapons(){
		return this.weapons;
	}
	public void setWeapons(List<Weapon> newWeapons) {
		this.weapons = newWeapons;
	}
	public void addWeapon(Weapon newWeapon) {
		this.weapons.Add(newWeapon);
	}
	public void removeWeapon(Weapon oldWeapon) {
		this.weapons.Remove(oldWeapon);
	}
	public List<Craft> getCrafting(){
		return this.crafting;
	}
	public void setCrafting(List<Craft> newCrafts) {
		this.crafting = newCrafts;
	}
	public void addCraft(Craft newCraft) {
		this.crafting.Add(newCraft);
	}
	public void removeCraft(Craft oldCraft) {
		this.crafting.Remove(oldCraft);
	}
	public List<Item> getItems(){
		return this.misc;
	}
	public void setItems(List<Item> newItems) {
		this.misc = newItems;
	}
	public void addItem(Item newItem) {
		this.misc.Add(newItem);
	}
	public void removeItem(Item oldItem) {
		this.misc.Remove(oldItem);
	}

}