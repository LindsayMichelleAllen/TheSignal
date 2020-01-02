public class MainPlayer {
	private string name;
	private Statistics stats;
	private Inventory inventory;
	private List<string> shortcuts;
	private List<Spell> magic;

	public string getName() {
		return this.name;
	}
	public void setName(string newName){
		this.name = newName;
	}
	public Statistics getStats() {
		return this.stats;
	}
	public void setStats(Statistics newStats) {
		this.stats = newStats;
	}
	public Inventory getInventory() {
		return this.inventory;
	}
	public void setInventory(Inventory newInventory) {
		this.inventory = newInventory;
	}
	public List<string> getShortcuts() {
		return this.shortcuts;
	}
	public void setShortcuts(List<string> newShortcuts) {
		this.shortcuts = newShortcuts;
	}
	public void addShortcut(string newShortcut) {
		this.shortcuts.Add(newShortcut);
	}
	public void removeShortcut(string oldShortcut) {
		this.shortcuts.Remove(oldShortcut);
	}
}
