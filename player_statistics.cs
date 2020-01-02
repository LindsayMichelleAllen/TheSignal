
public class Statistics {
	private PlayerRank rank;
	private Health health;
	private Nanos nanos;

	public PlayerRank getRank(){
		return this.rank;
	}
	public void setRank(PlayerRank newRank) {
		this.rank = newRank;
	}
	public Health getHealth() {
		return this.health;
	}
	public void setHealth(Health newHealth) {
		this.health = newHealth;
	}
	public Nanos getNanos() {
		return this.nanos;
	}
	public void setNanos(Nanos newNanos) {
		this.nanos = newNanos;
	}
}